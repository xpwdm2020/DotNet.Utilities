﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YanZhiwei.DotNet.Framework.Contract;

namespace MvcSolution.Crm.BLL.Models
{
    [Table("City")]
    public class City : ModelBase
    {
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}