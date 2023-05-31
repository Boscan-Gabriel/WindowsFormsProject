using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AdmitereFacultate
{
    public partial class FormCandidat : Form
    {
        private List<Candidat> listaCandidati;
        public FormCandidat(List<Candidat>list)
        {
            listaCandidati = list;
            InitializeComponent();
            citireDataBase();   
        }


        private void citireDataBase()
        {
            OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
            dbConnection.Open();
            OleDbCommand command = dbConnection.CreateCommand();
            command.CommandText = "SELECT* from candidat";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Guid id = Guid.Parse(reader["IdCandidat"].ToString());
                string nume = reader["Nume"].ToString();
                string CNP = reader["CNP"].ToString();
                float medie =float.Parse( reader["MedieBac"].ToString());
                string status = reader["Status"].ToString();
                char sex = Convert.ToChar(reader["Sex"].ToString());
               
                listaCandidati.Add(new Candidat(id, nume, CNP,medie, status,sex));

            }
            dbConnection.Close();
        }
        private void btnAdaugareCandidat_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbNume.Text))
            {
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            }
            else if (string.IsNullOrEmpty(tbCNP.Text))
            {
                errorProvider1.SetError(tbCNP, "Introduceti CNP-ul!");
            }
            else if(tbCNP.Text.Length!=14)
            {
                errorProvider1.SetError(tbCNP, "Dimensiune invalida! Introduceti 14 cifre!");
            }
            else if (string.IsNullOrEmpty(cbSex.Text))
            {
                errorProvider1.SetError(cbSex, "Selectati sexul!");
            }
            else if (string.IsNullOrEmpty(tbMedie.Text))
            {
                errorProvider1.SetError(tbMedie, "Introduceti media!");
            }

            else if(float.Parse(tbMedie.Text)<6 || float.Parse(tbMedie.Text)>10)
            {
                errorProvider1.SetError(tbMedie, "Introdduceti o medie valida intre 6 si 10!");
            }
            else if (string.IsNullOrEmpty(cbStatus.Text))
            {
                errorProvider1.SetError(cbStatus, "Selectati statusul!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    
                    string nume = tbNume.Text;
                    string CNP = tbCNP.Text;
                    char sex = Convert.ToChar(cbSex.Text);
                    float medieBac = float.Parse(tbMedie.Text);
                    string status = cbStatus.Text;
                    Candidat candidat = new Candidat( nume, CNP, medieBac, status, sex);
                    MessageBox.Show(candidat.ToString());
                    listaCandidati.Add(candidat);
                    OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
                    dbConnection.Open();
                    OleDbCommand command = dbConnection.CreateCommand();
                    command.CommandText = "insert into candidat(IdCandidat,Nume,CNP,MedieBac,Status,Sex) values('" + candidat.Id + "','"
                        + candidat.Nume + "','" + candidat.CNP1 + "','" + candidat.MedieBac + "','" + candidat.Status + "','" + candidat.Sex+ "')";

                    command.ExecuteNonQuery();
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCNP.Clear();
                    
                    tbNume.Clear();
                    tbMedie.Clear();
                    cbSex.SelectedIndex = -1;
                    cbStatus.SelectedItem = null;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVizualizareCandidat formVizualizareCandidat = new FormVizualizareCandidat(listaCandidati);
            formVizualizareCandidat.ShowDialog();
        }

        private void schimbaCuloareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                contextMenuStrip1.SourceControl.BackColor = dlg.Color;
        }

        private void schimbaFontulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                this.Font = dlg.Font;
        }
    }
}
