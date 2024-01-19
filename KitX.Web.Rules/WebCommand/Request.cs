using KitX.Web.Rules.WebCommand.Infos;
using KitX.Web.Rules.Device;

namespace KitX.Web.Rules.WebCommand;

public struct Request
{
    public string Type { get; set; }

    public string Version { get; set; }

    public DeviceLocator Sender { get; set; }

    public DeviceLocator Target { get; set; }

    public EncryptionInfo EncryptionInfo { get; set; }

    public CompressionInfo CompressionInfo { get; set; }

    public string Content { get; set; }
}
