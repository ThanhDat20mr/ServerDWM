
namespace Server.theme
{
    partial class fConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConnection));
            this.picAvt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtMess = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.txtMess.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAvt
            // 
            this.picAvt.AllowFocused = false;
            this.picAvt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAvt.AutoSizeHeight = true;
            this.picAvt.BorderRadius = 18;
            this.picAvt.Image = ((System.Drawing.Image)(resources.GetObject("picAvt.Image")));
            this.picAvt.IsCircle = true;
            this.picAvt.Location = new System.Drawing.Point(32, 7);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(36, 36);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvt.TabIndex = 1;
            this.picAvt.TabStop = false;
            this.picAvt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // txtMess
            // 
            this.txtMess.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.txtMess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMess.BackgroundImage")));
            this.txtMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtMess.BorderColor = System.Drawing.Color.Transparent;
            this.txtMess.BorderRadius = 3;
            this.txtMess.BorderThickness = 1;
            this.txtMess.Controls.Add(this.label1);
            this.txtMess.Controls.Add(this.picAvt);
            this.txtMess.Location = new System.Drawing.Point(0, 2);
            this.txtMess.Name = "txtMess";
            this.txtMess.ShowBorders = true;
            this.txtMess.Size = new System.Drawing.Size(224, 51);
            this.txtMess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.DockChanged += new System.EventHandler(this.label1_DockChanged);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtMess);
            this.Name = "Connection";
            this.Size = new System.Drawing.Size(498, 56);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.txtMess.ResumeLayout(false);
            this.txtMess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox picAvt;
        private Bunifu.UI.WinForms.BunifuPanel txtMess;
        private System.Windows.Forms.Label label1;
    }
}
