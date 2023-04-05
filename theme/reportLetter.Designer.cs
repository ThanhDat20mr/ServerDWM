
namespace Server.theme
{
    partial class reportLetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportLetter));
            this.lbName = new System.Windows.Forms.Label();
            this.picLetter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbName.Location = new System.Drawing.Point(92, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 24);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // picLetter
            // 
            this.picLetter.Image = ((System.Drawing.Image)(resources.GetObject("picLetter.Image")));
            this.picLetter.Location = new System.Drawing.Point(3, 3);
            this.picLetter.Name = "picLetter";
            this.picLetter.Size = new System.Drawing.Size(70, 66);
            this.picLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLetter.TabIndex = 0;
            this.picLetter.TabStop = false;
            // 
            // reportLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picLetter);
            this.Name = "reportLetter";
            this.Size = new System.Drawing.Size(285, 75);
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLetter;
        private System.Windows.Forms.Label lbName;
    }
}
