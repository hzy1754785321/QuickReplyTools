namespace QuickReplyTools
{
    partial class frmVideoLink
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoList = new CCWin.SkinControl.SkinListBox();
            this.classSearchCombo = new CCWin.SkinControl.SkinComboBox();
            this.classList = new CCWin.SkinControl.SkinListBox();
            this.VideoLinkText = new CCWin.SkinControl.SkinLabel();
            this.toyName = new CCWin.SkinControl.SkinLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // videoList
            // 
            this.videoList.Back = null;
            this.videoList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.videoList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.videoList.FormattingEnabled = true;
            this.videoList.ImageVisble = false;
            this.videoList.IntegralHeight = false;
            this.videoList.ItemHeight = 25;
            this.videoList.Location = new System.Drawing.Point(287, 102);
            this.videoList.Name = "videoList";
            this.videoList.Size = new System.Drawing.Size(278, 441);
            this.videoList.TabIndex = 31;
            this.videoList.DoubleClick += new System.EventHandler(this.VideoList_DoubleClick);
            // 
            // classSearchCombo
            // 
            this.classSearchCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classSearchCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classSearchCombo.CausesValidation = false;
            this.classSearchCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.classSearchCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classSearchCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classSearchCombo.FormattingEnabled = true;
            this.classSearchCombo.ItemHeight = 30;
            this.classSearchCombo.Location = new System.Drawing.Point(137, 102);
            this.classSearchCombo.MaxDropDownItems = 15;
            this.classSearchCombo.Name = "classSearchCombo";
            this.classSearchCombo.Size = new System.Drawing.Size(120, 36);
            this.classSearchCombo.TabIndex = 30;
            this.classSearchCombo.WaterText = "";
            this.classSearchCombo.SelectedValueChanged += new System.EventHandler(this.ClassSearchCombo_SelectedValueChanged);
            // 
            // classList
            // 
            this.classList.Back = null;
            this.classList.CausesValidation = false;
            this.classList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classList.FormattingEnabled = true;
            this.classList.ImageVisble = false;
            this.classList.IntegralHeight = false;
            this.classList.ItemHeight = 30;
            this.classList.Location = new System.Drawing.Point(137, 144);
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(121, 399);
            this.classList.TabIndex = 29;
            this.classList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            // 
            // VideoLinkText
            // 
            this.VideoLinkText.AutoSize = true;
            this.VideoLinkText.BackColor = System.Drawing.Color.Transparent;
            this.VideoLinkText.BorderColor = System.Drawing.Color.White;
            this.VideoLinkText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VideoLinkText.Location = new System.Drawing.Point(371, 59);
            this.VideoLinkText.Name = "VideoLinkText";
            this.VideoLinkText.Size = new System.Drawing.Size(88, 25);
            this.VideoLinkText.TabIndex = 36;
            this.VideoLinkText.Text = "视频链接";
            // 
            // toyName
            // 
            this.toyName.AutoSize = true;
            this.toyName.BackColor = System.Drawing.Color.Transparent;
            this.toyName.BorderColor = System.Drawing.Color.White;
            this.toyName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toyName.Location = new System.Drawing.Point(157, 59);
            this.toyName.Name = "toyName";
            this.toyName.Size = new System.Drawing.Size(69, 25);
            this.toyName.TabIndex = 37;
            this.toyName.Text = "玩具名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "已复制到粘贴板";
            this.label1.Visible = false;
            // 
            // frmVideoLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toyName);
            this.Controls.Add(this.VideoLinkText);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.classSearchCombo);
            this.Controls.Add(this.classList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVideoLink";
            this.Text = "VideoLink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinListBox videoList;
        private CCWin.SkinControl.SkinComboBox classSearchCombo;
        private CCWin.SkinControl.SkinListBox classList;
        private CCWin.SkinControl.SkinLabel VideoLinkText;
        private CCWin.SkinControl.SkinLabel toyName;
        private System.Windows.Forms.Label label1;
    }
}