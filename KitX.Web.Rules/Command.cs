using System;
using System.Collections.Generic;

namespace KitX.Web.Rules
{
    public class Command
    {
        /// <summary>
        /// 命令类型
        /// </summary>
        public CommandType Type { get; set; }

        /// <summary>
        /// 命令发送者
        /// </summary>
        public DeviceLocator Sender { get; set; }

        /// <summary>
        /// 命令接收者
        /// </summary>
        public DeviceLocator Target { get; set; }

        /// <summary>
        /// 调用 ID
        /// </summary>
        public int CallId { get; set; }

        /// <summary>
        /// 调用 ID 生命周期
        /// </summary>
        public int CallIdTTL { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        public string Request { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        public List<string> RequestArgs { get; set; }

        /// <summary>
        /// 请求内容
        /// </summary>
        public byte[] Body { get; set; }

        /// <summary>
        /// 请求内容长度
        /// </summary>
        public int BodyLength { get; set; }

        /// <summary>
        /// 标记
        /// </summary>
        public Dictionary<string, string> Tags { get; set; }
    }

    /// <summary>
    /// Call 调用命令,
    /// CallBack 回调命令
    /// </summary>
    public enum CommandType
    {
        Call = 1, CallBack = 2
    }
}
