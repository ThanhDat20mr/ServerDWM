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
    public partial class reportLetter : UserControl
    {
        public reportLetter()
        {
            InitializeComponent();
        }
        public string user
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
    }
}
