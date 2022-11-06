using System.Collections.Generic;

namespace KitX.Web.Rules
{
    /// <summary>
    /// 功能体
    /// </summary>
    public class Function
    {
        /// <summary>
        /// 功能显示名称列表
        /// </summary>
        public Dictionary<string, string> DisplayNames { get; set; }

        /// <summary>
        /// 参数列表, Value 为参数类型
        /// </summary>
        public Dictionary<Dictionary<string, string>, string> Parameters { get; set; }

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
