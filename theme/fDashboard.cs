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
    public partial class fDashboard : Form
    {
        public fDashboard()
        {
            InitializeComponent();
        }
        TestChatEntities con = new TestChatEntities();
        void loadDashboard()
        {
            var all_acc = from c in con.Account select c;
            var all_news = from c in con.News select c;
            var active = from c in con.Account.Where(p => p.status == "T") select c;
            var ban = from c in con.Account.Where(p => p.status == "B") select c;
            var rp = from c in con.Reports select c;
            float ac = active.Count() * 100;
            float all = all_acc.Count();
            float b = ban.Count() * 100;
            float perActive = ac / (all - b / 100);
            numActive.Text = active.Count().ToString() + "/" + (all - b / 100);
            circleActive.Percentage = (int)perActive;
            numBan.Text = ban.Count().ToString() + "/" + all;
            float perBan = b / all;
            circleBan.Percentage = (int)perBan;
            numNews.Text = all_news.Count().ToString();
            numReport.Text = rp.Count().ToString();
        }
        private void fDashboard_Load(object sender, EventArgs e)
        {
            loadDashboard();
        }

        private void pnlReport_Click(object sender, EventArgs e)
        {
            fServer.instance.lbInfo.Text = "Reports:";
            fServer.instance.loadAccount();
        }

        private void pnlBan_Click(object sender, EventArgs e)
        {
            fServer.instance.setInfo();
            fServer.instance.loadAccount();
        }

        private void pnlActive_Click(object sender, EventArgs e)
        {
            fServer.instance.lbInfo.Text = "User:";
            fServer.instance.loadAccount();
        }
    }
}
