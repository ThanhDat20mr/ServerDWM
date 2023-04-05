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
    public partial class fAnalytics : Form
    {
        public static fAnalytics instance;
        public fAnalytics()
        {
            InitializeComponent();
            instance = this;
            Usn = fMenu.instance.usn_search.Text;
        }
        static string Usn;
        TestChatEntities con = new TestChatEntities();
        void loadForm()
        {
            getMatch();
            var rp = from c in con.Reports.Where(p => p.username_rp == Usn) select c;
            var news = from c in con.News.Where(p => p.username == Usn) select c;
            int numRp = rp.Count();
            Profile prf = con.Profile.Find(Usn);
            picAvt.Image = Utils.convertImage(prf.avt);
            lbName.Text = prf.name;
            lbUsn.Text = prf.username;
            numReport.Text = numRp.ToString();
            numMatching.Text = numMatch.ToString();
            numNews.Text = news.Count().ToString();
        }
        ArrayList arr = new ArrayList();
        int numMatch;
        int getMatch()
        {
            numMatch = 0;
            using (TestChatEntities db = new TestChatEntities())
            {
                var rs = from c in db.Connection.Where(p => p.username == Usn)
                         select c.love;
                string s = rs.FirstOrDefault().ToString();
                var rs1 = from c in db.Profile.Where(p => s.Contains(p.username))
                          select c.username;
                foreach (var rs2 in rs1)
                {
                    arr.Add(rs2);
                }
                for (int i = 0; i < arr.Count; i++)
                {
                    string userMatch = arr[i].ToString();
                    Connection match = db.Connection.Find(userMatch);
                    string loveMatch = match.love;

                    if (loveMatch.Contains(Usn))
                    {
                        numMatch++;
                    }
                }
            }
            return numMatch;
        }

        private void fAnalytics_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
