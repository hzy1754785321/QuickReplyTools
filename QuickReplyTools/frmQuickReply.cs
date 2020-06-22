using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                MessageBox.Show(Common.FIRSTINPUTQUESTION);
                return;
            }
            DataCenter.PointDatas.Clear();
            ClearList();
            foreach (var replyData in DataCenter.ReplyDatas)
            {
                if (replyData.classify == Common.SPEECHCRAFT)
                {
                    if (inputText.Text.Contains(replyData.questionClass))
                    {
                        if (classList.FindStringExact(replyData.questionClass) == ListBox.NoMatches)
                        {
                            classSearchCombo.Items.Add(replyData.questionClass);
                            if (!string.IsNullOrEmpty(replyData.pictureName))
                                classList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(Common.CLASSOFFSET + replyData.questionClass, DataCenter.CreateShowImage(replyData.pictureName)));
                            else
                                classList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(Common.CLASSOFFSET + replyData.questionClass));
                        }
                        DataCenter.PointDatas.Add(replyData);
                    }
                }
            }
            if(classList.Items.Count == 0)
                MessageBox.Show(Common.NOTFINDQUESTION);
        }

      

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplyData result = new ReplyData();
            subList.Items.Clear();
            resultText.Text = "";
            subList.Items.Add(new CCWin.SkinControl.SkinListBoxItem("  "));
            DataCenter.ResultDatas.Clear();
            subSearchCombo.Items.Clear();
            foreach (var replyData in DataCenter.PointDatas)
            {
                if (replyData.questionClass == Convert.ToString(classList.SelectedItem).Trim())                {
                    DataCenter.ResultDatas.Add(replyData);
                    if (!string.IsNullOrEmpty(replyData.questionSub))
                    {
                        subSearchCombo.Items.Add(replyData.questionSub);
                        subList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(replyData.questionSub));
                    }
                }
            }
        }

        private void SubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultTempList.Items.Clear();
            resultCombo.Items.Clear();
            if (subList.SelectedIndex == 0)
            {               
                foreach (var data in DataCenter.ResultDatas)
                {
                    if (string.IsNullOrEmpty(data.questionSub))
                    {
                        resultCombo.Items.Add(data.answer);
                        resultTempList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.answer));
                    }
                }
                return;
            }

            foreach (var data in DataCenter.ResultDatas)
            {
                if (subList.SelectedItem.ToString() == data.questionSub)
                {
                    resultCombo.Items.Add(data.answer);
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
                MessageBox.Show(Common.FIRSTINPUTQUESTION);
                return;
            }
            DataCenter.PointDatas.Clear();
            ClearList();
            foreach (var replyData in DataCenter.ReplyDatas)
            {
                if (replyData.classify == Common.TOYPROBLEM)
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
                MessageBox.Show(Common.NOTFINDQUESTION);
        }

        private void ResultTempList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetDataObject(Convert.ToString(resultTempList.SelectedItem));
            show1 = new ShowCopy(ShowText);
            IAsyncResult ar = show1.BeginInvoke(null, null);
        }

        public void ClearList()
        {
            classList.Items.Clear();
            classSearchCombo.Items.Clear();
            subList.Items.Clear();
            subSearchCombo.Items.Clear();
            resultTempList.Items.Clear();
            resultCombo.Items.Clear();
            resultText.Text = "";
        }

        private void ResultText_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(resultText.Text);
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
            int index = classList.FindStringExact(Common.CLASSOFFSET + Convert.ToString(classSearchCombo.SelectedItem));
            classList.SelectedIndex = index;
        }

        private void SubSearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = subList.FindStringExact(Convert.ToString(subSearchCombo.SelectedItem));
            subList.SelectedIndex = index;
        }

        private void ResultCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = resultTempList.FindStringExact(Convert.ToString(resultCombo.SelectedItem));
            resultTempList.SelectedIndex = index;
        }

        //我先催件再拦截，然后要补发再退货买个旋风轮
    }
}
