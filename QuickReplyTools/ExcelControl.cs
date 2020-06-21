using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReplyTools
{
    public static class ExcelControl
    {
        #region 获取Excel数据表
        /// <summary>
        /// 获取Excel文件数据表列表
        /// </summary>
        public static ArrayList GetExcelTables(string ExcelFileName)
        {
            DataTable dt = new DataTable();
            ArrayList TablesList = new ArrayList();
            if (File.Exists(ExcelFileName))
            {
                if (Path.GetExtension(ExcelFileName) == ".xlsx")
                {
                    using (OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;;Data Source=" + ExcelFileName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';"))
                    {
                        try
                        {
                            conn.Open();
                            dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                        }
                        catch (Exception exp)
                        {
                            throw exp;
                        }
                        int tablecount = dt.Rows.Count;
                        for (int i = 0; i < tablecount; i++)
                        {
                            string tablename = dt.Rows[i][2].ToString().Trim().TrimEnd('$');
                            if (TablesList.IndexOf(tablename) < 0)
                            {
                                TablesList.Add(tablename);
                            }
                        }
                    }
                }
                else
                {
                    using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + ExcelFileName))
                    {
                        try
                        {
                            conn.Open();
                            dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                        }
                        catch (Exception exp)
                        {
                            throw exp;
                        }

                        int tablecount = dt.Rows.Count;
                        for (int i = 0; i < tablecount; i++)
                        {
                            string tablename = dt.Rows[i][2].ToString().Trim().TrimEnd('$');
                            if (TablesList.IndexOf(tablename) < 0)
                            {
                                TablesList.Add(tablename);
                            }
                        }
                    }
                }
            }
            return TablesList;
        }
        #endregion 获取Excel数据表

        #region Excel导出
        /// <summary>
        /// 将Excel文件导出至DataTable(第一行作为表头)
        /// </summary>
        /// <param name="ExcelFilePath">Excel文件路径</param>
        /// <param name="TableName">数据表名，如果数据表名错误，默认为第一个数据表名</param>
        public static DataTable InputFromExcel(string ExcelFilePath, string TableName)
        {
            ArrayList TableList = new ArrayList();
            TableList = GetExcelTables(ExcelFilePath);
            if (TableName.IndexOf(TableName) < 0)
            {
                TableName = TableList[0].ToString().Trim();
            }

            DataTable table = new DataTable();
            OleDbConnection dbcon;
            if (Path.GetExtension(ExcelFilePath) == ".xlsx")
            {
                dbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFilePath + "; Extended Properties = 'Excel 12.0;IMEX=1;HDR=Yes;ImportMixedTypes=Text'");
            }
            else
            {
                dbcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 8.0;");
            }
            OleDbCommand cmd = new OleDbCommand("select * from [" + TableName + "$]", dbcon);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            try
            {
                if (dbcon.State == ConnectionState.Closed)
                {
                    dbcon.Open();
                }
                adapter.Fill(table);
            }
            catch (Exception exp)
            {
                throw exp;
            }
            finally
            {
                if (dbcon.State == ConnectionState.Open)
                {
                    dbcon.Close();
                }
            }
            return table;
        }
        #endregion Excel导出

    }
}
