using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitExcelSetting();
        }

        Dictionary<string, string> replyDic = new Dictionary<string, string>();

        List<String> blackList = new List<string>();

        public string lastKeyWords;
        private void InitExcelSetting()
        {
            var tableName = "Sheet1";
            var fileName = "数据表.xlsx";
            var filePath = System.IO.Directory.GetCurrentDirectory() + "/" + fileName;
            var dataTbl = InputFromExcel(filePath, tableName);
            for (int i = 0; i < dataTbl.Rows.Count; i++)
            {
                replyDic.Add(dataTbl.Rows[i][0].ToString(), dataTbl.Rows[i][1].ToString());
            }
        }

        #region 获取Excel数据表
        /// <summary>
        /// 获取Excel文件数据表列表
        /// </summary>
        private static ArrayList GetExcelTables(string ExcelFileName)
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
        private static DataTable InputFromExcel(string ExcelFilePath, string TableName)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keywordsText.Text))
            {
                MessageBox.Show("请先输入要查找的内容!");
                return;
            }
            blackList.Clear();
            findNextBtn.Enabled = true;
            foreach (var data in replyDic)
            {
                if (keywordsText.Text.Contains(data.Key))
                {
                    replyText.Text = data.Value;
                    Clipboard.SetDataObject(data.Value, true);
                    lastKeyWords = data.Key;
                    findNextBtn.Visible = true;
                    return;
                }
            }
            MessageBox.Show("没有找到对应的回复");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            blackList.Add(lastKeyWords);
            bool isBlackWord = false;
            foreach (var data in replyDic)
            {
                if (keywordsText.Text.Contains(data.Key))
                {
                    foreach (var word in blackList)
                    {
                        if (data.Key == word)
                        {
                            isBlackWord = true;
                            break;
                        }
                    }
                    if (isBlackWord)
                    {
                        isBlackWord = false;
                        continue;
                    }
                    replyText.Text = data.Value;
                    Clipboard.SetDataObject(data.Value, true);
                    lastKeyWords = data.Key;
                   // findNextBtn.Visible = true;
                    return;
                }
            }
            MessageBox.Show("没有找到对应的回复");
        }
    }
}
