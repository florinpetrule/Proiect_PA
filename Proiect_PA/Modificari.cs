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
    public partial class Modificari : Form
    {
        public Modificari()
        {
            InitializeComponent();
     
        }

        private void Modificari_Load(object sender, EventArgs e)
        {
            populezPersoane();
            populezDenumireStatut();
            populezDenumireInstitutie();
            populezDenumireDesemnare();
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    comboBox_pers.Items.Add(rd["nume_prenume"]);     
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
        public void populezDenumireStatut()
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
            public void populezDenumireInstitutie()
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
        public void populezDenumireDesemnare()
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

       
        //selectam numele persoanei
        private void comboBox_pers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM `view_persoane` INNER JOIN `persoane` WHERE `Nume Prenume` = '" + comboBox_pers.Text + "' AND nume_prenume = '" + comboBox_pers.Text + "'; ";

                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

                // MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    string numeInstitutie = mySqlDataReader.GetString(2);
                    string desemnare = mySqlDataReader.GetString(1);
                    string statut = mySqlDataReader.GetString(3);
                    string nume = mySqlDataReader.GetString(0);
                    string iD_persoana = mySqlDataReader.GetString(4);

                    textBox_ID.Text = iD_persoana;
                    textBox_institutie.Text = numeInstitutie;
                    textBox_desemnat.Text = desemnare;
                    textBox_statut.Text = statut;
                    textBox_nume.Text = nume;   
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


        //selectare ID statut
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
                    string idStatut = mySqlDataReader.GetString(0);

                    textBox_IDstatut.Text = idStatut;
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

        //selectare ID institutie
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
                    string idInstitutie = mySqlDataReader.GetString(0);

                    textBox_IDinst.Text = idInstitutie;
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
                    string idDesemnare = mySqlDataReader.GetString(0);

                    textBox_IDdesemnare.Text = idDesemnare;
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

        //Actualizate date in MySql
        private void actualizeaza_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
           
            try
            {
                string query = "UPDATE `persoane` SET `nume_prenume`='" + textBox_nume.Text + "',`ID_statut`='" + textBox_IDstatut.Text + "',`ID_institutie`='" + textBox_IDinst.Text + "',`ID_desemnare`='" + textBox_IDdesemnare.Text + "' WHERE `ID_persoana`= '" + textBox_ID.Text + "'; ";

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

        
    }
}
