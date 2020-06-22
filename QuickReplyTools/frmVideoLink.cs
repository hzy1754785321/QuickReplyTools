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
    public partial class frmVideoLink : Form
    {
        public frmVideoLink()
        {
            InitializeComponent();
            InitData();
        }

        public frmVideoLink(FormMain frmMain)
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            classList.Items.Clear();
            foreach (var data in DataCenter.VedioDatas)
            {
                classList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.classify));
            }
        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoList.Items.Clear();
            classSearchCombo.Items.Clear();
            foreach (var data in DataCenter.VedioDatas)
            {
                if (data.classify == Convert.ToString(classList.SelectedItem).Trim())
                {
                    classSearchCombo.Items.Add(data.vedioLink);
                    videoList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.vedioLink));
                }
            }
        }

        private void VideoList_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Convert.ToString(videoList.SelectedItem));
            show1 = new ShowCopy(ShowText);
            IAsyncResult ar = show1.BeginInvoke(null, null);
        }

        internal delegate void ShowCopy();
        ShowCopy show1;

        public void ShowText()
        {
            this.Invoke(new EventHandler(delegate
            {
                label1.Visible = true;
            }));

            System.Threading.Thread.Sleep(1000);
            this.Invoke(new EventHandler(delegate
            {
                label1.Visible = false;
            }));
        }

        private void ClassSearchCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = classList.FindStringExact(Convert.ToString(classSearchCombo.SelectedItem));
            classList.SelectedIndex = index;
        }
    }
}
