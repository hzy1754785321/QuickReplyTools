using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuickReplyTools
{
    public class DataCenter
    {
        public static List<ReplyData> ReplyDatas { get; set; } = new List<ReplyData>();

        public static List<ReplyData> PointDatas { get; set; } = new List<ReplyData>();

        public static List<ReplyData> ResultDatas { get; set; } = new List<ReplyData>();

        public static void ReadExcelData()
        {
            var filePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.EXCELFOLDER + @"\" + Common.EXCELFILENAME;
            DataTable excelData = ExcelControl.InputFromExcel(filePath, Common.QUICKREPLYSHEET);
            InitData(excelData);
        }

        public static void InitData(DataTable dataSources)
        {
            for (int i = 0; i < dataSources.Rows.Count; i++)
            {
                ReplyData data = new ReplyData();
                data.classify = Convert.ToString(dataSources.Rows[i][0]);
                data.pictureName = Convert.ToString(dataSources.Rows[i][1]);
                data.questionClass = Convert.ToString(dataSources.Rows[i][2]);
                data.questionSub = Convert.ToString(dataSources.Rows[i][3]);
                data.answer = Convert.ToString(dataSources.Rows[i][4]);
                ReplyDatas.Add(data);
            }
        }
    }
}
