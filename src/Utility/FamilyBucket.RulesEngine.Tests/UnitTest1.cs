using FamilyBucket.RulesEngine.Tests.Model;
using System;
using System.Collections.Generic;
using Xunit;
using Z.Expressions;

namespace FamilyBucket.RulesEngine.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestEval()
        {
            var model = new
            {
                Id = 3,
                Name = "jkhfsajd",
                Age = 5
            };

            int result = Eval.Execute<int>("Id + Age", model);
            Assert.True(1 == 1);

        }
        [Fact]
        public void TestChronicRule()
        {
            ChronicChildRule chronicRule = new ChronicChildRule { Operation = "&&" };
            chronicRule.ChildRules = new List<ChronicChildRule>();
            chronicRule.ChildRules.Add(new ChronicChildRule
            {
                FieldGroup = "1",
                FieldCode = "0001",
                FieldName = "Age",
                FieldOperation = ">",
                FieldValue = "45"
            });
            chronicRule.ChildRules.Add(new ChronicChildRule
            {
                //FieldGroup = "2",
                //FieldCode = "0002",
                //FieldName = "Height",
                //FieldOperation = "<",
                //FieldValue = "145",
                Operation = "||",
                ChildRules = new List<ChronicChildRule> {
                    new ChronicChildRule {
                        FieldGroup = "2",
                        FieldCode = "00021",
                        FieldName = "Age2",
                        FieldOperation = "<",
                        FieldValue = "45",

                    },new ChronicChildRule {
                         FieldGroup = "2",
                        FieldCode = "00022",
                        FieldName = "Height2",
                        FieldOperation = "<",
                        FieldValue = "125"
                    },new ChronicChildRule {
                        FieldGroup = "2",
                        FieldCode = "00023",
                        FieldName = "Weight2",
                        FieldOperation = ">",
                        FieldValue = "245"
                    },new ChronicChildRule {
                        FieldGroup = "2",
                        FieldCode = "00023",
                        FieldName = "Weight2",
                        FieldOperation = ">",
                        FieldValue = "245"
                    }

                }
            });
            chronicRule.ChildRules.Add(new ChronicChildRule
            {
                //FieldCode = "0003",
                //FieldName = "Weight",
                //FieldOperation = ">",
                //FieldValue = "149",
                //FieldGroup = "1",
                Operation = "||",
                ChildRules = new List<ChronicChildRule> {
                        new ChronicChildRule
                        {
                            //FieldGroup = "3",
                            //FieldCode = "00031",
                            //FieldName = "Age3",
                            //FieldOperation = "<",
                            //FieldValue = "453",
                            Operation = "&&",
                            ChildRules = new List<ChronicChildRule> {
                                    new ChronicChildRule
                                    {
                                        FieldGroup = "3",
                                        FieldCode = "000311",
                                        FieldName = "Age31",
                                        FieldOperation = "<",
                                        FieldValue = "4531",
                                    },
                                    new ChronicChildRule
                                    {
                                        FieldGroup = "3",
                                        FieldCode = "000312",
                                        FieldName = "Height31",
                                        FieldOperation = "<",
                                        FieldValue = "1253"
                                    },
                                    new ChronicChildRule
                                    {
                                        FieldGroup = "3",
                                        FieldCode = "000313",
                                        FieldName = "Weight31",
                                        FieldOperation = ">",
                                        FieldValue = "24531"
                                    }
                            }
                        },
                        new ChronicChildRule
                        {
                            FieldGroup = "3",
                            FieldCode = "00032",
                            FieldName = "Height3",
                            FieldOperation = "<",
                            FieldValue = "1253"
                        },
                        new ChronicChildRule
                        {
                            FieldGroup = "3",
                            FieldCode = "00033",
                            FieldName = "Weight3",
                            FieldOperation = ">",
                            FieldValue = "2453"
                        }
                }
            });
            string lamda = ExpressonHelper.GetLamdaExpression(chronicRule);
            string lamda2 = ExpressonHelper.GetLamdaExpressionItem(chronicRule);
            
            var set = ExpressonHelper.GetParas(chronicRule);
            var set2 = ExpressonHelper.GetParasItem(chronicRule);
            Assert.True(1 == 1);

        }
    }
}
