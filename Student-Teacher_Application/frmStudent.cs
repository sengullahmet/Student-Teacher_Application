using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Application
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        //datasetTableAdapters.DataTable1TableAdapter ds = new datasetTableAdapters.DataTable1TableAdapter();

        datasetTableAdapters.DataTable1TableAdapter ds = new datasetTableAdapters.DataTable1TableAdapter ();

        private void pctReturn_Click(object sender, EventArgs e)
        {
            
            frmTeacherForm fr = new frmTeacherForm();
            fr.Show();
            this.Hide();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeacherForm fr = new frmTeacherForm();
            fr.Show();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            dgwStudent.DataSource = ds.listStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string g = "";

            if (rdbMale.Checked==true)
            {
                g = "Erkek";
            }
            if (rdbFemale.Checked == true)
            {
                g = "Kız";
            }
                        
            ds.studentAdd(txtname.Text,txtSurname.Text,byte.Parse(cmbClup.Text),g);
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-SA9H44E;Initial Catalog=ogretım_uygulama;Integrated Security=True");


            bgl.Open();

             SqlCommand kmt = new SqlCommand("select*from tbl_clp",bgl);
             SqlDataAdapter da = new SqlDataAdapter(kmt);
             DataTable dt = new DataTable();

             da.Fill(dt);
             cmbClup.DisplayMember = "CLUPNAME";
             cmbClup.ValueMember = "CLUPİD";
             cmbClup.DataSource= dt;


          





           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ds.stdDeleted(int.Parse(txtıd.Text));
            dgwStudent.DataSource = ds.listStudent();
        }

        private void dgwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dgwStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgwStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dgwStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            string c= dgwStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbClup.SelectedText = c;

            






        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgwStudent.DataSource = ds.StdntBrıng(txtSearch.Text);

            
        }
    }
}
