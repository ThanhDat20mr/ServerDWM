
namespace Server.theme
{
    partial class OutGoing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutGoing));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtMess = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtMess.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(225, 812);
            this.label1.MinimumSize = new System.Drawing.Size(0, 28);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hello";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(113, 26);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.MaximumSize = new System.Drawing.Size(225, 812);
            this.lblTime.MinimumSize = new System.Drawing.Size(0, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new System.Windows.Forms.Padding(4);
            this.lblTime.Size = new System.Drawing.Size(39, 28);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Hello";
            // 
            // txtMess
            // 
            this.txtMess.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMess.BackgroundImage")));
            this.txtMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMess.BorderColor = System.Drawing.Color.Transparent;
            this.txtMess.BorderRadius = 40;
            this.txtMess.BorderThickness = 1;
            this.txtMess.Controls.Add(this.label1);
            this.txtMess.Location = new System.Drawing.Point(159, 3);
            this.txtMess.Name = "txtMess";
            this.txtMess.ShowBorders = true;
            this.txtMess.Size = new System.Drawing.Size(70, 41);
            this.txtMess.TabIndex = 9;
            // 
            // OutGoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtMess);
            this.Name = "OutGoing";
            this.Size = new System.Drawing.Size(386, 54);
            this.DockChanged += new System.EventHandler(this.OutGoing_DockChanged);
            this.txtMess.ResumeLayout(false);
            this.txtMess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private Bunifu.UI.WinForms.BunifuPanel txtMess;
    }
}
