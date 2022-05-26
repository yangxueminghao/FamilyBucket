using FamilyBucket.RulesEngine.Tests.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBucket.RulesEngine.Tests
{
    public class ExpressonHelper
    {
        public static string GetLamdaExpression(ChronicRule chronicRule)
        {
            StringBuilder sb = new StringBuilder();
            if (chronicRule == null || chronicRule.ChildRules == null || chronicRule.ChildRules.Count < 2)
            {
                return sb.ToString();
            }
            else
            {
                for (int i = 0; i < chronicRule.ChildRules.Count; i++)
                {
                    if (chronicRule.ChildRules[i] != null)
                    {
                        if (i == 0)
                        {
                            sb.Append($"({GetLamdaExpressionItem(chronicRule.ChildRules[i])})");
                        }
                        else
                        {
                            sb.Append($" {chronicRule.Operation} ({GetLamdaExpressionItem(chronicRule.ChildRules[i])})");
                        }
                    }
                }
                return sb.ToString();
            }
        }

        private static string GetLamdaExpressionItem(ChronicChildRule chronicChildRule)
        {
            StringBuilder sb = new StringBuilder();
            if (chronicChildRule == null)
            {
                return sb.ToString();
            }
            else if (chronicChildRule.ChildRules == null || chronicChildRule.ChildRules.Count < 2)
            {
                return $"{chronicChildRule.FieldName}{chronicChildRule.FieldOperation}{chronicChildRule.FieldValue}";
            }
            else
            {
                for (int i = 0; i < chronicChildRule.ChildRules.Count; i++)
                {
                    if (i == 0)
                    {
                        sb.Append($"({GetLamdaExpressionItem(chronicChildRule.ChildRules[i])})");
                    }
                    else
                    {
                        sb.Append($" {chronicChildRule.Operation} ({GetLamdaExpressionItem(chronicChildRule.ChildRules[i])})");
                    }
                }
                return sb.ToString();
            }
        }

        public static HashSet<string> GetParas(ChronicRule chronicRule)
        {
            HashSet<string> hash = new HashSet<string>();
            if (chronicRule == null || chronicRule.ChildRules == null || chronicRule.ChildRules.Count < 2)
            {
                return hash;
            }
            else
            {
                for (int i = 0; i < chronicRule.ChildRules.Count; i++)
                {
                    if (chronicRule.ChildRules[i] != null)
                    {
                        hash.UnionWith(GetParasItem(chronicRule.ChildRules[i]));
                    }
                    
                }
                return hash;
            }
        }

        private static HashSet<string> GetParasItem(ChronicChildRule chronicChildRule)
        {
            HashSet<string> hash = new HashSet<string>();
            if (chronicChildRule == null)
            {
                return hash;
            }
            hash.Add(chronicChildRule.FieldName);
            if (chronicChildRule.ChildRules == null || chronicChildRule.ChildRules.Count < 2)
            {
                return hash;
            }
            else
            {
                for (int i = 0; i < chronicChildRule.ChildRules.Count; i++)
                {
                    hash.UnionWith(GetParasItem(chronicChildRule.ChildRules[i]));
                }
                return hash;
            }
        }
    }
}
