using System;

namespace KitX.Web.Rules.Device;

public class DeviceInfo
{
    public DeviceLocator Device { get; set; }

    public string DeviceOSVersion { get; set; }

    public int PluginServerPort { get; set; }

    public int PluginsCount { get; set; }

    public DateTime SendTime { get; set; }

    public bool IsMainDevice { get; set; }

    public int DevicesServerPort { get; set; }

    public DateTime DeviceServerBuildTime { get; set; }

    public OperatingSystems DeviceOSType { get; set; }
}
