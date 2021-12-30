using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bucket.Utility.Test
{
    class ExcelHelper
    {
        
        public static List<string> ReadFromExcelFile(string filePath)
        {
            List<string> result = new List<string>();
            IWorkbook wk = null;
            string extension = System.IO.Path.GetExtension(filePath);
            try
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    if (extension.Equals(".xls"))
                    {
                        //把xls文件中的数据写入wk中
                        wk = WorkbookFactory.Create(fs);//new HSSFWorkbook(fs);
                    }
                    else
                    {
                        //把xlsx文件中的数据写入wk中
                        wk = WorkbookFactory.Create(fs);//new XSSFWorkbook(fs);
                    }
                }
                //读取当前表数据
                ISheet sheet = wk.GetSheetAt(0);
                IRow row = sheet.GetRow(0); //读取当前行数据 
                int offset = 0;
                int lastRowNum = sheet.LastRowNum;//LastRowNum 是当前表的总行数-1（注意）
                for (int i = 1; i <= lastRowNum; i++)
                {
                    row = sheet.GetRow(i); //读取当前行数据
                    if (row != null)
                    {
                        int lastCellNum = row.LastCellNum;
                        //LastCellNum 是当前行的总列数
                        for (int j = 1; j < lastCellNum; j++)
                        {
                            //读取该行的第j列数据
                            string value = row.GetCell(j).ToString();
                            StringBuilder mainBuilder = new StringBuilder();
                            value.Split("、").ToList().ForEach(a =>
                            {
                                StringBuilder subBuilder = new StringBuilder();
                                a.Split(".").ToList().ForEach(b =>
                                {
                                    if (b.Contains("/"))
                                    {
                                        subBuilder.Append(int.Parse(b.Split("/")[0]).ToString("X2")).Append("/").Append(b.Split("/")[1]);
                                    }
                                    else
                                    {
                                        subBuilder.Append(int.Parse(b).ToString("X2"));
                                    }
                                    subBuilder.Append(".");
                                });
                                mainBuilder.Append(subBuilder.ToString().TrimEnd('.')).Append('、');
                            });
                            result.Add(mainBuilder.ToString().TrimEnd('、'));
                            Console.Write(value.ToString() + " ");
                        }
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (Exception e)
            {
                //只在Debug模式下才输出
                Console.WriteLine(e.Message);
            }
            return result;
        }
        public static void WriteToExcel(string filePath, List<string> data)
        {
            if (File.Exists(filePath))
            {
                File.Create(filePath);
            }
            using (Stream fileStream = File.OpenWrite(filePath))
            {
                IWorkbook wb = new XSSFWorkbook();//如果生成xls则是HSSFWorkbook
                ISheet sheet = wb.CreateSheet();
                
                for (int i = 0; i < data.Count; i++)
                {
                    IRow row = sheet.CreateRow(i);//0行号
                    row.CreateCell(0).SetCellValue(data[i]);
                }
                
                wb.Write(fileStream);
            }

        }
    }
}