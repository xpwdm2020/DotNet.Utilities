﻿using MvcSolution.Core.Config;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using YanZhiwei.DotNet.Framework.Contract;
using YanZhiwei.DotNet4.Framework.Data;

namespace MvcSolution.Core.Log
{
    [Table("AuditLog")]
    public class AuditLog : ModelBase
    {
        public string EventType { get; set; }
        public int ModelId { get; set; }
        public string ModuleName { get; set; }
        public string NewValues { get; set; }
        public string TableName { get; set; }
        public string UserName { get; set; }
    }

    public class LogDbContext : DbContextBase, IAuditable
    {
        public LogDbContext()
            : base(CachedConfigContext.Current.DaoConfig.Log)
        {
            Database.SetInitializer<LogDbContext>(null);
        }

        public DbSet<AuditLog> AuditLogs { get; set; }

        public void WriteLog(int modelId, string userName, string moduleName, string tableName, string eventType, ModelBase newValues)
        {
            this.AuditLogs.Add(new AuditLog()
            {
                ModelId = modelId,
                UserName = userName,
                ModuleName = moduleName,
                TableName = tableName,
                EventType = eventType,
                NewValues = JsonConvert.SerializeObject(newValues, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })
            });

            this.SaveChanges();
            this.Dispose();
        }
    }
}