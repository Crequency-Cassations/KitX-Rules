namespace KitX.Web.Rules
{
    public struct DeviceLocator
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

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
    }
}
