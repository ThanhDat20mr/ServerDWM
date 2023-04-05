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
    public partial class fConnection : UserControl
    {
        public fConnection()
        {
            InitializeComponent();
        }
        public Image image
        {
            get
            {
                return picAvt.Image;
            }
            set
            {
                picAvt.Image = new Bitmap(value);
            }
        }
        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value; 
                //AdjustHeight();
            }
        }
        void location()
        {
            int count = Utils.GetTextCount(label1);
            int X_min = 341; int Y = 2;
            int X_max = 153; int X = 0;
            X = 341 - (5 * count);
            if (X <= X_max)
            {
                X = X_max;
                txtMess.Location = new Point(X, Y);
            }
            else
            {
                txtMess.Location = new Point(X, Y);
            }

        }
        void AdjustHeight()
        {
            location();
            label1.Height = Utils.GetTextHeight(label1) + 10;
            txtMess.Width = label1.Top + txtMess.Top + label1.Width;
            this.Width = txtMess.Bottom + 10;
            txtMess.Height = label1.Height + 15;
            txtMess.Width = label1.Width + 15;
            Utils.GetText(label1);
            int X = txtMess.Location.X - 75;

        }

        private void label1_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
