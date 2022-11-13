using System;

namespace KitX.Web.Rules
{
    /// <summary>
    /// 设备信息结构
    /// </summary>
    public struct DeviceInfoStruct
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备系统版本
        /// </summary>
        public string DeviceOSVersion { get; set; }

        /// <summary>
        /// 内网IPv4地址
        /// </summary>
        public string IPv4 { get; set; }

        /// <summary>
        /// 内网IPv6地址
        /// </summary>
        public string IPv6 { get; set; }

        /// <summary>
        /// 设备MAC地址
        /// </summary>
        public string DeviceMacAddress { get; set; }

        /// <summary>
        /// 插件服务端口
        /// </summary>
        public int PluginServerPort { get; set; }

        /// <summary>
        /// 插件数量
        /// </summary>
        public int PluginsCount { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; set; }

        /// <summary>
        /// 是否是主控设备
        /// </summary>
        public bool IsMainDevice { get; set; }

        /// <summary>
        /// 自组网服务器地址
        /// </summary>
        public int DeviceServerPort { get; set; }

        /// <summary>
        /// 自组网服务器建立时间
        /// </summary>
        public DateTime DeviceServerBuildTime { get; set; }

        /// <summary>
        /// 设备系统类型
        /// </summary>
        public OperatingSystems DeviceOSType { get; set; }
    }
}
