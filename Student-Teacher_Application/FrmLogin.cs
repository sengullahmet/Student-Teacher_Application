using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Student_Teacher_Application
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-SA9H44E;Initial Catalog=ogretım_uygulama;Integrated Security=True");
        

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("select*from tbl_Notes where STDID=@p1",bgl);




            bgl.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmStudentNote frm = new FrmStudentNote();

            frm.numara = textBox1.Text;
            this.Hide();
            frm.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmTeacherForm fr=new frmTeacherForm();

            fr.Show();
            this.Hide();

        }
    }
}
