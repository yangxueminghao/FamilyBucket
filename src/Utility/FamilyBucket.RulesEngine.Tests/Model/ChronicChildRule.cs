using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucket.RulesEngine.Tests.Model
{
    /// <summary>
    /// 子规则
    /// </summary>
    public class ChronicChildRule : ChronicRule
    {
        /// <summary>
        /// 字段组
        /// </summary>
        public string FieldGroup { get; set; }
        /// <summary>
        /// 字段编码
        /// </summary>
        public string FieldCode { get; set; }
        /// <summary>
        /// 字段名字
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// FieldCode关联的Id
        /// </summary>
        public long RelationId { get; set; }
        /// <summary>
        /// 操作符
        /// </summary>
        public string FieldOperation { get; set; }
        /// <summary>
        /// 字段值
        /// </summary>
        public string FieldValue { get; set; }
        /// <summary>
        /// 字段显示值
        /// </summary>
        public string FieldDisplayValue { get; set; }
    }
}
