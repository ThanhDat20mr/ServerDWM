
namespace Server.theme
{
    partial class InComming
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InComming));
            this.lblTime = new System.Windows.Forms.Label();
            this.Avt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtMess = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            this.txtMess.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(173, 57);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.MaximumSize = new System.Drawing.Size(225, 812);
            this.lblTime.MinimumSize = new System.Drawing.Size(0, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(4);
            this.lblTime.Size = new System.Drawing.Size(39, 28);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Hello";
            // 
            // Avt
            // 
            this.Avt.AllowFocused = false;
            this.Avt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Avt.AutoSizeHeight = true;
            this.Avt.BorderRadius = 21;
            this.Avt.Image = ((System.Drawing.Image)(resources.GetObject("Avt.Image")));
            this.Avt.IsCircle = true;
            this.Avt.Location = new System.Drawing.Point(36, 32);
            this.Avt.Margin = new System.Windows.Forms.Padding(2);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(42, 42);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 7;
            this.Avt.TabStop = false;
            this.Avt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // txtMess
            // 
            this.txtMess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtMess.BackgroundColor = System.Drawing.Color.Blue;
            this.txtMess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMess.BackgroundImage")));
            this.txtMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMess.BorderColor = System.Drawing.Color.Transparent;
            this.txtMess.BorderRadius = 40;
            this.txtMess.BorderThickness = 1;
            this.txtMess.Controls.Add(this.label1);
            this.txtMess.Location = new System.Drawing.Point(89, 34);
            this.txtMess.Margin = new System.Windows.Forms.Padding(2);
            this.txtMess.MaximumSize = new System.Drawing.Size(300, 1000);
            this.txtMess.MinimumSize = new System.Drawing.Size(15, 37);
            this.txtMess.Name = "txtMess";
            this.txtMess.ShowBorders = true;
            this.txtMess.Size = new System.Drawing.Size(80, 37);
            this.txtMess.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(262, 812);
            this.label1.MinimumSize = new System.Drawing.Size(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello";
            // 
            // InComming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.Avt);
            this.Controls.Add(this.txtMess);
            this.Name = "InComming";
            this.Size = new System.Drawing.Size(411, 218);
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            this.txtMess.ResumeLayout(false);
            this.txtMess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private Bunifu.UI.WinForms.BunifuPictureBox Avt;
        private Bunifu.UI.WinForms.BunifuPanel txtMess;
        private System.Windows.Forms.Label label1;
    }
}
