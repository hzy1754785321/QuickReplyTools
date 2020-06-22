namespace QuickReplyTools
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tpgQuickReply = new CCWin.SkinControl.SkinTabPage();
            this.tpgVideoLink = new CCWin.SkinControl.SkinTabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl1.Controls.Add(this.tpgQuickReply);
            this.tabControl1.Controls.Add(this.tpgVideoLink);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.tabControl1.HeadBack = null;
            this.tabControl1.ImgTxtOffset = new System.Drawing.Point(-1, 6);
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 76);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowDown")));
            this.tabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowHover")));
            this.tabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseHover")));
            this.tabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseNormal")));
            this.tabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageDown")));
            this.tabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageHover")));
            this.tabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl1.PageNorml = null;
            this.tabControl1.PageTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 968);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            // 
            // tpgQuickReply
            // 
            this.tpgQuickReply.AutoScroll = true;
            this.tpgQuickReply.BackColor = System.Drawing.Color.White;
            this.tpgQuickReply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpgQuickReply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpgQuickReply.Location = new System.Drawing.Point(76, 0);
            this.tpgQuickReply.Name = "tpgQuickReply";
            this.tpgQuickReply.Size = new System.Drawing.Size(885, 968);
            this.tpgQuickReply.TabIndex = 0;
            this.tpgQuickReply.TabItemImage = null;
            this.tpgQuickReply.Text = "快捷回复";
            this.tpgQuickReply.UseVisualStyleBackColor = true;
            this.tpgQuickReply.Enter += new System.EventHandler(this.TpgQuickReply_Enter);
            // 
            // tpgVideoLink
            // 
            this.tpgVideoLink.BackColor = System.Drawing.Color.White;
            this.tpgVideoLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpgVideoLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpgVideoLink.Location = new System.Drawing.Point(76, 0);
            this.tpgVideoLink.Name = "tpgVideoLink";
            this.tpgVideoLink.Size = new System.Drawing.Size(885, 968);
            this.tpgVideoLink.TabIndex = 1;
            this.tpgVideoLink.TabItemImage = null;
            this.tpgVideoLink.Text = "视频链接";
            this.tpgVideoLink.Enter += new System.EventHandler(this.TpgVideoLink_Enter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 976);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客服工具";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinTabControl tabControl1;
        private CCWin.SkinControl.SkinTabPage tpgQuickReply;
        private CCWin.SkinControl.SkinTabPage tpgVideoLink;
    }
}

