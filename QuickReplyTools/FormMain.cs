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

namespace QuickReplyTools
{
    public partial class FormMain : Form
    {
        private frmQuickReply frmQuickReply;
        private frmVideoLink frmVedioLink;
        private bool m_tpgQuickReply = false;

        public FormMain()
        {
            InitializeComponent();
            DataCenter.ReadExcelData();
        }

        Dictionary<string, string> replyDic = new Dictionary<string, string>();

        List<String> blackList = new List<string>();

        public string lastKeyWords;
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush _Brush = new SolidBrush(Color.Black);//单色画刷
            RectangleF _TabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);//绘制区域
            StringFormat _sf = new StringFormat();//封装文本布局格式信息
            _sf.LineAlignment = StringAlignment.Center;
            _sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);
        }

        private void TpgQuickReply_Enter(object sender, EventArgs e)
        {
            frmQuickReply = new frmQuickReply(this);   
            tpgQuickReply.Controls.Clear();
            tpgQuickReply.Controls.Add(frmQuickReply);
            m_tpgQuickReply = true;
        }

        private void TpgVideoLink_Enter(object sender, EventArgs e)
        {
            frmVedioLink = new frmVideoLink(this);
            tpgVideoLink.Controls.Clear();
            tpgVideoLink.Controls.Add(frmVedioLink);
        }
    }
}
