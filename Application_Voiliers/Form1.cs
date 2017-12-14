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

namespace Application_Voiliers
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\alexis.goupillot\Desktop\ApplicationVoiliers\ApplicationVoiliersDB.mdf;Integrated Security = True; Connect Timeout = 30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("AjouterOuEditer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@Id_Voilier", 0);
                sqlCmd.Parameters.AddWithValue("@Nom_Voilier", chp_NomV.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Marque_Voilier", chp_MarqueV.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Immatriculation_Voilier", chp_ImmatV.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Element ajouté avec succes.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message d'erreur");
            }
            finally
            {
                sqlCon.Close(); 
            }
        }

        private void chp_NomV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
