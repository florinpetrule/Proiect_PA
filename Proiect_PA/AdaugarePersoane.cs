using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proiect_PA
{
    public partial class AdaugarePersoane : Form
    {
        public AdaugarePersoane()
        {
            InitializeComponent();
            populezStatut();
            populezInstitutie();
            populezDesemnare(); 
        }
        public void populezStatut()
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM statut_securitate";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {

                    comboBox_statut.Items.Add(rd["denumire"]);

                }

                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void populezInstitutie()
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM institutia";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {

                    comboBox_inst.Items.Add(rd["denumire"]);

                }

                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void populezDesemnare()
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM desemnare";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    comboBox_desemnare.Items.Add(rd["denumire"]);
                }

                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox_statut_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM statut_securitate WHERE denumire = '" + comboBox_statut.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string IDdenumireStatut = mySqlDataReader.GetString(0);

                    textBox_IDstatut.Text = IDdenumireStatut;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox_inst_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM institutia WHERE denumire = '" + comboBox_inst.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string IDinstitutie = mySqlDataReader.GetString(0);

                    textBox_IDinstitutie.Text = IDinstitutie;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBox_desemnare_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM desemnare WHERE denumire = '" + comboBox_desemnare.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string IDdesemnare = mySqlDataReader.GetString(0);

                    textBox_IDdesemnare.Text = IDdesemnare;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "INSERT INTO `persoane` (`ID_persoana`, `nume_prenume`, `ID_statut`, `ID_institutie`, `ID_desemnare`) VALUES ('', '" + textBox_nume.Text + "','" + textBox_IDstatut.Text + "','" + textBox_IDinstitutie.Text + "','" + textBox_IDdesemnare.Text + "'); " ;

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Datele au fost adaugate cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
