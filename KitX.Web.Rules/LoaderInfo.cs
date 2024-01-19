using System.Collections.Generic;

namespace KitX.Web.Rules;

public struct LoaderInfo
{
    public bool SelfLoad { get; set; }

    public string LoaderName { get; set; }

    public string LoaderVersion { get; set; }

    public string LoaderLanguage { get; set; }

    public string LoaderFramework { get; set; }

    public RunType LoaderRunType { get; set; }

    public List<OperatingSystems> SupportOS { get; set; }

    public enum RunType
    {
        Console, Desktop, Browser
    }

    public Dictionary<string, string> Tags { get; set; }
}