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

namespace Brief_cSharp
{
    public partial class Lister : Form
    {
        string Connection = "Data Source=DESKTOP-1A6447O;Initial Catalog=BriefCsharp;Integrated Security=True";

        public Lister()
        {
            InitializeComponent();
        }
        public void Ajout_Column_Modifier()
        {
            if (dataGridView1.Columns.Count == 10)
            {
                DataGridViewButtonColumn btn_M = new DataGridViewButtonColumn();
                btn_M.Name = "Modifier";
                btn_M.Text = "Modifier";
                btn_M.UseColumnTextForButtonValue = true;



                dataGridView1.Columns.AddRange(btn_M);
            }


        }

        private void Lister_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "select * from apprenant";
            SqlCommand cmd = new SqlCommand(req, cn);
             
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            Ajout_Column_Modifier();
            cn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != 10)
            {
                return;
            }
           Declaration.id_apprenant = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            Modifier m = new Modifier();
            m.Show();
          

        }
    }
}
