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

namespace test_bd_cmd
{
    public partial class Form1 : Form
    {
        int nr;
        string cs;
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paw_db;Integrated Security=True;Encrypt=False";
            con=new SqlConnection(cs);
            nr = 0;
        }

        void Vizualizare_date()
        {
            gv.Rows.Clear();
            con.Open();
            string scmd = "select * from persoane";
            SqlCommand cmd = new SqlCommand(scmd, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
                gv.Rows.Add(dr["Marca"].ToString(), dr["Nume"].ToString());
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            string scmd = "select * from persoane";
            SqlCommand cmd = new SqlCommand(scmd, con);
            SqlDataReader dr = cmd.ExecuteReader();
            gv.ColumnCount = dr.FieldCount;
            gv.Columns[0].Name = dr.GetName(0);
            gv.Columns[1].Name = dr.GetName(1);
            gv.Columns[1].Width = 250;
            con.Close();
            Vizualizare_date();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string scmd = "insert into persoane values (500, 'Zamfir Gigi')";
                SqlCommand cmd = new SqlCommand(scmd, con);
                nr = cmd.ExecuteNonQuery();
                
                con.Close();
                Vizualizare_date();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Adaugat " + nr.ToString() + " Tupluri");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //string scmd = "delete from persoane where marca="+tbm.Text;
                string scmd = "delete from persoane where marca= @Marca";
                SqlCommand cmd = new SqlCommand(scmd, con);
                cmd.Parameters.Add("@Marca", SqlDbType.Int).Value = int.Parse(tbm.Text);
                nr = cmd.ExecuteNonQuery();
                con.Close();
                Vizualizare_date();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Sters " + nr.ToString() + " Tupluri");
            }
        }
    }
}
