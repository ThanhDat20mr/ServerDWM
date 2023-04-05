using Server;
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

namespace TestChatMulti
{
    public partial class fMactching : Form
    {
        public fMactching instance;
        public fMactching()
        {
            InitializeComponent();
            instance = this;

        }
        public string Usn = fMenu.instance.usn_search.Text;
        TestChatEntities con = new TestChatEntities();
        public static string usnlove;
        public static string path = "D://DACN/TestChatMulti//Acc//matchEnd.jpg";
        void loadAcc()
        {
            Profile prf = con.Profile.Find(Usn);
            lbName.Text = prf.name;
            DateTime dt = (DateTime)prf.DoB;
            lbAge.Text = getAge(dt).ToString();
            if (prf.bio == null)
                lbBio.Text = "Chưa có giới thiệu";
            else
                lbBio.Text = prf.bio;
            if (prf.education == null)
            {
                picEdu.Visible = false;
                lbEdu.Visible = false;
            }
            else
                lbEdu.Text = prf.education;
            if (prf.height == null)
            {
                picHeight.Visible = false;
                lbHeight.Visible = false;
            }
            else
                lbHeight.Text = prf.height + "cm";
            if (prf.location == null)
            {
                picLocation.Visible = false;
                lbLocation.Visible = false;
            }
            else
                lbLocation.Text = prf.location;


            addPic(Usn);
            pics.Image = imageList1.Images[0];

        }
            

       
       
        int getAge(DateTime dob)
        {
            DateTime td = DateTime.Today;
            int age = td.Year - dob.Year;
            if (dob > td.AddYears(-age))
                age--;
            return age;
        }
        private void fMactching_Load(object sender, EventArgs e)
        {
            loadAcc();
        }
            
        void addPic(string usnlove)
        {
            Profile prf = con.Profile.Find(usnlove);
            if (prf.pic1 != null)
                imageList1.Images.Add(Utils.convertImage(prf.pic1));
            if (prf.pic2 != null)
                imageList1.Images.Add(Utils.convertImage(prf.pic2));
            if (prf.pic3 != null)
                imageList1.Images.Add(Utils.convertImage(prf.pic3));
            if (prf.pic4 != null)
                imageList1.Images.Add(Utils.convertImage(prf.pic4));
            if (prf.pic5 != null)
                imageList1.Images.Add(Utils.convertImage(prf.pic5));
        }
        int count = -1;
        private void pics_Click(object sender, EventArgs e)
        {
            int n = imageList1.Images.Count;
            if (count < n)
                count++;
            if (count == n)
            {
                count = 0;
                pics.Image = imageList1.Images[count];
            }
            else
                pics.Image = imageList1.Images[count];
        }




    }
}
