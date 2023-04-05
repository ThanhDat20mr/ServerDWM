using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Server;

namespace TestChatMulti
{
    public partial class fProfile : Form
    {
        public static fProfile instance;
        public fProfile()
        {
            InitializeComponent();
            instance = this;
            Usn = fMenu.instance.usn_search.Text;
        }
        public static string Usn ;
        Image pics;
        
        TestChatEntities con = new TestChatEntities();
        public static string path= "D://DACN//TestChatMulti//Acc//" + Usn+"//avt//"+Usn+".png";
        public static string pathPic = "D://DACN//TestChatMulti//Acc//" + Usn + "//pics//";
        public static string nonPic = "D://DACN//icons//create.png";
        public static string bin = "D://DACN//TestChatMulti//Acc//bin//";
        public string nonAvt = "D://DACN//TestChatMulti//Acc//user.png";
        OpenFileDialog img = new OpenFileDialog();
        private void picAvt_Click(object sender, EventArgs e)
        {
            if (img.ShowDialog() == DialogResult.OK)
            {
                setAvt();
            }
        }
        void resetAvt()
        {
            picAvt.Image = new Bitmap(nonAvt);
            using (TestChatEntities db = new TestChatEntities())
            {
                Profile prf = db.Profile.Find(Usn);
                prf.avt = null;
                db.SaveChanges();

            }
        }
        void setAvt()
        {
            picAvt.Image = new Bitmap(img.FileName);
            pics = Image.FromFile(img.FileName);
            SaveFileDialog pic = new SaveFileDialog();
            pic.Filter = "JPG(*.png)|*.png";
            pic.RestoreDirectory = true;
            //pics.Save(path);
            MessageBox.Show("Saved!");
            using (TestChatEntities db = new TestChatEntities())
            {
                Profile prf = db.Profile.Find(Usn);
                prf.avt = Utils.convertByte(img.FileName);
                db.SaveChanges();
            }
            //fHome.instance.loadAvt();
        }
        private byte[] convertByte(string path)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(path);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        private Image convertImage(byte[] photo)
        {
            Image newImage;
            using(MemoryStream ms = new MemoryStream(photo,0,photo.Length))
            {
                ms.Write(photo, 0, photo.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }
        void uploadPic(PictureBox picb)
        {
            if (img.ShowDialog() == DialogResult.OK)
            {
                picb.Image = new Bitmap(img.FileName);
                pics = Image.FromFile(img.FileName);
                SaveFileDialog pic = new SaveFileDialog();
                pic.Filter = "PNG(*.png)|*.png";
                pic.RestoreDirectory = true;               
                using (TestChatEntities db = new TestChatEntities())
                {
                    Profile prf = db.Profile.Find(Usn);
                    if (prf.pic1 == null)
                        prf.pic1 = convertByte(img.FileName);
                    else if (prf.pic2 == null)
                        prf.pic2 = convertByte(img.FileName);
                    else if (prf.pic3 == null)
                        prf.pic3 = convertByte(img.FileName);
                    else if (prf.pic4 == null)
                        prf.pic4 = convertByte(img.FileName);
                    else if (prf.pic5 == null)
                        prf.pic5 = convertByte(img.FileName);
                    db.SaveChanges();
                }
                loadPics();


            }
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        void loadAvt()
        {
            
            using (TestChatEntities db = new TestChatEntities())
            {
                Profile prf = db.Profile.Find(Usn);
                if (prf.avt != null)
                {
                    
                    picAvt.Image = Utils.convertImage(prf.avt);
                    
                }
                else
                {
                    picAvt.Image = new Bitmap(nonAvt);
                }
                txtName.Text = prf.name;
                txtAge.Text = prf.DoB.ToString();
                cbxEdu.Text = prf.education;
                cbxLocation.Text = prf.location;
                txtBio.Text = prf.bio;
                if (prf.sexsual == true)
                {
                    btnMale.Checked = true;
                }
                if (prf.sexsual == false)
                    btnFemale.Checked = true;

            }
        }
        
        void checkPic(PictureBox picb)
        {
            if (picb.Image == null)
            {
                picb.Visible = true;
                picb.Image = new Bitmap(nonPic);
                picb.BorderStyle = BorderStyle.FixedSingle;
            }

            

        }
        void checkAll()
        {
            checkPic(pic1);
            checkPic(pic2);
            checkPic(pic3);
            checkPic(pic4);
            checkPic(pic5);
        }
        void loadPics()
        {
            using (TestChatEntities db = new TestChatEntities())
                {
                    Profile prf = db.Profile.Find(Usn);
                    if (prf.pic1 != null)
                    {
                        pic1.Enabled = false;
                        pic1.Image = convertImage(prf.pic1);
                        checkPic(pic2);
                }
                    if (prf.pic2 != null)
                    {
                        pic2.Visible = true;
                        pic2.Enabled = false;
                        btnDel2.Visible = true;
                        pic2.Image = convertImage(prf.pic2);
                        checkPic(pic3);
                    } 
                    if (prf.pic3 != null)
                    {
                        pic3.Visible = true;
                        pic3.Enabled = false;
                        btnDel3.Visible = true;
                        pic3.Image = convertImage(prf.pic3);
                        checkPic(pic4);
                    }
                    if (prf.pic4 != null)
                        {
                            pic4.Visible = true;
                            pic4.Enabled = false;
                            btnDel4.Visible = true;
                            pic4.Image = convertImage(prf.pic4);
                            checkPic(pic5);
                }
                    if (prf.pic5 != null)
                    {
                            pic5.Visible = true ;
                            pic5.Enabled = false;
                            btnDel5.Visible = true;
                            pic5.Image = convertImage(prf.pic5);
                            checkAll();
                    }
                }
        }
        private void fSetting_Load(object sender, EventArgs e)
        {
            loadAvt();
            loadPics();
        }
        void closeButton()
        {
            btnSave.Visible = false;
            txtName.Enabled = false;
            txtBio.Enabled = false;
            txtAge.Enabled = false;
            btnFemale.Enabled = false;
            btnMale.Enabled = false;
            cbxEdu.Enabled = false;
            cbxLocation.Enabled = false;
            txtHeight.Enabled = false;
        }
        void openButton()
        {
            btnSave.Visible = true;
            txtName.Enabled = true;
            txtBio.Enabled = true;
            txtAge.Enabled = true;
            btnFemale.Enabled = true;
            btnMale.Enabled = true;
            cbxEdu.Enabled = true;
            cbxLocation.Enabled = true;
            txtHeight.Enabled = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            openButton();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            uploadPic(pic1);
            loadPics();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            uploadPic(pic2);
            loadPics();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            uploadPic(pic3);
            loadPics();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            uploadPic(pic4);
            loadPics();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            uploadPic(pic5);
            loadPics();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            pic1.Image = new Bitmap(nonPic);
            Profile prf = con.Profile.Find(Usn);
            prf.pic1 = null;
            con.SaveChanges();
            loadPics();
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            pic2.Image = new Bitmap(nonPic);
            Profile prf = con.Profile.Find(Usn);
            prf.pic2 = null;
            con.SaveChanges();
            loadPics();
        }

        private void btnDel5_Click(object sender, EventArgs e)
        {
            pic5.Image = new Bitmap(nonPic);
            Profile prf = con.Profile.Find(Usn);
            prf.pic5 = null;
            con.SaveChanges();
            loadPics();
        }

        private void btnDel4_Click(object sender, EventArgs e)
        {
            pic4.Image = new Bitmap(nonPic);
            Profile prf = con.Profile.Find(Usn);
            prf.pic4 = null;
            con.SaveChanges();
            loadPics();
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            pic3.Image = new Bitmap(nonPic);
            Profile prf = con.Profile.Find(Usn);
            prf.pic3 = null;
            con.SaveChanges();
            loadPics();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(TestChatEntities db = new TestChatEntities())
            {
                Profile prf = db.Profile.Find(Usn);
                prf.name = txtName.Text;
                prf.bio = txtBio.Text;
                prf.DoB = txtAge.Value;
                prf.height = Convert.ToInt32(txtHeight.Text);
                if (btnMale.Checked == true)
                    prf.sexsual = true;
                if (btnFemale.Checked == true)
                    prf.sexsual = false;
                if (cbxEdu.Text==null||cbxEdu.Text=="Không")
                    prf.education = null;
                if(cbxEdu.Text !="Không")
                    prf.education = cbxEdu.Text;
                if (cbxLocation.Text==null||cbxLocation.Text=="Không")
                    prf.location = null;
                if (cbxEdu.Text != "Không")
                    prf.location = cbxLocation.Text;
                db.SaveChanges();
            }
            closeButton();
            MessageBox.Show("Update successfully!");
        }
    }
}
