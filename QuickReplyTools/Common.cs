using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReplyTools
{
    public static class Common
    {
        public readonly static string EXCELFOLDER = "excel";
        public readonly static string EXCELFILENAME = "数据表.xlsx";
        public readonly static string QUICKREPLYSHEET = "Sheet1";
        public readonly static string VIDEOLINKSHEET = "Sheet2";


    }

    public partial class ReplyData
    {
        public string classify;
        public string pictureName;
        public string questionClass;
        public string questionSub;
        public string answer;
    }
}
