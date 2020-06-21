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
    public partial class frmQuickReply : Form
    {
        public frmQuickReply()
        {
            InitializeComponent();
        }

        public frmQuickReply(FormMain frmMain)
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
            InitializeComponent();
        }

        private void SpeechBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show("请先输入要查找的内容!");
                return;
            }
            DataCenter.PointDatas.Clear();
            classList.Items.Clear();
            foreach (var replyData in DataCenter.ReplyDatas)
            {
                if (replyData.classify == "话术")
                {
                    if (inputText.Text.Contains(replyData.questionClass))
                    {
                        if (classList.FindStringExact(replyData.questionClass) == ListBox.NoMatches)
                        {
                            classList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(replyData.questionClass));
                        }
                        DataCenter.PointDatas.Add(replyData);
                    }
                }
            }
            if(classList.Items.Count == 0)
                MessageBox.Show("没有找到对应的问题记录");
        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplyData result = new ReplyData();
            subList.Items.Clear();
            resultText.Text = "";
            subList.Items.Add(new CCWin.SkinControl.SkinListBoxItem("  "));
            DataCenter.ResultDatas.Clear();
            foreach (var replyData in DataCenter.PointDatas)
            {
                if (replyData.questionClass == Convert.ToString(classList.SelectedItem))                {
                    DataCenter.ResultDatas.Add(replyData);
                    if (!string.IsNullOrEmpty(replyData.questionSub))     
                        subList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(replyData.questionSub));
                }
            }
        }

        private void SubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultTempList.Items.Clear();
            if (subList.SelectedIndex == 0)
            {               
                foreach (var data in DataCenter.ResultDatas)
                {
                    if(string.IsNullOrEmpty(data.questionSub))
                        resultTempList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.answer));
                }
                return;
            }

            foreach (var data in DataCenter.ResultDatas)
            {
                if (subList.SelectedItem.ToString() == data.questionSub)
                {
                    resultTempList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.answer));
                }
            }
        }

        private void ResultTempList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var point in DataCenter.ResultDatas)
            {
                if (point.answer == Convert.ToString(resultTempList.SelectedItem))
                {
                    resultText.Text = point.answer;
                }
            }
        }

        private void ToyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show("请先输入要查找的内容!");
                return;
            }
            DataCenter.PointDatas.Clear();
            classList.Items.Clear();
            foreach (var replyData in DataCenter.ReplyDatas)
            {
                if (replyData.classify == "玩具问题")
                {
                    if (inputText.Text.Contains(replyData.questionClass))
                    {
                        if (classList.FindStringExact(replyData.questionClass) == ListBox.NoMatches)
                        {
                            classList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(replyData.questionClass));
                        }
                        DataCenter.PointDatas.Add(replyData);
                    }
                }
            }
            if (classList.Items.Count == 0)
                MessageBox.Show("没有找到对应的问题记录");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        //我先催件再拦截，然后要补发再退货买个旋风轮
    }
}
