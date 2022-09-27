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
    public partial class ModificaAutorizari : Form
    {
        public ModificaAutorizari()
        {
            InitializeComponent();
            populezPersoane();
            populezCategorie();
            populezPersoaneNeautorizate();
        }

        public void populezPersoane()
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM persoane";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    comboBox_nume.Items.Add(rd["nume_prenume"]);
                    
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

        public void populezPersoaneNeautorizate()

        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM view_autorizari WHERE denumire IS NULL";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    comboBox_selectiePers.Items.Add(rd["nume_prenume"]);

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

        public void populezCategorie()
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM art_interzise";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    comboBox_categorie.Items.Add(rd["denumire"]);
                    comboBox_categorieArt.Items.Add(rd["denumire"]);
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

        private void comboBox_nume_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM `view_autorizari` INNER JOIN `persoane` WHERE view_autorizari.nume_prenume = '" + comboBox_nume.Text + "' AND persoane.nume_prenume = '" + comboBox_nume.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string categorie = mySqlDataReader.GetString(1);
                    string denumire = mySqlDataReader.GetString(2);
                    string idPersoana = mySqlDataReader.GetString(3);

                    richTextBox_categoria.Text = categorie;
                    richTextBox_descriere.Text = denumire;
                    textBox_idPers.Text = idPersoana;
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

        private void comboBox_categorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM `art_interzise` WHERE denumire =  '" + comboBox_categorie.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string descriere = mySqlDataReader.GetString(2);
                    string idArticol = mySqlDataReader.GetString(0);

                    richTextBoxDes.Text = descriere;
                    textBox_ID.Text = idArticol;
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

        private void button_modifica_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "UPDATE `autorizare_articole` SET ID_art = '" + textBox_ID.Text + "' WHERE ID_persoana = '" + textBox_idPers.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Datele au fost actualizate cu succes!");
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

        private void comboBox_selectiePers_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM `view_autorizari` INNER JOIN `persoane` WHERE view_autorizari.nume_prenume = '" + comboBox_selectiePers.Text + "' AND persoane.nume_prenume = '" + comboBox_selectiePers.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                                       
                    string idPersoana = mySqlDataReader.GetString(3);

                    textBox_ID_pers.Text = idPersoana;
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

        private void comboBox_categorieArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM `art_interzise` WHERE denumire =  '" + comboBox_categorieArt.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    string descriere = mySqlDataReader.GetString(2);
                    string idArticol = mySqlDataReader.GetString(0);

                    richTextBox_autorizare.Text = descriere;
                    textBox_categorie.Text = idArticol;
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

        private void adaugAutorizare_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "INSERT INTO `autorizare_articole`(`ID_autorizare`, `ID_persoana`, `ID_art`) VALUES ('', '" + textBox_ID_pers.Text + "', '" + textBox_categorie.Text + "'); ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Datele au fost adaugate cu succes!");
                comboBox_selectiePers.SelectedIndex = -1;
                comboBox_categorieArt.SelectedIndex = -1;
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
