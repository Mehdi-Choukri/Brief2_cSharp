using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brief_cSharp
{
    public partial class Modifier : Form
    {
        string Connection = "Data Source=DESKTOP-1A6447O;Initial Catalog=BriefCsharp;Integrated Security=True";
        int jour, mois, annee;
        List<string> errors = new List<string>(9);
        public Modifier()
        {
            InitializeComponent();
        }
        public void chargerPays(string pays)
        {
            cmbVille.Items.Clear();


            if (pays == "Maroc")
            {

                string[] ville = new string[] { "Rabat", "Eljadida", "Casablanca", "Tanger" };
                for (int i = 0; i < ville.Length; i++)
                {
                    cmbVille.Items.Add(ville[i]);
                }


            }
            else if (pays == "France")
            {

                string[] ville = new string[] { "Paris", "Lyon", "Marseille", "Nice" };
                for (int i = 0; i < ville.Length; i++)
                {
                    cmbVille.Items.Add(ville[i]);
                }

            }
            else
            {

                string[] ville = new string[] { "Washinton DC", "New York", "Chicago", "Miami" };
                for (int i = 0; i < ville.Length; i++)
                {
                    cmbVille.Items.Add(ville[i]);
                }

            }
            cmbVille.SelectedIndex = 0;

        }
        public bool ValideDate(string date)
        {
            jour = int.Parse(date[0].ToString() + date[1].ToString());

            mois = int.Parse(date[3].ToString() + date[4].ToString());

            annee = int.Parse(date.Substring(6, 4));

            if (annee >= 1900 && annee <= 2002)
            {
                if (mois >= 1 && mois <= 12)
                {
                    if ((jour >= 1 && jour <= 31) && (mois == 1 || mois == 3 || mois == 5 || mois == 7 || mois == 8 || mois == 10 || mois == 12))
                    {
                        return true;
                    }
                    else if ((jour >= 1 && jour <= 30) && (mois == 4 || mois == 6 || mois == 9 || mois == 11))
                    {
                        return true;
                    }
                    else if ((jour >= 1 && jour <= 28) && (mois == 2))
                    {
                        return true;
                    }
                    else if (jour == 29 && mois == 2 && (annee % 400 == 0 || (annee % 4 == 0 && annee % 100 != 0)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            Regex rx_mail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (rx_mail.IsMatch(txtEmail.Text))
            {
                if ((errors.Contains("Email non valide")))
                {

                    errors.Remove("Email non valide");
                }
                correct6.Visible = true;
            }
            else
            {
                if (!(errors.Contains("Email non valide")))
                {
                    errors.Add("Email non valide");
                }
                correct6.Visible = false;
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {
            Regex rx_name = new Regex("^[a-zA-Z ]{3,}$");
            if (rx_name.IsMatch(txtnom.Text))
            {
                if ((errors.Contains("Nom non valide")))
                {

                    errors.Remove("Nom non valide");
                }

                correct1.Visible = true;

            }
            else
            {
                if (!(errors.Contains("Nom non valide")))
                {
                    errors.Add("Nom non valide");
                }

                correct1.Visible = false;

            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            Regex rx_name = new Regex("^[a-zA-Z ]{3,}$");
            if (rx_name.IsMatch(txtPrenom.Text))
            {
                if ((errors.Contains("Prenom non valide")))
                {

                    errors.Remove("Prenom non valide");
                }
                correct5.Visible = true;
            }
            else
            {
                if (!(errors.Contains("Prenom non valide")))
                {
                    errors.Add("Prenom non valide");
                }
                correct5.Visible = false;
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            if (txtDate.Text.Length == 2 || txtDate.Text.Length == 5)
            {
                var insertText = "-";
                var selectionIndex = txtDate.SelectionStart;
                txtDate.Text = txtDate.Text.Insert(selectionIndex, insertText);
                txtDate.SelectionStart = selectionIndex + insertText.Length;



            }


            if ((txtDate.Text).Length >= 10 && (txtDate.Text).Length < 11 && ValideDate(txtDate.Text))
            {
                if ((errors.Contains("Date non valide")))
                {

                    errors.Remove("Date non valide");
                }

                correct2.Visible = true;
            }
            else
            {
                if (!(errors.Contains("Date non valide")))
                {
                    errors.Add("Date non valide");
                }
                correct2.Visible = false;
            }

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

            Regex rx_phone = new Regex("^[0][5-7][0-9]{8}$");
            if (rx_phone.IsMatch(txtTel.Text))
            {
                if ((errors.Contains("Telephone non valide")))
                {

                    errors.Remove("Telephone non valide");
                }
                correct3.Visible = true;
            }
            else
            {
                if (!(errors.Contains("Telephone non valide")))
                {
                    errors.Add("Telephone non valide");
                }
                correct3.Visible = false;
            }
        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerPays((cmbPays.SelectedItem).ToString());
        }

        private void cmbVille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtADR_TextChanged(object sender, EventArgs e)
        {
            Regex rx_ADR = new Regex("^[a-zA-Z 0-9 -_ ]{10,}$");
            if (rx_ADR.IsMatch(txtADR.Text))
            {
                if ((errors.Contains("Adresse non valide")))
                {

                    errors.Remove("Adresse non valide");
                }
                correct9.Visible = true;
            }
            else
            {
                if (!(errors.Contains("Adresse non valide")))
                {
                    errors.Add("Adresse non valide");
                }
                correct9.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Connection);
                cn.Open();
                string req = "delete apprenant where id_apprenant=" + Declaration.id_apprenant;
                SqlCommand cmd = new SqlCommand(req, cn);

                if (cmd.ExecuteNonQuery().Equals(1))
                {
                    MessageBox.Show("Supperssion effectuée avec succée");

                }
                else
                {
                    MessageBox.Show("L'echec de la Supperssion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int id_apprenant_cible = Declaration.id_apprenant;
            
            label9.Text = "Veuillez remplir les champs ";

            if (errors.Count == 0 && txtnom.Text != "" && txtPrenom.Text != "" && txtEmail.Text != "" && txtDate.Text != "" && txtTel.Text != "")
            {
                label9.Visible = false;

                

                try
                {
                    string Connection = "Data Source=DESKTOP-1A6447O;Initial Catalog=BriefCsharp;Integrated Security=True";
                    SqlConnection cn = new SqlConnection(Connection);
                    cn.Open();
                    string CorrectDateFormat = annee.ToString() + "-" + mois.ToString() + "-" + jour.ToString();
                    string req = "update apprenant set nom='"+ txtnom.Text + "' , prenom='"+ txtPrenom.Text + "' ,email= '"+ txtEmail.Text + "',telephone='"+ txtTel.Text + "',adresse='"+ txtADR.Text + "',pays='"+ cmbPays.Text + "',ville='"+ cmbVille.Text + "',choix='"+ cmbSpecialite.Text + "',date_naissance='"+ CorrectDateFormat + "' where id_apprenant="+id_apprenant_cible;
                    
                    SqlCommand cmd = new SqlCommand(req, cn);

                    if (cmd.ExecuteNonQuery().Equals(1))
                    {
                        MessageBox.Show("La modification est effectuée avec succée");
                    }
                    else
                    {
                        MessageBox.Show("L'echec de la modification");
                    }

                    cn.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                label9.Visible = true;
                foreach (var error in errors)
                {
                    label9.Text += "\n" + error;
                }
            }



        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            //error texts
            label9.Visible = false;

            // correct mark
            correct1.Visible = false;
            correct2.Visible = false;
            correct3.Visible = false;
            correct4.Visible = false;
            correct5.Visible = false;
            correct6.Visible = false;
            correct7.Visible = false;
            correct8.Visible = false;
            correct9.Visible = false;

            cmbPays.Items.Add("Maroc");
            cmbPays.Items.Add("France");
            cmbPays.Items.Add("USA");
             

            cmbSpecialite.Items.Add("C#");
            cmbSpecialite.Items.Add("JEE");
            cmbSpecialite.Items.Add("Front-end & Back-end");


            SqlConnection cn = new SqlConnection(Connection);
            cn.Open();
            string req = "select * from apprenant where id_apprenant="+Declaration.id_apprenant;
            SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            txtnom.Text = dt.Rows[0][1].ToString();
            txtPrenom.Text = dt.Rows[0][2].ToString();
            txtEmail.Text = dt.Rows[0][3].ToString();

            txtTel.Text = dt.Rows[0][4].ToString();
            txtADR.Text = dt.Rows[0][5].ToString();
            cmbPays.Text = dt.Rows[0][6].ToString();

            cmbVille.Text = dt.Rows[0][7].ToString();
            cmbSpecialite.Text = dt.Rows[0][8].ToString();
            txtDate.Text = dt.Rows[0][9].ToString().Substring(0,10);

            cn.Close();
        }
    }
}
