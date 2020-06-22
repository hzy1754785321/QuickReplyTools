using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace QuickReplyTools
{
    public class DataCenter
    {
        public static List<ReplyData> ReplyDatas { get; set; } = new List<ReplyData>();

        public static List<ReplyData> PointDatas { get; set; } = new List<ReplyData>();

        public static List<ReplyData> ResultDatas { get; set; } = new List<ReplyData>();

        public static List<VideoData> VedioDatas { get; set; } = new List<VideoData>();

        public static void ReadExcelData()
        {
            var filePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.EXCELFOLDER + @"\" + Common.EXCELFILENAME;
            DataTable excelData = ExcelControl.InputFromExcel(filePath, Common.QUICKREPLYSHEET);
            InitData(excelData);
            DataTable excelData2 = ExcelControl.InputFromExcel(filePath, Common.VIDEOLINKSHEET);
            InitVedioData(excelData2);
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

        public static void InitVedioData(DataTable dataSources)
        {
            for (int i = 0; i < dataSources.Rows.Count; i++)
            {
                VideoData data = new VideoData();
                data.classify = Convert.ToString(dataSources.Rows[i][0]);
                data.vedioLink = Convert.ToString(dataSources.Rows[i][1]);
                VedioDatas.Add(data);
            }
        }
        public static Image CreateShowImage(string imageName)
        {
            var imagePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.PICTUREFOLDER + @"\" + imageName;
            Image imageSource = Image.FromFile(imagePath);
            Bitmap bitmap = new Bitmap(imageSource);
            return resizeImage(bitmap, new Size(Common.PICTURESIZE, Common.PICTURESIZE));
        }

        private static Image resizeImage(Image imgToResize, Size size)
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
}
