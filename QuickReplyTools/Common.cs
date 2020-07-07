using System;
using System.Collections.Generic;
using System.Drawing;
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
        public readonly static int PICTURESOURCESIZE = 400;
        public readonly static string BACKGROUNDIMAGENAME = "background.png";
        public readonly static string DEFAULTTEXT = "请在这里输入你的问题.";
        public readonly static string DEFAULTRESULTTEXT = "请里是你的输出结果.";

        public static Image resizeImage(Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (Image)b;
        }
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
        public string videoLink;
    }

}
