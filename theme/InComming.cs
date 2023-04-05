using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.theme
{
    public partial class InComming : UserControl
    {
        public InComming()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
            setAvt();
        }
        void setAvt()
        {

        }
        void AdjustHeight()
        {
            Avt.Location = new Point(4, 3);
            label1.Height = Utils.GetTextHeight(label1) + 10;
            txtMess.Width = label1.Top + txtMess.Top + label1.Width;
            this.Width = txtMess.Bottom + 10;
            txtMess.Height = label1.Height + 20;
            int X = 160 + txtMess.Width - 80;
            lblTime.Location = new Point(X, 60);
        }
    }
}
