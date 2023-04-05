
namespace Server.theme
{
    partial class fDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDashboard));
            this.circleActive = new XanderUI.XUICircleProgressBar();
            this.circleBan = new XanderUI.XUICircleProgressBar();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.numActive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBan = new System.Windows.Forms.Panel();
            this.numBan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNews = new System.Windows.Forms.Panel();
            this.numNews = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.numReport = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlActive.SuspendLayout();
            this.pnlBan.SuspendLayout();
            this.pnlNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // circleActive
            // 
            this.circleActive.AnimationSpeed = 5;
            this.circleActive.FilledColor = System.Drawing.Color.Aquamarine;
            this.circleActive.FilledColorAlpha = 200;
            this.circleActive.FilledThickness = 20;
            this.circleActive.IsAnimated = false;
            this.circleActive.Location = new System.Drawing.Point(211, 87);
            this.circleActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circleActive.Name = "circleActive";
            this.circleActive.Percentage = 55;
            this.circleActive.ShowText = true;
            this.circleActive.Size = new System.Drawing.Size(70, 64);
            this.circleActive.TabIndex = 0;
            this.circleActive.TextColor = System.Drawing.Color.Aquamarine;
            this.circleActive.TextSize = 10;
            this.circleActive.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.circleActive.UnfilledThickness = 24;
            // 
            // circleBan
            // 
            this.circleBan.AnimationSpeed = 5;
            this.circleBan.FilledColor = System.Drawing.Color.Khaki;
            this.circleBan.FilledColorAlpha = 200;
            this.circleBan.FilledThickness = 20;
            this.circleBan.IsAnimated = false;
            this.circleBan.Location = new System.Drawing.Point(211, 87);
            this.circleBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circleBan.Name = "circleBan";
            this.circleBan.Percentage = 55;
            this.circleBan.ShowText = true;
            this.circleBan.Size = new System.Drawing.Size(70, 64);
            this.circleBan.TabIndex = 0;
            this.circleBan.TextColor = System.Drawing.Color.Khaki;
            this.circleBan.TextSize = 10;
            this.circleBan.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.circleBan.UnfilledThickness = 24;
            // 
            // pnlActive
            // 
            this.pnlActive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlActive.Controls.Add(this.numActive);
            this.pnlActive.Controls.Add(this.label1);
            this.pnlActive.Controls.Add(this.circleActive);
            this.pnlActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlActive.Location = new System.Drawing.Point(451, 74);
            this.pnlActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(288, 158);
            this.pnlActive.TabIndex = 1;
            this.pnlActive.Click += new System.EventHandler(this.pnlActive_Click);
            // 
            // numActive
            // 
            this.numActive.AutoSize = true;
            this.numActive.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numActive.ForeColor = System.Drawing.Color.White;
            this.numActive.Location = new System.Drawing.Point(16, 68);
            this.numActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numActive.Name = "numActive";
            this.numActive.Size = new System.Drawing.Size(35, 41);
            this.numActive.TabIndex = 1;
            this.numActive.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active account";
            // 
            // pnlBan
            // 
            this.pnlBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBan.Controls.Add(this.numBan);
            this.pnlBan.Controls.Add(this.label2);
            this.pnlBan.Controls.Add(this.circleBan);
            this.pnlBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBan.Location = new System.Drawing.Point(451, 256);
            this.pnlBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBan.Name = "pnlBan";
            this.pnlBan.Size = new System.Drawing.Size(288, 158);
            this.pnlBan.TabIndex = 1;
            this.pnlBan.Click += new System.EventHandler(this.pnlBan_Click);
            // 
            // numBan
            // 
            this.numBan.AutoSize = true;
            this.numBan.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBan.ForeColor = System.Drawing.Color.White;
            this.numBan.Location = new System.Drawing.Point(11, 68);
            this.numBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numBan.Name = "numBan";
            this.numBan.Size = new System.Drawing.Size(35, 41);
            this.numBan.TabIndex = 1;
            this.numBan.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banned account";
            // 
            // pnlNews
            // 
            this.pnlNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNews.Controls.Add(this.numNews);
            this.pnlNews.Controls.Add(this.pictureBox1);
            this.pnlNews.Controls.Add(this.label3);
            this.pnlNews.Location = new System.Drawing.Point(47, 74);
            this.pnlNews.Name = "pnlNews";
            this.pnlNews.Size = new System.Drawing.Size(288, 158);
            this.pnlNews.TabIndex = 3;
            // 
            // numNews
            // 
            this.numNews.AutoSize = true;
            this.numNews.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNews.ForeColor = System.Drawing.Color.White;
            this.numNews.Location = new System.Drawing.Point(18, 68);
            this.numNews.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numNews.Name = "numNews";
            this.numNews.Size = new System.Drawing.Size(35, 41);
            this.numNews.TabIndex = 1;
            this.numNews.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 102);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "News";
            // 
            // pnlReport
            // 
            this.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReport.Controls.Add(this.numReport);
            this.pnlReport.Controls.Add(this.pictureBox2);
            this.pnlReport.Controls.Add(this.label4);
            this.pnlReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlReport.Location = new System.Drawing.Point(47, 256);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(288, 158);
            this.pnlReport.TabIndex = 5;
            this.pnlReport.Click += new System.EventHandler(this.pnlReport_Click);
            // 
            // numReport
            // 
            this.numReport.AutoSize = true;
            this.numReport.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReport.ForeColor = System.Drawing.Color.White;
            this.numReport.Location = new System.Drawing.Point(18, 68);
            this.numReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numReport.Name = "numReport";
            this.numReport.Size = new System.Drawing.Size(35, 41);
            this.numReport.TabIndex = 1;
            this.numReport.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 102);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Report";
            // 
            // fDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(767, 440);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.pnlNews);
            this.Controls.Add(this.pnlBan);
            this.Controls.Add(this.pnlActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fDashboard";
            this.Text = "fDashboard";
            this.Load += new System.EventHandler(this.fDashboard_Load);
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.pnlBan.ResumeLayout(false);
            this.pnlBan.PerformLayout();
            this.pnlNews.ResumeLayout(false);
            this.pnlNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlReport.ResumeLayout(false);
            this.pnlReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUICircleProgressBar circleActive;
        private XanderUI.XUICircleProgressBar circleBan;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label numActive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBan;
        private System.Windows.Forms.Label numBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNews;
        private System.Windows.Forms.Label numNews;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.Label numReport;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}