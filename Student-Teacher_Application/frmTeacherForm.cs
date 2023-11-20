using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Application
{
    public partial class frmTeacherForm : Form
    {
        public frmTeacherForm()
        {
            InitializeComponent();
        }

        private void btnclup_Click(object sender, EventArgs e)
        {
            Frm_Kulup fr = new Frm_Kulup();

            fr.Show();
            this.Hide();


        }

        private void btnlesson_Click(object sender, EventArgs e)
        {
            frmLessons fr=new frmLessons();

            fr.Show();
            this.Hide();


        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            frmStudent fr = new frmStudent();
            fr.Show();
            this.Hide();
        }

      

        private void btnexam_Click(object sender, EventArgs e)
        {
            FrmExamNotes fr = new FrmExamNotes();

            fr.Show();
            this.Hide();
            this.Hide();






        }

        private void pctReturn_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
            fr.Show();
            this.Hide();

        }
    }
}
