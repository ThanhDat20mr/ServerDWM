
namespace TestChatMulti
{
    partial class fMactching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMactching));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pics = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbBio = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbEdu = new System.Windows.Forms.Label();
            this.picHeight = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.picLocation = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.picEdu = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pics
            // 
            this.pics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pics.BackColor = System.Drawing.Color.Transparent;
            this.pics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pics.Location = new System.Drawing.Point(293, 53);
            this.pics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pics.Name = "pics";
            this.pics.Size = new System.Drawing.Size(636, 450);
            this.pics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pics.TabIndex = 0;
            this.pics.TabStop = false;
            this.pics.Click += new System.EventHandler(this.pics_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(11, 49);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(86, 32);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.White;
            this.lbAge.Location = new System.Drawing.Point(11, 82);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(63, 32);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // lbBio
            // 
            this.lbBio.BackColor = System.Drawing.Color.Transparent;
            this.lbBio.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBio.ForeColor = System.Drawing.Color.White;
            this.lbBio.Location = new System.Drawing.Point(959, 62);
            this.lbBio.Name = "lbBio";
            this.lbBio.Size = new System.Drawing.Size(341, 308);
            this.lbBio.TabIndex = 2;
            this.lbBio.Text = "Bio";
            // 
            // lbLocation
            // 
            this.lbLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.White;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLocation.Location = new System.Drawing.Point(85, 294);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(67, 20);
            this.lbLocation.TabIndex = 2;
            this.lbLocation.Text = "Location";
            // 
            // lbHeight
            // 
            this.lbHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHeight.AutoSize = true;
            this.lbHeight.BackColor = System.Drawing.Color.White;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeight.Location = new System.Drawing.Point(79, 194);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(55, 20);
            this.lbHeight.TabIndex = 2;
            this.lbHeight.Text = "Height";
            // 
            // lbEdu
            // 
            this.lbEdu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEdu.AutoSize = true;
            this.lbEdu.BackColor = System.Drawing.Color.White;
            this.lbEdu.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEdu.Location = new System.Drawing.Point(79, 288);
            this.lbEdu.Name = "lbEdu";
            this.lbEdu.Size = new System.Drawing.Size(77, 20);
            this.lbEdu.TabIndex = 2;
            this.lbEdu.Text = "Education";
            // 
            // picHeight
            // 
            this.picHeight.AllowFocused = false;
            this.picHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHeight.AutoSizeHeight = true;
            this.picHeight.BorderRadius = 22;
            this.picHeight.Image = ((System.Drawing.Image)(resources.GetObject("picHeight.Image")));
            this.picHeight.IsCircle = true;
            this.picHeight.Location = new System.Drawing.Point(16, 235);
            this.picHeight.Margin = new System.Windows.Forms.Padding(4);
            this.picHeight.Name = "picHeight";
            this.picHeight.Size = new System.Drawing.Size(44, 44);
            this.picHeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeight.TabIndex = 5;
            this.picHeight.TabStop = false;
            this.picHeight.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // picLocation
            // 
            this.picLocation.AllowFocused = false;
            this.picLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLocation.AutoSizeHeight = true;
            this.picLocation.BorderRadius = 22;
            this.picLocation.Image = ((System.Drawing.Image)(resources.GetObject("picLocation.Image")));
            this.picLocation.IsCircle = true;
            this.picLocation.Location = new System.Drawing.Point(16, 283);
            this.picLocation.Margin = new System.Windows.Forms.Padding(4);
            this.picLocation.Name = "picLocation";
            this.picLocation.Size = new System.Drawing.Size(44, 44);
            this.picLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLocation.TabIndex = 5;
            this.picLocation.TabStop = false;
            this.picLocation.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // picEdu
            // 
            this.picEdu.AllowFocused = false;
            this.picEdu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEdu.AutoSizeHeight = true;
            this.picEdu.BorderRadius = 22;
            this.picEdu.Image = ((System.Drawing.Image)(resources.GetObject("picEdu.Image")));
            this.picEdu.IsCircle = true;
            this.picEdu.Location = new System.Drawing.Point(16, 331);
            this.picEdu.Margin = new System.Windows.Forms.Padding(4);
            this.picEdu.Name = "picEdu";
            this.picEdu.Size = new System.Drawing.Size(44, 44);
            this.picEdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdu.TabIndex = 5;
            this.picEdu.TabStop = false;
            this.picEdu.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbAge);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbEdu);
            this.groupBox1.Controls.Add(this.lbHeight);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 362);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(79)))), ((int)(((byte)(74)))));
            this.xuiGradientPanel1.Controls.Add(this.lbBio);
            this.xuiGradientPanel1.Controls.Add(this.groupBox1);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(-5, -9);
            this.xuiGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(1348, 687);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 8;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Fuchsia;
            // 
            // fMactching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1328, 681);
            this.Controls.Add(this.picEdu);
            this.Controls.Add(this.picLocation);
            this.Controls.Add(this.picHeight);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.pics);
            this.Controls.Add(this.xuiGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMactching";
            this.Text = "fMactching";
            this.Load += new System.EventHandler(this.fMactching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEdu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pics;
        public System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbBio;
        private System.Windows.Forms.Label lbLocation;
        public System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbEdu;
        private Bunifu.UI.WinForms.BunifuPictureBox picHeight;
        private Bunifu.UI.WinForms.BunifuPictureBox picLocation;
        private Bunifu.UI.WinForms.BunifuPictureBox picEdu;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
    }
}