namespace QuickReplyTools
{
    partial class frmQuickReply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickReply));
            this.resultText = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.subSearchCombo = new CCWin.SkinControl.SkinComboBox();
            this.subList = new CCWin.SkinControl.SkinListBox();
            this.classSearchCombo = new CCWin.SkinControl.SkinComboBox();
            this.classList = new CCWin.SkinControl.SkinListBox();
            this.toyBtn = new CCWin.SkinControl.SkinButton();
            this.speechBtn = new CCWin.SkinControl.SkinButton();
            this.inputLabel = new CCWin.SkinControl.SkinLabel();
            this.inputText = new CCWin.SkinControl.SkinTextBox();
            this.resultCombo = new CCWin.SkinControl.SkinComboBox();
            this.resultTempList = new CCWin.SkinControl.SkinListBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.Color.Transparent;
            this.resultText.DownBack = null;
            this.resultText.Icon = null;
            this.resultText.IconIsButton = false;
            this.resultText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.resultText.IsPasswordChat = '\0';
            this.resultText.IsSystemPasswordChar = false;
            this.resultText.Lines = new string[0];
            this.resultText.Location = new System.Drawing.Point(129, 521);
            this.resultText.Margin = new System.Windows.Forms.Padding(0);
            this.resultText.MaxLength = 32767;
            this.resultText.MinimumSize = new System.Drawing.Size(28, 28);
            this.resultText.MouseBack = null;
            this.resultText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.NormlBack = null;
            this.resultText.Padding = new System.Windows.Forms.Padding(5);
            this.resultText.ReadOnly = false;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resultText.Size = new System.Drawing.Size(510, 153);
            // 
            // 
            // 
            this.resultText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.resultText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.resultText.SkinTxt.Multiline = true;
            this.resultText.SkinTxt.Name = "BaseText";
            this.resultText.SkinTxt.Size = new System.Drawing.Size(500, 143);
            this.resultText.SkinTxt.TabIndex = 0;
            this.resultText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.resultText.SkinTxt.WaterText = "";
            this.resultText.TabIndex = 32;
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resultText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.resultText.WaterText = "";
            this.resultText.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(333, 487);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(88, 25);
            this.skinLabel3.TabIndex = 31;
            this.skinLabel3.Text = "最终输出";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(309, 139);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(50, 25);
            this.skinLabel2.TabIndex = 30;
            this.skinLabel2.Text = "细分";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(146, 139);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(88, 25);
            this.skinLabel1.TabIndex = 29;
            this.skinLabel1.Text = "所属问题";
            // 
            // subSearchCombo
            // 
            this.subSearchCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subSearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.subSearchCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subSearchCombo.FormattingEnabled = true;
            this.subSearchCombo.ItemHeight = 30;
            this.subSearchCombo.Location = new System.Drawing.Point(274, 167);
            this.subSearchCombo.Name = "subSearchCombo";
            this.subSearchCombo.Size = new System.Drawing.Size(120, 28);
            this.subSearchCombo.TabIndex = 28;
            this.subSearchCombo.WaterText = "";
            // 
            // subList
            // 
            this.subList.Back = null;
            this.subList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subList.FormattingEnabled = true;
            this.subList.ItemHeight = 25;
            this.subList.Location = new System.Drawing.Point(274, 197);
            this.subList.Name = "subList";
            this.subList.Size = new System.Drawing.Size(120, 254);
            this.subList.TabIndex = 27;
            this.subList.SelectedIndexChanged += new System.EventHandler(this.SubList_SelectedIndexChanged);
            // 
            // classSearchCombo
            // 
            this.classSearchCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.classSearchCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classSearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.classSearchCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classSearchCombo.FormattingEnabled = true;
            this.classSearchCombo.ItemHeight = 30;
            this.classSearchCombo.Location = new System.Drawing.Point(129, 167);
            this.classSearchCombo.Name = "classSearchCombo";
            this.classSearchCombo.Size = new System.Drawing.Size(120, 28);
            this.classSearchCombo.TabIndex = 26;
            this.classSearchCombo.WaterText = "";
            // 
            // classList
            // 
            this.classList.Back = null;
            this.classList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classList.FormattingEnabled = true;
            this.classList.ItemHeight = 25;
            this.classList.Location = new System.Drawing.Point(129, 197);
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(120, 254);
            this.classList.TabIndex = 25;
            this.classList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            // 
            // toyBtn
            // 
            this.toyBtn.BackColor = System.Drawing.Color.Transparent;
            this.toyBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toyBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.toyBtn.DownBack = null;
            this.toyBtn.Location = new System.Drawing.Point(30, 356);
            this.toyBtn.MouseBack = null;
            this.toyBtn.Name = "toyBtn";
            this.toyBtn.NormlBack = null;
            this.toyBtn.Size = new System.Drawing.Size(75, 51);
            this.toyBtn.TabIndex = 24;
            this.toyBtn.Text = "玩具问题";
            this.toyBtn.UseVisualStyleBackColor = false;
            this.toyBtn.Click += new System.EventHandler(this.ToyBtn_Click);
            // 
            // speechBtn
            // 
            this.speechBtn.BackColor = System.Drawing.Color.Transparent;
            this.speechBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speechBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.speechBtn.DownBack = null;
            this.speechBtn.Location = new System.Drawing.Point(30, 223);
            this.speechBtn.MouseBack = null;
            this.speechBtn.Name = "speechBtn";
            this.speechBtn.NormlBack = null;
            this.speechBtn.Size = new System.Drawing.Size(75, 51);
            this.speechBtn.TabIndex = 23;
            this.speechBtn.Text = "话术类";
            this.speechBtn.UseVisualStyleBackColor = false;
            this.speechBtn.Click += new System.EventHandler(this.SpeechBtn_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.BorderColor = System.Drawing.Color.White;
            this.inputLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputLabel.Location = new System.Drawing.Point(345, 18);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(50, 25);
            this.inputLabel.TabIndex = 22;
            this.inputLabel.Text = "输入";
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.Transparent;
            this.inputText.DownBack = null;
            this.inputText.Icon = null;
            this.inputText.IconIsButton = false;
            this.inputText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.inputText.IsPasswordChat = '\0';
            this.inputText.IsSystemPasswordChar = false;
            this.inputText.Lines = new string[0];
            this.inputText.Location = new System.Drawing.Point(129, 64);
            this.inputText.Margin = new System.Windows.Forms.Padding(0);
            this.inputText.MaxLength = 32767;
            this.inputText.MinimumSize = new System.Drawing.Size(28, 28);
            this.inputText.MouseBack = null;
            this.inputText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.NormlBack = null;
            this.inputText.Padding = new System.Windows.Forms.Padding(5);
            this.inputText.ReadOnly = false;
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputText.Size = new System.Drawing.Size(510, 38);
            // 
            // 
            // 
            this.inputText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.inputText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.inputText.SkinTxt.Multiline = true;
            this.inputText.SkinTxt.Name = "BaseText";
            this.inputText.SkinTxt.Size = new System.Drawing.Size(500, 28);
            this.inputText.SkinTxt.TabIndex = 0;
            this.inputText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.inputText.SkinTxt.WaterText = "";
            this.inputText.TabIndex = 21;
            this.inputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.inputText.WaterText = "";
            this.inputText.WordWrap = true;
            // 
            // resultCombo
            // 
            this.resultCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resultCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.resultCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultCombo.FormattingEnabled = true;
            this.resultCombo.ItemHeight = 30;
            this.resultCombo.Location = new System.Drawing.Point(415, 167);
            this.resultCombo.Name = "resultCombo";
            this.resultCombo.Size = new System.Drawing.Size(224, 28);
            this.resultCombo.TabIndex = 34;
            this.resultCombo.WaterText = "";
            // 
            // resultTempList
            // 
            this.resultTempList.Back = null;
            this.resultTempList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resultTempList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultTempList.FormattingEnabled = true;
            this.resultTempList.ItemHeight = 25;
            this.resultTempList.Location = new System.Drawing.Point(415, 197);
            this.resultTempList.Name = "resultTempList";
            this.resultTempList.Size = new System.Drawing.Size(224, 254);
            this.resultTempList.TabIndex = 33;
            this.resultTempList.SelectedIndexChanged += new System.EventHandler(this.ResultTempList_SelectedIndexChanged);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(475, 139);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(88, 25);
            this.skinLabel4.TabIndex = 35;
            this.skinLabel4.Text = "输出列表";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmQuickReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.resultCombo);
            this.Controls.Add(this.resultTempList);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.subSearchCombo);
            this.Controls.Add(this.subList);
            this.Controls.Add(this.classSearchCombo);
            this.Controls.Add(this.classList);
            this.Controls.Add(this.toyBtn);
            this.Controls.Add(this.speechBtn);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuickReply";
            this.Text = "frmQucikReply";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox resultText;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox subSearchCombo;
        private CCWin.SkinControl.SkinListBox subList;
        private CCWin.SkinControl.SkinComboBox classSearchCombo;
        private CCWin.SkinControl.SkinListBox classList;
        private CCWin.SkinControl.SkinButton toyBtn;
        private CCWin.SkinControl.SkinButton speechBtn;
        private CCWin.SkinControl.SkinLabel inputLabel;
        private CCWin.SkinControl.SkinTextBox inputText;
        private CCWin.SkinControl.SkinComboBox resultCombo;
        private CCWin.SkinControl.SkinListBox resultTempList;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}