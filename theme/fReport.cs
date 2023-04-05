using System;
using System.Collections;
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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }
        TestChatEntities con = new TestChatEntities();
        ArrayList arr = new ArrayList();
        string Usn = fMenu.instance.usn_search.Text;
        void loadLetter()
        {
            pnlLetter.Controls.Clear();
            arr.Clear();
            var user_rp = from c in con.Reports.Where(p => p.username_rp == Usn) select c.username;     //group c by c.username into g select g.Key;
            foreach (var rs in user_rp)
            {
                arr.Add(rs);
            }
            for(int i = 0; i < arr.Count; i++)
            {
                string username_rp = arr[i].ToString();
                loadItemUser(username_rp);
            }
            
        }
        void loadItemUser(string usn)
        {
            var bubble = new theme.reportLetter();
            pnlLetter.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.user = usn;
            bubble.Name = usn;
            bubble.Cursor = Cursors.Hand;
            bubble.Click += Bubble_Click;
        }

        private void Bubble_Click(object sender, EventArgs e)
        {
            ArrayList arr1 = new ArrayList();
            theme.reportLetter f = (theme.reportLetter)sender;
            lbTitle.Text = "Letter";
            setVis();
            lbTo.Text ="To: " +Usn;
            lbFrom.Text ="From: " +f.Name;
            using(TestChatEntities db  = new TestChatEntities())
            {
                var rp = from c in db.Reports.Where(p => p.username == f.Name && p.username_rp == Usn) select c.Note;
                txtContent.Text = rp.FirstOrDefault().ToString();
            }
            

        }
        void setVis()
        {
            lbTo.Visible = true;
            lbFrom.Visible = true;
            txtContent.Visible = true;
            btnBan.Visible = true;
        }
        void setBlind()
        {
            lbTo.Visible = false;
            lbFrom.Visible = false;
            txtContent.Visible = false;
            btnBan.Visible = false;
        }
        private void fReport_Load(object sender, EventArgs e)
        {
            loadLetter();
            lbTitle.Text = "None";
            setBlind();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            Utils.Alert("Banned!",Form_Alert.enmType.Success);
            /*var numRp = from c in con.Reports.Where(p =>p.username_rp == Usn) select c.NumVote;
            int t = numRp.FirstOrDefault();
            Reports rp = con.Reports.Find(t);
            con.Reports.Remove(rp);*/
            Account acc = con.Account.Find(Usn);
            acc.status = "B";
            con.SaveChanges();
        }
    }
}
