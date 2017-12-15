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
    public partial class SG_Voilier : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\alexis.goupillot\Desktop\ApplicationVoiliers\ApplicationVoiliersDB.mdf;Integrated Security = True; Connect Timeout = 30");
        int id_Voilier = 0;
        public SG_Voilier()
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
                if (btn_Ajouter.Text == "Ajouter")
                {
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
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("AjouterOuEditer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@Id_Voilier", id_Voilier);
                    sqlCmd.Parameters.AddWithValue("@Nom_Voilier", chp_NomV.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Marque_Voilier", chp_MarqueV.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Immatriculation_Voilier", chp_ImmatV.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Element modifie avec succes.");
                }
 
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

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("search", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@NomVoilier", chp_Rechercher.Text.Trim());
            DataTable dataTable = new DataTable();
            sqlDa.Fill(dataTable);
            dtgv_Voilier.DataSource = dataTable;
            dtgv_Voilier.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void chp_NomV_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtgv_Voilier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message d'erreur");
            }
        }

        private void dtgv_Voilier_DoubleClick(object sender, EventArgs e)
        {
            if(dtgv_Voilier.CurrentRow.Index != -1)
            {
                id_Voilier = Convert.ToInt32(dtgv_Voilier.CurrentRow.Cells[0].Value.ToString());
                chp_NomV.Text = dtgv_Voilier.CurrentRow.Cells[1].Value.ToString();
                chp_MarqueV.Text = dtgv_Voilier.CurrentRow.Cells[2].Value.ToString();
                chp_ImmatV.Text = dtgv_Voilier.CurrentRow.Cells[3].Value.ToString();
                btn_Ajouter.Text = "Modifier";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Supprimer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id_Voilier", id_Voilier);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Element supprime avec succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message d'erreur");
            }
        }
    }
}
