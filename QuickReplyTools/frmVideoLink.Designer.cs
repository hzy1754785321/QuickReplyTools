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
            this.components = new System.ComponentModel.Container();
            this.videoList = new CCWin.SkinControl.SkinListBox();
            this.classSearchCombo = new CCWin.SkinControl.SkinComboBox();
            this.classList = new CCWin.SkinControl.SkinListBox();
            this.VideoLinkText = new CCWin.SkinControl.SkinLabel();
            this.toyName = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VideoNameTxt = new CCWin.SkinControl.SkinLabel();
            this.videoUpTxt = new CCWin.SkinControl.SkinLabel();
            this.videoPresentTxt = new CCWin.SkinControl.SkinLabel();
            this.videoLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.videoNameLab = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // videoList
            // 
            this.videoList.Back = null;
            this.videoList.BackColor = System.Drawing.Color.Transparent;
            this.videoList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.videoList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.videoList.FormattingEnabled = true;
            this.videoList.ImageVisble = false;
            this.videoList.IntegralHeight = false;
            this.videoList.ItemHeight = 32;
            this.videoList.Location = new System.Drawing.Point(240, 94);
            this.videoList.Name = "videoList";
            this.videoList.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.videoList.Size = new System.Drawing.Size(383, 441);
            this.videoList.TabIndex = 31;
            this.videoList.SelectedIndexChanged += new System.EventHandler(this.VideoList_SelectedIndexChanged);
            this.videoList.DoubleClick += new System.EventHandler(this.VideoList_DoubleClick);
            this.videoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VideoList_MouseDoubleClick);
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
            this.classSearchCombo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.classSearchCombo.ItemHeight = 30;
            this.classSearchCombo.Location = new System.Drawing.Point(82, 94);
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
            this.classList.BackColor = System.Drawing.Color.Transparent;
            this.classList.CausesValidation = false;
            this.classList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classList.FormattingEnabled = true;
            this.classList.ImageVisble = false;
            this.classList.IntegralHeight = false;
            this.classList.ItemHeight = 33;
            this.classList.Location = new System.Drawing.Point(82, 136);
            this.classList.Name = "classList";
            this.classList.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.VideoLinkText.Location = new System.Drawing.Point(378, 66);
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
            this.toyName.Location = new System.Drawing.Point(107, 66);
            this.toyName.Name = "toyName";
            this.toyName.Size = new System.Drawing.Size(69, 25);
            this.toyName.TabIndex = 37;
            this.toyName.Text = "玩具名";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.skinButton1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.GlowColor = System.Drawing.SystemColors.Control;
            this.skinButton1.Image = global::QuickReplyTools.Properties.Resources.AvatarCardPic;
            this.skinButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(1035, -1);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.White;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(40, 37);
            this.skinButton1.TabIndex = 39;
            this.skinButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VideoNameTxt);
            this.panel1.Controls.Add(this.videoUpTxt);
            this.panel1.Controls.Add(this.videoPresentTxt);
            this.panel1.Controls.Add(this.videoLogo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.videoNameLab);
            this.panel1.Location = new System.Drawing.Point(689, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 259);
            this.panel1.TabIndex = 40;
            // 
            // VideoNameTxt
            // 
            this.VideoNameTxt.AutoEllipsis = true;
            this.VideoNameTxt.AutoSize = true;
            this.VideoNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.VideoNameTxt.BorderColor = System.Drawing.Color.White;
            this.VideoNameTxt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VideoNameTxt.Location = new System.Drawing.Point(97, 133);
            this.VideoNameTxt.Name = "VideoNameTxt";
            this.VideoNameTxt.Size = new System.Drawing.Size(0, 14);
            this.VideoNameTxt.TabIndex = 45;
            // 
            // videoUpTxt
            // 
            this.videoUpTxt.AutoEllipsis = true;
            this.videoUpTxt.AutoSize = true;
            this.videoUpTxt.BackColor = System.Drawing.Color.Transparent;
            this.videoUpTxt.BorderColor = System.Drawing.Color.White;
            this.videoUpTxt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.videoUpTxt.Location = new System.Drawing.Point(69, 164);
            this.videoUpTxt.Name = "videoUpTxt";
            this.videoUpTxt.Size = new System.Drawing.Size(0, 14);
            this.videoUpTxt.TabIndex = 44;
            // 
            // videoPresentTxt
            // 
            this.videoPresentTxt.AutoEllipsis = true;
            this.videoPresentTxt.AutoSize = true;
            this.videoPresentTxt.BackColor = System.Drawing.Color.Transparent;
            this.videoPresentTxt.BorderColor = System.Drawing.Color.White;
            this.videoPresentTxt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.videoPresentTxt.Location = new System.Drawing.Point(91, 200);
            this.videoPresentTxt.Name = "videoPresentTxt";
            this.videoPresentTxt.Size = new System.Drawing.Size(0, 14);
            this.videoPresentTxt.TabIndex = 43;
            // 
            // videoLogo
            // 
            this.videoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.videoLogo.Location = new System.Drawing.Point(101, 24);
            this.videoLogo.Name = "videoLogo";
            this.videoLogo.Size = new System.Drawing.Size(144, 90);
            this.videoLogo.TabIndex = 5;
            this.videoLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "视频封面:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "视频简介:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "UP主:";
            // 
            // videoNameLab
            // 
            this.videoNameLab.AutoSize = true;
            this.videoNameLab.Location = new System.Drawing.Point(10, 130);
            this.videoNameLab.Name = "videoNameLab";
            this.videoNameLab.Size = new System.Drawing.Size(59, 12);
            this.videoNameLab.TabIndex = 0;
            this.videoNameLab.Text = "视频标题:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(647, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 42;
            this.label20.Text = "》";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "已复制到粘贴板";
            this.label1.Visible = false;
            // 
            // frmVideoLink
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.toyName);
            this.Controls.Add(this.VideoLinkText);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.classSearchCombo);
            this.Controls.Add(this.classList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVideoLink";
            this.Text = "VideoLink";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinListBox videoList;
        private CCWin.SkinControl.SkinComboBox classSearchCombo;
        private CCWin.SkinControl.SkinListBox classList;
        private CCWin.SkinControl.SkinLabel VideoLinkText;
        private CCWin.SkinControl.SkinLabel toyName;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox videoLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label videoNameLab;
        private System.Windows.Forms.Label label20;
        private CCWin.SkinControl.SkinLabel videoPresentTxt;
        private CCWin.SkinControl.SkinLabel videoUpTxt;
        private CCWin.SkinControl.SkinLabel VideoNameTxt;
        private System.Windows.Forms.Label label1;
    }
}