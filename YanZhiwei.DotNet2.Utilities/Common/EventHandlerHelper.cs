﻿namespace YanZhiwei.DotNet2.Utilities.Common
{
    using System;

    /// <summary>
    /// EventHandler 帮助类
    /// </summary>
    public static class EventHandlerHelper
    {
        #region Methods

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="handler">The handler.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// 日期：2015-09-16 14:02
        /// 备注：
        public static void Raise(this EventHandler handler, object sender, EventArgs e)
        {
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="eventHanlder">The event hanlder.</param>
        /// <param name="sender">The sender.</param>
        /// 日期：2015-09-16 14:02
        /// 备注：
        public static void RaiseEvent(this EventHandler eventHanlder, object sender)
        {
            if (eventHanlder != null)
            {
                eventHanlder(sender, null);
            }
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <typeparam name="TEventArgs">The type of the event arguments.</typeparam>
        /// <param name="eventHanlder">The event hanlder.</param>
        /// <param name="sender">The sender.</param>
        /// 日期：2015-09-16 14:02
        /// 备注：
        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> eventHanlder, object sender)
            where TEventArgs : EventArgs
        {
            if (eventHanlder != null)
            {
                eventHanlder(sender, Activator.CreateInstance<TEventArgs>());
            }
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <typeparam name="TEventArgs">The type of the event arguments.</typeparam>
        /// <param name="eventHanlder">The event hanlder.</param>
        /// <param name="sender">The sender.</param>
        /// <param name="e"> instance containing the event data.</param>
        /// 日期：2015-09-16 14:02
        /// 备注：
        public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> eventHanlder, object sender, TEventArgs e)
            where TEventArgs : EventArgs
        {
            if (eventHanlder != null)
            {
                eventHanlder(sender, e);
            }
        }

        #endregion Methods
    }
}