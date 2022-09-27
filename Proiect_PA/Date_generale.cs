using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Input;
using System.Configuration;

namespace Proiect_PA
{
    public partial class date_generale : Form
    {
        public date_generale()
        {
          InitializeComponent();
           populezPersoane();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modifica_Click(object sender, EventArgs e)
        {
            Modificari modificari = new Modificari();  
            modificari.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void listBox_pers_SelectedIndexChanged(object sender, EventArgs e)
        {
           MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();

            try
            {
                string query = "SELECT * FROM view_persoane, view_autorizari WHERE `nume_prenume`= '" + listBox_pers.Text + "' AND `Nume Prenume` = '" + listBox_pers.Text + "' ;";




                MySqlCommand mySqlCommand = new MySqlCommand(query, con);

               


                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {

                    string numeInstitutie = mySqlDataReader.GetString(2);
                    string desemnare = mySqlDataReader.GetString(1);
                    string statut = mySqlDataReader.GetString(3);

                    textBoxInstitutie.Text = numeInstitutie;
                    textBoxDesemnare.Text = desemnare;
                    textBoxStatut.Text = statut;

                    string descriere = mySqlDataReader.GetString(6);
                    string denumire = mySqlDataReader.GetString(5);

                    richTextBoxDescriere.Text = descriere;
                    richTextBoxCategoria.Text = denumire;

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

        // populez lista cu numele persoanelor
        public void populezPersoane() 
        {
            MySqlConnection con = new MySqlConnection("DataSource=localhost; UserID=root; database=autorizari");
            con.Open();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM view_persoane";
                MySqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {

                    listBox_pers.Items.Add(rd["Nume Prenume"]);

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
       

        private void listBoxInstitutie_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBoxInstitutie_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCategoria_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBoxDescriere_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            AdaugarePersoane adaugarePersoane = new AdaugarePersoane();
            adaugarePersoane.Show();
        }

        private void modifica_autorizari_Click(object sender, EventArgs e)
        {
            ModificaAutorizari modificaAutorizari = new ModificaAutorizari();  
            modificaAutorizari.Show(); 
        }
    }
}
