using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucket.RulesEngine.Tests.Model
{
    /// <summary>
    /// 慢病策略规则
    /// </summary>
    public class ChronicRule
    {
        /// <summary>
        /// 操作符
        /// </summary>
        public string Operation { get; set; }
        /// <summary>
        /// 子规则
        /// </summary>
        public List<ChronicChildRule> ChildRules { get; set; }
    }
}
