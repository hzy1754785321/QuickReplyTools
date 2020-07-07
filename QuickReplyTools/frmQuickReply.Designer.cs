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
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.subSearchCombo = new CCWin.SkinControl.SkinComboBox();
            this.subList = new CCWin.SkinControl.SkinListBox();
            this.classSearchCombo = new CCWin.SkinControl.SkinComboBox();
            this.classList = new CCWin.SkinControl.SkinListBox();
            this.toyBtn = new CCWin.SkinControl.SkinButton();
            this.speechBtn = new CCWin.SkinControl.SkinButton();
            this.resultCombo = new CCWin.SkinControl.SkinComboBox();
            this.resultTempList = new CCWin.SkinControl.SkinListBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.backgroundBtn = new CCWin.SkinControl.SkinButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputText = new QuickReplyTools.NewTextBox();
            this.resultText = new QuickReplyTools.NewTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(529, 129);
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
            this.skinLabel1.Location = new System.Drawing.Point(213, 129);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(88, 25);
            this.skinLabel1.TabIndex = 29;
            this.skinLabel1.Text = "所属问题";
            // 
            // subSearchCombo
            // 
            this.subSearchCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.subSearchCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.subSearchCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subSearchCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subSearchCombo.FormattingEnabled = true;
            this.subSearchCombo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.subSearchCombo.ItemHeight = 30;
            this.subSearchCombo.Location = new System.Drawing.Point(448, 157);
            this.subSearchCombo.Name = "subSearchCombo";
            this.subSearchCombo.Size = new System.Drawing.Size(245, 36);
            this.subSearchCombo.TabIndex = 28;
            this.subSearchCombo.WaterText = "";
            this.subSearchCombo.SelectedIndexChanged += new System.EventHandler(this.SubSearchCombo_SelectedIndexChanged);
            // 
            // subList
            // 
            this.subList.Back = null;
            this.subList.BackColor = System.Drawing.Color.Transparent;
            this.subList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subList.FormattingEnabled = true;
            this.subList.HorizontalScrollbar = true;
            this.subList.ImageVisble = false;
            this.subList.IntegralHeight = false;
            this.subList.ItemHeight = 32;
            this.subList.Location = new System.Drawing.Point(448, 193);
            this.subList.Name = "subList";
            this.subList.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subList.Size = new System.Drawing.Size(245, 327);
            this.subList.TabIndex = 27;
            this.subList.SelectedIndexChanged += new System.EventHandler(this.SubList_SelectedIndexChanged);
            // 
            // classSearchCombo
            // 
            this.classSearchCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classSearchCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classSearchCombo.CausesValidation = false;
            this.classSearchCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.classSearchCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classSearchCombo.DropBackColor = System.Drawing.Color.Transparent;
            this.classSearchCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classSearchCombo.FormattingEnabled = true;
            this.classSearchCombo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.classSearchCombo.ItemHeight = 30;
            this.classSearchCombo.Location = new System.Drawing.Point(152, 157);
            this.classSearchCombo.MaxDropDownItems = 15;
            this.classSearchCombo.Name = "classSearchCombo";
            this.classSearchCombo.Size = new System.Drawing.Size(245, 36);
            this.classSearchCombo.TabIndex = 26;
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
            this.classList.HorizontalScrollbar = true;
            this.classList.IntegralHeight = false;
            this.classList.ItemHeight = 50;
            this.classList.Location = new System.Drawing.Point(152, 193);
            this.classList.Name = "classList";
            this.classList.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.classList.Size = new System.Drawing.Size(245, 327);
            this.classList.TabIndex = 25;
            this.classList.SelectedIndexChanged += new System.EventHandler(this.ClassList_SelectedIndexChanged);
            this.classList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClassList_MouseDoubleClick);
            // 
            // toyBtn
            // 
            this.toyBtn.BackColor = System.Drawing.Color.Transparent;
            this.toyBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toyBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.toyBtn.DownBack = null;
            this.toyBtn.Location = new System.Drawing.Point(37, 397);
            this.toyBtn.MouseBack = null;
            this.toyBtn.Name = "toyBtn";
            this.toyBtn.NormlBack = null;
            this.toyBtn.Size = new System.Drawing.Size(68, 51);
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
            this.speechBtn.Location = new System.Drawing.Point(37, 264);
            this.speechBtn.MouseBack = null;
            this.speechBtn.Name = "speechBtn";
            this.speechBtn.NormlBack = null;
            this.speechBtn.Size = new System.Drawing.Size(68, 51);
            this.speechBtn.TabIndex = 23;
            this.speechBtn.Text = "话术类";
            this.speechBtn.UseVisualStyleBackColor = false;
            this.speechBtn.Click += new System.EventHandler(this.SpeechBtn_Click);
            // 
            // resultCombo
            // 
            this.resultCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.resultCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.resultCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resultCombo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultCombo.FormattingEnabled = true;
            this.resultCombo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.resultCombo.ItemHeight = 30;
            this.resultCombo.Location = new System.Drawing.Point(747, 157);
            this.resultCombo.Name = "resultCombo";
            this.resultCombo.Size = new System.Drawing.Size(245, 36);
            this.resultCombo.TabIndex = 34;
            this.resultCombo.WaterText = "";
            this.resultCombo.SelectedValueChanged += new System.EventHandler(this.ResultCombo_SelectedValueChanged);
            // 
            // resultTempList
            // 
            this.resultTempList.Back = null;
            this.resultTempList.BackColor = System.Drawing.Color.Transparent;
            this.resultTempList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.resultTempList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultTempList.FormattingEnabled = true;
            this.resultTempList.HorizontalScrollbar = true;
            this.resultTempList.ImageVisble = false;
            this.resultTempList.IntegralHeight = false;
            this.resultTempList.ItemHeight = 32;
            this.resultTempList.Location = new System.Drawing.Point(747, 193);
            this.resultTempList.Name = "resultTempList";
            this.resultTempList.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultTempList.Size = new System.Drawing.Size(245, 327);
            this.resultTempList.TabIndex = 33;
            this.resultTempList.SelectedIndexChanged += new System.EventHandler(this.ResultTempList_SelectedIndexChanged);
            this.resultTempList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResultTempList_MouseDoubleClick);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(812, 129);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(88, 25);
            this.skinLabel4.TabIndex = 35;
            this.skinLabel4.Text = "输出列表";
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
            this.skinButton1.TabIndex = 37;
            this.skinButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            this.skinButton1.MouseEnter += new System.EventHandler(this.SkinButton1_MouseEnter);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.BackColor = System.Drawing.Color.Transparent;
            this.backgroundBtn.BaseColor = System.Drawing.Color.Transparent;
            this.backgroundBtn.BorderColor = System.Drawing.Color.Transparent;
            this.backgroundBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.backgroundBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backgroundBtn.DownBack = null;
            this.backgroundBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.backgroundBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.backgroundBtn.Image = global::QuickReplyTools.Properties.Resources.background;
            this.backgroundBtn.ImageSize = new System.Drawing.Size(45, 45);
            this.backgroundBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.backgroundBtn.Location = new System.Drawing.Point(1029, 620);
            this.backgroundBtn.MouseBack = null;
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.NormlBack = null;
            this.backgroundBtn.Size = new System.Drawing.Size(40, 40);
            this.backgroundBtn.TabIndex = 38;
            this.backgroundBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backgroundBtn.UseVisualStyleBackColor = false;
            this.backgroundBtn.Click += new System.EventHandler(this.BackgroundBtn_Click);
            this.backgroundBtn.MouseEnter += new System.EventHandler(this.BackgroundBtn_MouseEnter);
            this.backgroundBtn.MouseLeave += new System.EventHandler(this.BackgroundBtn_MouseLeave);
            this.backgroundBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackgroundBtn_MouseMove);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(416, 321);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 41;
            this.label20.Text = "》";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(710, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "》";
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText.ImeMode = System.Windows.Forms.ImeMode.On;
            this.inputText.Location = new System.Drawing.Point(260, 29);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(571, 84);
            this.inputText.TabIndex = 40;
            this.inputText.Text = "";
            this.inputText.Enter += new System.EventHandler(this.InputText_Enter);
            this.inputText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputText_KeyDown);
            this.inputText.Validated += new System.EventHandler(this.InputText_Validated);
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.resultText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultText.ImeMode = System.Windows.Forms.ImeMode.On;
            this.resultText.Location = new System.Drawing.Point(152, 538);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(837, 120);
            this.resultText.TabIndex = 39;
            this.resultText.Text = "";
            this.resultText.DoubleClick += new System.EventHandler(this.ResultText_DoubleClick);
            this.resultText.Enter += new System.EventHandler(this.ResultText_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "已复制到粘贴板";
            this.label1.Visible = false;
            // 
            // frmQuickReply
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 664);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.backgroundBtn);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.resultCombo);
            this.Controls.Add(this.resultTempList);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.subSearchCombo);
            this.Controls.Add(this.subList);
            this.Controls.Add(this.classSearchCombo);
            this.Controls.Add(this.classList);
            this.Controls.Add(this.toyBtn);
            this.Controls.Add(this.speechBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuickReply";
            this.Tag = "";
            this.Text = "frmQucikReply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox subSearchCombo;
        private CCWin.SkinControl.SkinListBox subList;
        private CCWin.SkinControl.SkinComboBox classSearchCombo;
        private CCWin.SkinControl.SkinListBox classList;
        private CCWin.SkinControl.SkinButton toyBtn;
        private CCWin.SkinControl.SkinButton speechBtn;
        private CCWin.SkinControl.SkinComboBox resultCombo;
        private CCWin.SkinControl.SkinListBox resultTempList;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton backgroundBtn;
        private NewTextBox resultText;
        private NewTextBox inputText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}