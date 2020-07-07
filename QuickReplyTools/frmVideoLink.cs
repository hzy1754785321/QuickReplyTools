using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace QuickReplyTools
{
    public partial class frmVideoLink : Form
    {
        public static FormMain formMain;

        //       FormSizeSet fsSet = new FormSizeSet();
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
            formMain = frmMain;
            InitData();
            SizeInfoInit();
            var imagePath = System.IO.Directory.GetCurrentDirectory() + @"\" + Common.BACKGROUNDIMAGENAME;
            try
            {
                this.BackgroundImage = Image.FromFile(imagePath);
            }
            catch
            { }
        }

        public void InitData()
        {
            try
            {
                classList.Items.Clear();
                foreach (var data in DataCenter.VedioDatas)
                {
                    classSearchCombo.Items.Add(data.classify);
                    classList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.classify));
                }
            }
            catch{ };
        }

        private void ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                videoList.Items.Clear();
                //     classSearchCombo.Items.Clear();
                foreach (var data in DataCenter.VedioDatas)
                {
                    if (data.classify == Convert.ToString(classList.SelectedItem).Trim())
                    {
                        //                classSearchCombo.Items.Add(data.videoLink);
                        videoList.Items.Add(new CCWin.SkinControl.SkinListBoxItem(data.videoLink));
                    }
                }


            }
            catch { };
        }

        private void VideoList_DoubleClick(object sender, EventArgs e)
        {

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

        private void VideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string str = Convert.ToString(videoList.SelectedItem);
                if (string.IsNullOrEmpty(str))
                    return;
                string[] sArray = Regex.Split(str, "https://www.bilibili.com/video/", RegexOptions.IgnoreCase);
                var url = "https://api.bilibili.com/x/web-interface/view?bvid=" + sArray[1];
                var jsonData = GetContentFromUrl(url);
                JObject json = JObject.Parse(jsonData);
                string dataS = Convert.ToString(json["data"]);
                JObject data = JObject.Parse(dataS);
                string title = Convert.ToString(data["title"]);
                string present = Convert.ToString(data["desc"]);
                string picPath = Convert.ToString(data["pic"]);
                string ownerJson = Convert.ToString(data["owner"]);
                JObject owner = JObject.Parse(ownerJson);
                string upName = Convert.ToString(owner["name"]);
                System.Net.WebRequest webreq = System.Net.WebRequest.Create(picPath);
                System.Net.WebResponse webres = webreq.GetResponse();
                using (System.IO.Stream stream = webres.GetResponseStream())
                {
                    Image imageSource = Image.FromStream(stream);
                    Bitmap bitmap = new Bitmap(imageSource);
                    videoLogo.Image = Common.resizeImage(bitmap, new Size(144, 90));
                }
                VideoNameTxt.Text = title;
                videoUpTxt.Text = upName;
                videoPresentTxt.Text = present;
            }
            catch { };
        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            try
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
            catch { };
        }

        private void SizeInfoInit()
        {
            this.Tag = this.Width + ":" + this.Height + ":" + this.Left + ":" + this.Top + ":" + this.Font.Size;
            formMain.fsSet.setTag(this);
        }

        private static bool CheckValidationResult(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors errors)
        {
            return true; //总是接受  
        }


        /// <summary>
        /// 根据Url获取页面所有内容
        /// </summary>
        /// <param name="url">请求的url</param>
        /// <returns>返回页面的内容</returns>
        public string GetContentFromUrl(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Credentials = CredentialCache.DefaultCredentials;//获取或设置请求凭据
                Byte[] pageData = client.DownloadData(url); //下载数据
                string pageHtml = System.Text.Encoding.UTF8.GetString(pageData);
                return pageHtml;
            }
            catch (WebException ex)
            {
                return ex.Message;
            }


        }

        private void VideoList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(Convert.ToString(videoList.SelectedItem));
                show1 = new ShowCopy(ShowText);
                IAsyncResult ar = show1.BeginInvoke(null, null);
            }
            catch{};
        }
    }
}
