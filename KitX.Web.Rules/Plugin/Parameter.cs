using System.Collections.Generic;

namespace KitX.Web.Rules.Plugin;

public struct Parameter
{
    public string Name { get; set; }

    public Dictionary<string, string> DisplayNames { get; set; }

    public string Type { get; set; }

    public bool IsAppendable { get; set; }
}