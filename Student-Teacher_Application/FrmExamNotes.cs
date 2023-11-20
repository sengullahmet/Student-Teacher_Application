using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Teacher_Application
{
    public partial class FrmExamNotes : Form
    {
        public FrmExamNotes()
        {
            InitializeComponent();
        }
        datasetTableAdapters.tbl_NotesTableAdapter ds=new datasetTableAdapters.tbl_NotesTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                int x = Convert.ToInt16(txtId.Text);

                dgwNotes.DataSource=ds.GetLessons(x);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Dont Null Id Text !!");
                DialogResult = DialogResult.OK;
             

            }

            






        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SA9H44E;Initial Catalog=ogretım_uygulama;Integrated Security=True");


        void clear()
        {
            txtId.Clear();
            cmbName.Text = "";
            txtFrstExam.Clear();
            txtScndExam.Clear();
            txtThırdExam.Clear();
            txtProject.Clear();
            txtAverage.Clear();
            txtState.Clear();

        }
        private void FrmExamNotes_Load(object sender, EventArgs e)
        {
            bgl.Open();


            SqlCommand kmt = new SqlCommand("select *from tbl_lessons",bgl);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbName.DisplayMember = "LESNAME";
            cmbName.ValueMember = "LESID";
            cmbName.DataSource = dt;




            










            bgl.Close();





        }
        int noteId;
        private void dgwNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noteId= int.Parse(dgwNotes.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtId.Text = dgwNotes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtFrstExam.Text = dgwNotes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtScndExam.Text = dgwNotes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtThırdExam.Text = dgwNotes.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProject.Text = dgwNotes.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAverage.Text = dgwNotes.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtState.Text = dgwNotes.Rows[e.RowIndex].Cells[8].Value.ToString();



        }
        int exam1, exam2, exam3, project;
        double average;

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pctReturn_Click(object sender, EventArgs e)
        {
            frmTeacherForm frm=new frmTeacherForm();
            frm.Show();
            this.Hide();
        }

        bool state;

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3,project ;
            double average;
            

            exam1 = Convert.ToUInt16(txtFrstExam.Text);
            exam2 = Convert.ToUInt16(txtScndExam.Text);
            exam3 = Convert.ToInt16(txtThırdExam.Text);
            project = Convert.ToInt16(txtProject.Text);


            average = (exam1 + exam2 + exam3 + project) / 4;

            txtAverage.Text=average.ToString();

            if (average>=50)
            {
                txtState.Text = " True ";
                state = true;
            }
            else
            {
                txtState.Text = " False ";
                state = false;
            }
            




        }
      
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bgl.Open();


            SqlCommand kmt = new SqlCommand("update tbl_Notes set STDID=@p1,EXAM1=@p2,EXAM2=@p3,EXAM3=@p4,PROJECT=@p5,AVERAGE=@p6,STATUSS=@p7 where NOTEID=@p0",bgl);

            kmt.Parameters.AddWithValue("@p0", noteId.ToString());
            kmt.Parameters.AddWithValue("@p1",txtId.Text);
            kmt.Parameters.AddWithValue("@p2", txtFrstExam.Text);
            kmt.Parameters.AddWithValue("@p3", txtScndExam.Text);
            kmt.Parameters.AddWithValue("@p4", txtThırdExam.Text);
            kmt.Parameters.AddWithValue("@p5", txtProject.Text);
            kmt.Parameters.AddWithValue("@p6", txtAverage.Text);
            kmt.Parameters.AddWithValue("@p7", (txtState.Text));

            kmt.ExecuteNonQuery();
            MessageBox.Show("Update Is A Successfull !!","Information",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            bgl.Close();

            



        }
    }
}
