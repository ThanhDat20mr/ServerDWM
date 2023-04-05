
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

using SuperSimpleTcp;
using System.Runtime.InteropServices;
using TestChatMulti;
using Server.theme;
using System.Collections;

namespace Server
{
    public partial class fServer : Form
    {
        public static fServer instance;
        public fServer()
        {
            InitializeComponent();
            instance = this;
            
        }
        SimpleTcpServer server;

        string nonAvt = "D://DACN//TestChatMulti//Acc//user.png";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer("127.0.0.1", 9000);
            server.Start();
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            loadForm(new fDashboard());
            lbInfo.Text = "User:";
            loadAccount();
            timeDel.Start();
            
        }
        TestChatEntities con = new TestChatEntities();
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (server.IsListening)
            {
                string s = $"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}";
                string ip = e.IpPort;

                using (TestChatEntities db = new TestChatEntities())
                {
                    var acc = from c in db.Account.Where(p => p.ip == ip) select c.username;
                    string Usn = acc.FirstOrDefault();
                    Chatting me = db.Chatting.Find(Usn);
                    string ipmatch = me.ipMatch;
                    server.Send(ipmatch, s);
                }
            }

        }
        public int numCon = 0;
        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            lbNum.Invoke((MethodInvoker)delegate ()
            {
                numCon -= 1;
                lbNum.Text = numCon.ToString();
                using (TestChatEntities db = new TestChatEntities())
                {
                    var result = from c in db.Account.Where(p => p.ip == e.IpPort)

                                 select c.username;
                    Alert(e.IpPort + "\nDisconnected!", Form_Alert.enmType.Success);
                    string Usn = result.FirstOrDefault();
                    Account acc = db.Account.Find(Usn);
                    acc.ip = null;
                    db.SaveChanges();
                    pnlCenter.Controls.RemoveByKey(Usn);
                    pnlContent.Controls.Clear();
                }
            });
        }
       
        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            lbNum.Invoke((MethodInvoker)delegate ()
            {
                numCon += 1;
                lbNum.Text = numCon.ToString();
                using (TestChatEntities db = new TestChatEntities())
                {
                    var result = from c in db.Account.Where(p => p.ip == e.IpPort)
                                 
                                     select c.username;
                    Alert($"{e.IpPort} Connected!", Form_Alert.enmType.Success);
                    string Usn = result.FirstOrDefault();
                    Profile prf = db.Profile.Find(Usn);
                    var path = from c in db.Profile.Where(p => p.username == Usn)
                                 select c.avt;
                    byte[] Avt = path.FirstOrDefault();
                    addConection(Usn,prf.name,Avt);  
                }
            });

            
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        ArrayList arr = new ArrayList();
        void addConection(string usn,string mess,byte[] path)
        {

            XanderUI.XUIButton btnAcc = new XanderUI.XUIButton();
            pnlCenter.Controls.Add(btnAcc);
            btnAcc.BringToFront();
            btnAcc.Dock = DockStyle.Top;
            if (path != null)
            {
                btnAcc.ButtonImage = Utils.convertImage(path);
            }
            else
            {
                btnAcc.ButtonImage = new Bitmap(nonAvt);
            }

            btnAcc.ButtonText = mess;
            btnAcc.BackgroundColor = Color.DodgerBlue;
            btnAcc.TextColor = Color.White;
            btnAcc.ClickTextColor = Color.White;
            btnAcc.ClickBackColor = Color.RoyalBlue;
            btnAcc.Name = usn;
            btnAcc.Font = new Font("Microsoft Sans Serif", 12f);
            btnAcc.Click += BtnAcc_Click;




        }
        public void loadAccount()
        {
            if (lbInfo.Text == "Banned:")
            {
                pnlCenter.Controls.Clear();
                arr.Clear();
                var user_ban = from c in con.Account.Where(p => p.status == "B") select c.username;     //group c by c.username into g select g.Key;
                foreach (var rs in user_ban)
                {
                    arr.Add(rs);
                }
                for (int i = 0; i < arr.Count; i++)
                {
                    string username_ban = arr[i].ToString();
                    Profile prf = con.Profile.Find(username_ban);
                    addConection(username_ban, prf.name, prf.avt);
                }
                lbNum.Text = arr.Count.ToString();
            }
            if (lbInfo.Text == "User:")
            {
                pnlCenter.Controls.Clear();
                arr.Clear();
                var user = from c in con.Account.Where(p => p.status == "T") select c.username;     //group c by c.username into g select g.Key;
                foreach (var rs in user)
                {
                    arr.Add(rs);
                }
                for (int i = 0; i < arr.Count; i++)
                {
                    string username = arr[i].ToString();
                    Profile prf = con.Profile.Find(username);
                    addConection(username, prf.name, prf.avt);
                }
                lbNum.Text = arr.Count.ToString();
            }
            if (lbInfo.Text == "Reports:")
            {
                pnlCenter.Controls.Clear();
                arr.Clear();
                var user = from c in con.Reports group c by c.username_rp into g select g.Key;
                foreach (var rs in user)
                {
                    arr.Add(rs);
                }
                for (int i = 0; i < arr.Count; i++)
                {
                    string username = arr[i].ToString();
                    Profile prf = con.Profile.Find(username);
                    addConection(username, prf.name, prf.avt);
                }
                lbNum.Text = arr.Count.ToString();
            }
        }
        public void setInfo()
        {
            lbInfo.Text = "Banned:";
        }
        public XanderUI.XUIButton Usn1 = null;
        private void BtnAcc_Click(object sender, EventArgs e)
        {
            XanderUI.XUIButton btnAcc = (XanderUI.XUIButton)sender;
            Usn1 = btnAcc;
            Usn1.Name = btnAcc.Name;
            loadForm(new fMenu());
        }
        private Form currentChildForm;
        public void loadForm(Form childForm)
        {
            pnlContent.Controls.Clear();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        void loadDelAccount()
        {
            using (TestChatEntities db = new TestChatEntities())
            {
                var acc = from c in db.Account.Where(p=>p.status=="R") select c.username;
                foreach(var rs in acc)
                {
                    arr.Add(rs);
                }
                for(int i = 0; i < arr.Count; i++)
                {

                    string usn_check = arr[i].ToString();
                    Profile prf = db.Profile.Find(usn_check);
                    Connection conn = db.Connection.Find(usn_check);
                    Chatting chat = db.Chatting.Find(usn_check);
                    Account acc1 = db.Account.Find(usn_check);
                    if ( prf.bio == DateTime.Now.ToShortDateString().ToString()) //acc1.status == "R" &&
                    {
                        db.Profile.Remove(prf);
                        db.Account.Remove(acc1);
                        db.Connection.Remove(conn);
                        db.Chatting.Remove(chat);
                        db.SaveChanges();
                    }


                }
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            loadForm(new fMenu());
        }

        private void timeDel_Tick(object sender, EventArgs e)
        {
            loadDelAccount();
            timeDel.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbInfo.Text = "User:";
            loadAccount();
            loadForm(new fDashboard());
        }
    }
}
