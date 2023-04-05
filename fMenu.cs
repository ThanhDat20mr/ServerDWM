using Server.theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestChatMulti;

namespace Server
{
    public partial class fMenu : Form
    {
        public static fMenu instance;
        public fMenu()
        {
            InitializeComponent();
            instance = this;
            lbUsername.Text = fServer.instance.Usn1.Name;
            checkBlock();
            //lbUsername.Text = usn_search.Text;
        }
        public TextBox usn_search= new TextBox();
        TestChatEntities con = new TestChatEntities();
        void checkBlock()
        {
            Account acc = con.Account.Find(lbUsername.Text);
            if (acc.status == "B")
                btnUnBlock.Visible = true;
            else
                btnUnBlock.Visible = false;
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            fMactching f = new fMactching();
            f.FormBorderStyle = FormBorderStyle.Sizable;
            f.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            fProfile f = new fProfile();
            f.FormBorderStyle = FormBorderStyle.Sizable;
            f.ShowDialog();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            fAnalytics f = new fAnalytics();
            f.FormBorderStyle = FormBorderStyle.Sizable;
            f.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fReport f = new fReport();
            f.ShowDialog();
        }

        private void btnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                setError();
            }
        }
        void setError()
        {
            using(TestChatEntities db = new TestChatEntities())
            {
                if (db.Account.Where(p => p.username.Equals(btnSearch.Text)).Count() > 0)
                {
                    usn_search.Text = btnSearch.Text;
                    lbUsername.Text = btnSearch.Text;
                    errorProvider1.Clear();
                }
                else
                    errorProvider1.SetError(btnSearch, "Invalid username!");
            }
            
        }
        private void fMenu_Load(object sender, EventArgs e)
        {
            usn_search.Text = fServer.instance.Usn1.Name;
        }

        private void btnUnBlock_Click(object sender, EventArgs e)
        {
            using(TestChatEntities db = new TestChatEntities())
            {
                Account acc = db.Account.Find(lbUsername.Text);
                acc.status = "F";
                db.SaveChanges();
            }
            btnUnBlock.Visible = false;
            fServer.instance.loadAccount();
            Utils.Alert("UnBlock successfully!", Form_Alert.enmType.Success);
        }
    }
}
