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
        //       private bool m_tpgQuickReply = false;

        public FormSizeSet fsSet = new FormSizeSet();

        public FormMain()
        {
            InitializeComponent();
            DataCenter.ReadExcelData();
            tabControl1.SelectedIndex = 0;
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
            fsSet.form_Resize(this);
            //      m_tpgQuickReply = true;
        }

        private void TpgVideoLink_Enter(object sender, EventArgs e)
        {
            frmVedioLink = new frmVideoLink(this);
            tpgVideoLink.Controls.Clear();
            tpgVideoLink.Controls.Add(frmVedioLink);
            fsSet.form_Resize(this);
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
   //         this.Resize += new EventHandler(FormMain_Resize);
            fsSet._x = this.Width;
            fsSet._y = this.Height;
            fsSet.setTag(this);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            fsSet.form_Resize(this);
          //  tpgQuickReply.Font.
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsSet.form_Resize(this);
        }

    }
}
