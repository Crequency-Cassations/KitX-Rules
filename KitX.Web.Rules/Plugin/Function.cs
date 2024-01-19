using System.Collections.Generic;

namespace KitX.Web.Rules.Plugin;

public struct Function
{
    public string Name { get; set; }

    public Dictionary<string, string> DisplayNames { get; set; }

    public List<Parameter> Parameters { get; set; }

    public string ReturnValueType { get; set; }

    public bool IsVoidable => ReturnValueType.Equals("void");
}
