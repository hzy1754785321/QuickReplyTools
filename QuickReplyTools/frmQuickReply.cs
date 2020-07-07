using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickReplyTools
{
    public partial class frmQuickReply : Form
    {
        public static FormMain formMain;

        public static string classifyNow;


      //  FormSizeSet fsSet = new FormSizeSet();
        public frmQuickReply()
        {
            InitializeComponent();
        }

        public frmQuickReply(FormMain frmMain)
        {
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.Visible = true;
            formMain = frmMain;
            InitializeComponent();
            SizeInfoInit();
            InitClassifyList(Common.SPEECHCRAFT);
            classifyNow = Common.SPEECHCRAFT;
            SetButtonIcon();
            SetDefaultText();
            SetDefaultResultText();
            var imagePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.BACKGROUNDIMAGENAME;
            try
            {
                this.BackgroundImage = Image.FromFile(imagePath);
            }
            catch
            { }
        }

        private void SetDefaultText()
        {
            inputText.Text = Common.DEFAULTTEXT;
            inputText.ForeColor = Color.Gray;
        }

        private void SetDefaultResultText()
        {
            resultText.Text = Common.DEFAULTRESULTTEXT;
            resultText.ForeColor = Color.Gray;
        }

        private void SpeechBtn_Click(object sender, EventArgs e)
        {
            if (inputText.Text == Common.DEFAULTTEXT)
            {
                InitClassifyList(Common.SPEECHCRAFT);
                classifyNow = Common.SPEECHCRAFT;
            }
            else
            {
                FindClassify(Common.SPEECHCRAFT);
                classifyNow = Common.SPEECHCRAFT;
            }
        }
        private void ToyBtn_Click(object sender, EventArgs e)
        {
            if (inputText.Text == Common.DEFAULTTEXT)
            {
                InitClassifyList(Common.TOYPROBLEM);
                classifyNow = Common.TOYPROBLEM;
            }
            else
            {
                FindClassify(Common.TOYPROBLEM);
                classifyNow = Common.TOYPROBLEM;
            }
        }

        private void FindClassify(string classify)
        {
            if (inputText.Text == Common.DEFAULTTEXT)
            {
                MessageBox.Show(Common.FIRSTINPUTQUESTION);
                return;
            }
            try
            {
                DataCenter.PointDatas.Clear();
                ClearList();
                foreach (var replyData in DataCenter.ReplyDatas)
                {
                    if (replyData.classify == classify)
                    {
                        if (inputText.Text.Contains(replyData.questionClass))
                        {
                            if (classList.FindStringExact(Common.CLASSOFFSET + replyData.questionClass) == ListBox.NoMatches)
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
                if (classList.Items.Count == 0)
                    MessageBox.Show(Common.NOTFINDQUESTION);
            }
            catch { };
        }

        private void InitClassifyList(string classify)
        {
            try
            {
                DataCenter.PointDatas.Clear();
                ClearList();
                foreach (var replyData in DataCenter.ReplyDatas)
                {
                    if (replyData.classify == classify)
                    {
                        if (classList.FindStringExact(Common.CLASSOFFSET + replyData.questionClass) == ListBox.NoMatches)
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
            catch { };
        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ReplyData result = new ReplyData();
                subList.Items.Clear();
                resultText.Text = "";
                subList.Items.Add(new CCWin.SkinControl.SkinListBoxItem("  "));
                DataCenter.ResultDatas.Clear();
                subSearchCombo.Items.Clear();
                foreach (var replyData in DataCenter.PointDatas)
                {
                    if (replyData.questionClass == Convert.ToString(classList.SelectedItem).Trim())
                    {
                        DataCenter.ResultDatas.Add(replyData);
                        if (!string.IsNullOrEmpty(replyData.questionSub))
                        {
                            if (subList.FindStringExact(replyData.questionSub) == ListBox.NoMatches)
                            {
                                subSearchCombo.Items.Add(replyData.questionSub);
                                subList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(replyData.questionSub));
                            }
                        }
                    }
                }
            }
            catch { };
        }

        private void SubList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                resultTempList.Items.Clear();
                resultCombo.Items.Clear();
                if (subList.SelectedIndex == 0)
                {
                    foreach (var data in DataCenter.ResultDatas)
                    {
                        if (string.IsNullOrEmpty(data.questionSub))
                        {
                            if (resultTempList.FindStringExact(data.answer) == ListBox.NoMatches)
                            {
                                resultCombo.Items.Add(data.answer);
                                resultTempList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.answer));
                            }
                        }
                    }
                    return;
                }

                foreach (var data in DataCenter.ResultDatas)
                {
                    if (Convert.ToString(subList.SelectedItem) == data.questionSub)
                    {
                        resultCombo.Items.Add(data.answer);
                        resultTempList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.answer));
                    }
                }
            }
            catch { };
        }

        private void ResultTempList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var point in DataCenter.ResultDatas)
                {
                    if (point.answer == Convert.ToString(resultTempList.SelectedItem))
                    {
                        resultText.ForeColor = Color.Black;
                        resultText.Text = point.answer;
                    }
                }
            }
            catch { };
        }

        private void ResultTempList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(Convert.ToString(resultTempList.SelectedItem));
                show1 = new ShowCopy(ShowText);
                IAsyncResult ar = show1.BeginInvoke(null, null);
            }
            catch { };
        }

        public void ClearList()
        {
            classList.Items.Clear();
            classSearchCombo.Items.Clear();
            subList.Items.Clear();
            subSearchCombo.Items.Clear();
            resultTempList.Items.Clear();
            resultCombo.Items.Clear();
            SetDefaultResultText();
        }

        private void ResultText_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(resultText.Text);
                show1 = new ShowCopy(ShowText);
                IAsyncResult ar = show1.BeginInvoke(null, null);
            }
            catch { };
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

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            if (formMain.TopMost == false)
            {
                formMain.TopMost = true;
                skinButton1.Image = Properties.Resources.AvatarCardPic1;
            }
            else
            {
                formMain.TopMost = false;
                skinButton1.Image = Properties.Resources.AvatarCardPic;
            }
        }

        private void ClassList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = classList.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    var imagePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.PICTUREFOLDER + @"\" + GetImageName(Convert.ToString(Convert.ToString(classList.SelectedItem).Trim()));
                    var pic = new Picture(imagePath);
                    pic.Show();
                }
                else
                {
                    classList.SelectedIndex = -1;
                }
            }
            catch { };
        }

        private string GetImageName(string questionClass)
        {
            try
            {
                foreach (var replyData in DataCenter.ReplyDatas)
                {
                    if (replyData.questionClass == questionClass)
                        return replyData.pictureName;
                }
                return null;
            }
            catch { return null; };
        }


        public void SetButtonIcon()
        {
            try
            {
                //var picPath = ;
                //Image imageSource = Image.FromFile(Properties.Resources.background);
                Bitmap bitmap = new Bitmap(Properties.Resources.background);
                //  backgroundBtn.BackgroundImage = Common.resizeImage(bitmap, new Size(45, 45));
            }
            catch { };
        }

        public byte[] CreateIamge(string str)
        {
            try
            {
                //创建位图(width.height)
                Bitmap image = new Bitmap((int)Math.Ceiling(str.Length * 12.0), 22);

                Graphics g = Graphics.FromImage(image);
                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] buffer = stream.ToArray();
                g.Dispose();
                image.Dispose();
                return buffer;
            }
            catch { return null; };
        }

        private void BackgroundBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog objFileDialog = new OpenFileDialog();
                objFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.gif,*.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png;*.gif;*bmp";
                objFileDialog.RestoreDirectory = false;
                DialogResult result = objFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    BackgroundImage.Dispose();
                    BackgroundImage.Dispose();
                    BackgroundImage.Dispose();
                    var imagePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.BACKGROUNDIMAGENAME;
                    File.Copy(objFileDialog.FileName, imagePath, true);
                    this.BackgroundImage = Image.FromFile(imagePath);
                }
            }
            catch { };
        }

        private void BackgroundBtn_MouseMove(object sender, MouseEventArgs e)
        {
            backgroundBtn.Image = Properties.Resources.AiReward2;
        }

        private void BackgroundBtn_MouseLeave(object sender, EventArgs e)
        {
            backgroundBtn.Image = Properties.Resources.background;
        }

        private void SizeInfoInit()
        {
            //        formMain.fsSet._x = this.Width;
            //        formMain.fsSet._y = this.Height;
            this.Tag = this.Width + ":" + this.Height + ":" + this.Left + ":" + this.Top + ":" + this.Font.Size;
            formMain.fsSet.setTag(this);
        }

        private void InputText_Enter(object sender, EventArgs e)
        {
            if (inputText.Text == Common.DEFAULTTEXT)
            {
                inputText.Text = "";
                inputText.ForeColor = Color.Black;
            }
        }


        private void InputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindClassify(classifyNow);
            }
        }

        private void InputText_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputText.Text))
            {
                SetDefaultText();
                InitClassifyList(classifyNow);
            }
        }

        private void ResultText_Enter(object sender, EventArgs e)
        {
            if (resultText.Text == Common.DEFAULTRESULTTEXT)
            {
                resultText.Text = "";
                resultText.ForeColor = Color.Black;
            }
        }

        private void SkinButton1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.skinButton1, "置顶");
        }

        private void BackgroundBtn_MouseEnter(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.backgroundBtn, "更换背景");
        }
    }
}
