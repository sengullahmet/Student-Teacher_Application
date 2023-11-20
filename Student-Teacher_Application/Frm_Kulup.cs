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
using System.Linq.Expressions;

namespace Student_Teacher_Application
{
    public partial class Frm_Kulup : Form
    {
        public Frm_Kulup()
        {
            InitializeComponent();
        }

        void listing()
        {
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_clp", bgl);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgwClup.DataSource = dt;
        }



        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SA9H44E;Initial Catalog=ogretım_uygulama;Integrated Security=True");
        private void Frm_Kulup_Load(object sender, EventArgs e)
        {


           





            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtıd.Text = dgwClup.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dgwClup.Rows[e.RowIndex].Cells[1].Value.ToString();  














            

                




        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            listing();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bgl.Open();

            SqlCommand kmt = new SqlCommand("insert into tbl_clp (CLUPNAME) values(@p1)",bgl);
            kmt.Parameters.AddWithValue("@p1",txtname.Text);
            kmt.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Successful Add From Database !!","İnformation",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            listing();



            




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are Your Sure Form is Closing ?", "İnformation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                frmTeacherForm fr = new frmTeacherForm();
                fr.Show();
            }
            else
            {
                Frm_Kulup frm=new Frm_Kulup();
                frm.Show();

            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pctExit.BackColor = Color.Red;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pctExit.BackColor = Color.Transparent;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bgl.Open();

            SqlCommand kmt = new SqlCommand("delete  from tbl_clp where CLUPİD=@p1", bgl);
            kmt.Parameters.AddWithValue("@p1", txtıd.Text);
            kmt.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Successfull Deleted !!", "İnformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            listing();
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("update tbl_clp set CLUPNAME=@p2 where CLUPİD=@p1",bgl);

            kmt.Parameters.AddWithValue("@p1",txtıd.Text);
            kmt.Parameters.AddWithValue("@p2", txtname.Text);
            kmt.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Successfull Updated !!", "İnformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            listing();











        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmTeacherForm frm = new frmTeacherForm();

            frm.Show();
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pctReturn.BackColor = Color.Green;
        }

        private void pctReturn_MouseLeave(object sender, EventArgs e)
        {
            pctReturn.BackColor = Color.Transparent;
        }
    }
}
