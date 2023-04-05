
namespace Server.theme
{
    partial class fReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.pnlLetter = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnBan = new XanderUI.XUIButton();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLetter
            // 
            this.pnlLetter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLetter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLetter.Location = new System.Drawing.Point(0, 0);
            this.pnlLetter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLetter.Name = "pnlLetter";
            this.pnlLetter.Size = new System.Drawing.Size(379, 569);
            this.pnlLetter.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnBan);
            this.pnlContent.Controls.Add(this.txtContent);
            this.pnlContent.Controls.Add(this.lbFrom);
            this.pnlContent.Controls.Add(this.lbTo);
            this.pnlContent.Controls.Add(this.lbTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(379, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(844, 569);
            this.pnlContent.TabIndex = 1;
            // 
            // btnBan
            // 
            this.btnBan.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.btnBan.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnBan.ButtonImage")));
            this.btnBan.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnBan.ButtonText = "  BAN";
            this.btnBan.ClickBackColor = System.Drawing.Color.Black;
            this.btnBan.ClickTextColor = System.Drawing.Color.Black;
            this.btnBan.CornerRadius = 15;
            this.btnBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBan.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btnBan.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnBan.HoverTextColor = System.Drawing.Color.White;
            this.btnBan.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnBan.Location = new System.Drawing.Point(684, 482);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(148, 50);
            this.btnBan.TabIndex = 2;
            this.btnBan.TextColor = System.Drawing.Color.Black;
            this.btnBan.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBan.Visible = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.White;
            this.txtContent.Location = new System.Drawing.Point(136, 150);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(541, 382);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            this.txtContent.Visible = false;
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.ForeColor = System.Drawing.SystemColors.Control;
            this.lbFrom.Location = new System.Drawing.Point(29, 102);
            this.lbFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(65, 36);
            this.lbFrom.TabIndex = 0;
            this.lbFrom.Text = "From:";
            this.lbFrom.Visible = false;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTo.Location = new System.Drawing.Point(672, 102);
            this.lbTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(41, 36);
            this.lbTo.TabIndex = 0;
            this.lbTo.Text = "To:";
            this.lbTo.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MTO Mysti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitle.Location = new System.Drawing.Point(364, 23);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(112, 69);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "None";
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1223, 569);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlLetter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fReport";
            this.Text = "fReport";
            this.Load += new System.EventHandler(this.fReport_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLetter;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private XanderUI.XUIButton btnBan;
    }
}