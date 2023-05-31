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
    public partial class FormCandidatura : Form
    {


        List<Candidatura> listaCandidaturi = new List<Candidatura>();
        List<Facultate> listaFacultati=new List<Facultate>();
        List<Candidat> listaCandidati ;

        public void setListaCandidati(List<Candidat> list)
        {
            listaCandidati = list;
        }
        public void setListaFacultati(List<Facultate> list)
        {
            listaFacultati = list.ToList();
            foreach (var f in listaFacultati)
                cbFacultate.Items.Add(f.Denumire);
        }
        public FormCandidatura()
        {
            InitializeComponent();
            citireDataBase();
        }


        private void citireDataBase()
        {
            OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
            dbConnection.Open();
            OleDbCommand command = dbConnection.CreateCommand();
            command.CommandText = "SELECT* from candidatura";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Guid id = Guid.Parse(reader["IdCandidatura"].ToString());
                Guid idCandidat = Guid.Parse(reader["IdCandidat"].ToString());
                Guid idFacultate = Guid.Parse(reader["IdFacultate"].ToString());
                string[] specializari = reader["Specializari"].ToString().Split(',');
                

                listaCandidaturi.Add(new Candidatura(id,idFacultate,idCandidat,specializari));

            }
            dbConnection.Close();
        }

        private void btnCandidatura_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(cbFacultate.Text))

                    errorProvider1.SetError(cbFacultate, "Selectati facultatea!");
            
            else if (string.IsNullOrEmpty(tbCNPCandidat.Text))
            {
                errorProvider1.SetError(tbCNPCandidat, "Introduceti CNP-ul candidatului!");
            }
                else if(!listaCandidati.Any(s => s.CNP1 == tbCNPCandidat.Text))
            {
                errorProvider1.SetError(tbCNPCandidat, "Candidatul introdus nu exista!");
                DialogResult result = MessageBox.Show("Doriti sa adaugati un nou candidat?", "Candidatul introdus nu exista!", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    FormCandidat formCandidat = new FormCandidat(listaCandidati);
                    formCandidat.ShowDialog();
                }
            }

            else if (string.IsNullOrEmpty(tbSpecializari.Text))
            {
                errorProvider1.SetError(tbSpecializari, "Alegeti specializarile!");
            }
            else
            {
                errorProvider1.Clear();
                try
                {


                    Facultate facultate = listaFacultati.Find(f => f.Denumire == cbFacultate.Text);
                    
                    Candidat candidat = listaCandidati.Find(c => c.CNP1 == tbCNPCandidat.Text);
                   
                    string[] specializari = tbSpecializari.Text.Split(',');
                    Candidatura candidatura = new Candidatura(facultate.Id, candidat.Id, specializari);
                    MessageBox.Show(candidatura.ToString());
                    listaCandidaturi.Add(candidatura);

                    OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
                    dbConnection.Open();
                    OleDbCommand command = dbConnection.CreateCommand();
                    command.CommandText = "insert into candidatura(IdCandidatura,IdCandidat,IdFacultate,Specializari) values('" + candidatura.Id + "','"
                        + candidatura.IdCandidat + "','" + candidatura.IdFacultate + "','" + tbSpecializari.Text + "')";

                    command.ExecuteNonQuery();
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                     
                    tbCNPCandidat.Clear();
                    cbFacultate.SelectedIndex=-1;
                    tbSpecializari.Clear();

                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormVizualizareCandidatura form = new FormVizualizareCandidatura(listaCandidaturi);
            form.ShowDialog();
        }

        private void cbFacultate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbFacultate.Text))
            {
                listViewSpecializari.Items.Clear();
                Facultate facultate = listaFacultati.Find(f => f.Denumire == cbFacultate.Text);
                foreach (var s in facultate.Specializari)
                {
                    ListViewItem itm = new ListViewItem();
                    itm.Text = s.Key;
                    itm.SubItems.Add(s.Value.ToString());
                    listViewSpecializari.Items.Add(itm);
                }
            }
        }

        private void listViewSpecializari_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            tbSpecializari.Clear();
            foreach (ListViewItem itm in listViewSpecializari.CheckedItems)
                tbSpecializari.AppendText(itm.Text + ", ");
            if (!string.IsNullOrEmpty(tbSpecializari.Text))
                tbSpecializari.Text=tbSpecializari.Text.TrimEnd(',', ' ');
        }

        
    }
}
