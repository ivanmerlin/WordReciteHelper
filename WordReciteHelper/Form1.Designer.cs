namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WordLabel = new System.Windows.Forms.Label();
            this.TransLabel = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.colorBtn = new System.Windows.Forms.Button();
            this.soundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WordLabel
            // 
            this.WordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Consolas", 20F);
            this.WordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WordLabel.Location = new System.Drawing.Point(287, 9);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(0, 32);
            this.WordLabel.TabIndex = 0;
            this.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransLabel
            // 
            this.TransLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TransLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.TransLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TransLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransLabel.Location = new System.Drawing.Point(12, 61);
            this.TransLabel.Name = "TransLabel";
            this.TransLabel.Size = new System.Drawing.Size(597, 164);
            this.TransLabel.TabIndex = 1;
            this.TransLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(631, 186);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(49, 48);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "太熟悉";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(643, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 28);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(631, 135);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(49, 45);
            this.colorBtn.TabIndex = 4;
            this.colorBtn.Text = "切换\r\n主题";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // soundPlayer
            // 
            this.soundPlayer.Enabled = true;
            this.soundPlayer.Location = new System.Drawing.Point(13, 200);
            this.soundPlayer.Name = "soundPlayer";
            this.soundPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("soundPlayer.OcxState")));
            this.soundPlayer.Size = new System.Drawing.Size(40, 33);
            this.soundPlayer.TabIndex = 5;
            this.soundPlayer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(680, 234);
            this.ControlBox = false;
            this.Controls.Add(this.soundPlayer);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.TransLabel);
            this.Controls.Add(this.WordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.soundPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label TransLabel;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button colorBtn;
        private AxWMPLib.AxWindowsMediaPlayer soundPlayer;
    }
}

