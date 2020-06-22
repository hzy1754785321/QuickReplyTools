using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReplyTools
{
    public static class Common
    {
        public readonly static string EXCELFOLDER = "excel";  //数据表文件夹名
        public readonly static string EXCELFILENAME = "数据表.xlsx"; //数据表文件名
        public readonly static string QUICKREPLYSHEET = "Sheet1";  
        public readonly static string VIDEOLINKSHEET = "Sheet2";
        public readonly static string PICTUREFOLDER = "picture";
        public readonly static string CLASSOFFSET = "  ";  //偏移量
        public readonly static string FIRSTINPUTQUESTION = "请先输入要查找的内容!";
        public readonly static string NOTFINDQUESTION = "没有找到对应的问题记录";
        public readonly static string SPEECHCRAFT = "话术";
        public readonly static string TOYPROBLEM = "玩具问题";
        public readonly static int PICTURESIZE = 50;

    }

    public partial class ReplyData
    {
        public string classify;
        public string pictureName;
        public string questionClass;
        public string questionSub;
        public string answer;
    }

    public partial class VideoData
    {
        public string classify;
        public string vedioLink;
    }
}
