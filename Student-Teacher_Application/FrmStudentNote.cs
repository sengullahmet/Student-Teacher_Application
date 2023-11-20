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
using System.Windows.Forms.VisualStyles;

namespace Student_Teacher_Application
{
    public partial class FrmStudentNote : Form
    {
        public FrmStudentNote()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection bgl=new SqlConnection(@"Data Source=DESKTOP-SA9H44E;Initial Catalog=ogretım_uygulama;Integrated Security=True");
        private void FrmStudentNote_Load(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand kmt = new SqlCommand("select LESNAME,EXAM1,EXAM2,EXAM3,PROJECT,AVERAGE,STATUSS from tbl_Notes inner join tbl_lessons on tbl_Notes.LESID=tbl_lessons.LESID where STDID=@p1", bgl);
            kmt.Parameters.AddWithValue("@p1",numara);


            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            // Writing Student Name upper the Form
            SqlCommand kmt1 = new SqlCommand("select STDNAME, STDSURNAME from tbl_students where STDID=@p2",bgl);
            kmt1.Parameters.AddWithValue("@p2",numara);
            
            SqlDataReader dr=kmt1.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0].ToString() + " " + dr[1].ToString();
            }


        
                 






            bgl.Close();

            
        }
    }
}
