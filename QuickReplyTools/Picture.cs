using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickReplyTools
{
    public partial class Picture : Form
    {
        public Picture(string picPath)
        {
            InitializeComponent();
            InitPicture(picPath);
        }

        public void InitPicture(string picPath)
       {
            try
            {
                Image imageSource = Image.FromFile(picPath);
                Bitmap bitmap = new Bitmap(imageSource);
                showPicture.Image = Common.resizeImage(bitmap, new Size(Common.PICTURESOURCESIZE, Common.PICTURESOURCESIZE));
            }
            catch  {}
        }

    }
}
