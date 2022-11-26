using System.Collections.Generic;

namespace KitX.Web.Rules
{
    /// <summary>
    /// 功能体
    /// </summary>
    public class Function
    {
        /// <summary>
        /// 功能默认名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 功能显示名称列表
        /// </summary>
        public Dictionary<string, string> DisplayNames { get; set; }

        /// <summary>
        /// 参数列表
        /// key 为参数默认名称, 遵循变量命名法则
        /// value 为参数显示名称, 用于显示在界面上
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> Parameters { get; set; }

        /// <summary>
        /// 参数类型列表
        /// </summary>
        public List<string> ParametersType { get; set; }

        /// <summary>
        /// 是否有后继参数
        /// </summary>
        public bool HasAppendParameters { get; set; }

        /// <summary>
        /// 返回值类型
        /// </summary>
        public string ReturnValueType { get; set; }
    }
}
