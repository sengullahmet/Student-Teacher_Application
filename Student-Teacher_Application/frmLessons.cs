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
    public partial class frmLessons : Form
    {
        public frmLessons()
        {
            InitializeComponent();
        }
        datasetTableAdapters.tbl_lessonsTableAdapter ds=new datasetTableAdapters.tbl_lessonsTableAdapter();
        private void frmLessons_Load(object sender, EventArgs e)
        {
            dgwLessons.DataSource = ds.lessonList();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            dgwLessons.DataSource = ds.lessonList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ds.lessAdd(txtname.Text);
            MessageBox.Show("Successfull Add !!","İnformation",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dgwLessons.DataSource = ds.lessonList();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeacherForm fr = new frmTeacherForm();
            fr.Show();
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            ds.lessUpdated(txtname.Text, byte.Parse(txtıd.Text));
            MessageBox.Show("Successfull Updated !!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwLessons.DataSource = ds.lessonList();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ds.lesDeleted(byte.Parse(txtıd.Text));
            MessageBox.Show("Successfull Remove !!", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgwLessons.DataSource=ds.lessonList();
            

        }

        private void dgwLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dgwLessons.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgwLessons.Rows[e.RowIndex].Cells[1].Value.ToString();


        }

        private void pctReturn_Click(object sender, EventArgs e)
        {
            frmTeacherForm frm = new frmTeacherForm();

            frm.Show();
            this.Hide();




        }
    }
}
