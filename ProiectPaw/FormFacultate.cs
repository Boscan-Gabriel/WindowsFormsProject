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
using System.Collections;

namespace AdmitereFacultate
{
    public partial class FormFacultate : Form
    {
        private List<Facultate> listaFacultati = new List<Facultate>();
        private Dictionary<string, int> specializari = new Dictionary<string, int>();
        

        public List<Facultate> GetListaFacultati()
        {
            return listaFacultati;
        }

        public FormFacultate()
        {
            InitializeComponent();
            citireDataBase();
        }


        private void citireDataBase()
        {
            OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
            dbConnection.Open();
            OleDbCommand command = dbConnection.CreateCommand();
            command.CommandText = "SELECT* from facultate";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Guid id = Guid.Parse(reader["IDFaculate"].ToString());
                string denumire = reader["Denumire"].ToString();
                string adresa = reader["Adresa"].ToString();
                string[] specializare = reader["Specializari"].ToString().Split(',');
                string[] nrLocuri = reader["NumarLocuri"].ToString().Split(',');
                string admitere = reader["TipAdmitere"].ToString() ;
                Dictionary<string,int> aux= new Dictionary<string,int>();
                for(int i = 0; i < specializare.Length; i++)
                {
                    aux.Add(specializare[i], Convert.ToInt32(nrLocuri[i]));
                }
                listaFacultati.Add(new Facultate(id,denumire,adresa,aux,admitere));

            }
            dbConnection.Close();
        }

        private void btnAdaugaSpecializare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDenumireSpecializare.Text))
            {
                errorProvider1.SetError(tbDenumireSpecializare, "Introduceti specializarea!");
            }
            else if (string.IsNullOrEmpty(tbNumarLocuri.Text))
            {
                errorProvider1.SetError(tbNumarLocuri, "Introduceti numar de lolcuri!");
            }
            else
            {
                try
                {
                    string denumireSpecializare = tbDenumireSpecializare.Text;
                    int nrLocuri = Convert.ToInt32(tbNumarLocuri.Text);

                    ListViewItem listViewItem = new ListViewItem(denumireSpecializare);
                    listViewItem.SubItems.Add(nrLocuri.ToString());
                    listViewSpecializari.Items.Add(listViewItem);
                    specializari.Add(denumireSpecializare, nrLocuri);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbDenumireSpecializare.Clear();
                    tbNumarLocuri.Clear();
                    errorProvider1.Clear();
                }
            }
        }

        private void btnAdaugaFacultate_Click(object sender, EventArgs e)
        {
            
             if (string.IsNullOrEmpty(tbDenumire.Text))
            {
                errorProvider1.SetError(tbDenumire, "Introduceti denumirea facultatii!");
            }
            else if (string.IsNullOrEmpty(tbAdresa.Text))
            {
                errorProvider1.SetError(tbAdresa, "Introduceti adresa facultatii!");
            }
            else if (string.IsNullOrEmpty(cbModAdmitere.Text))
            {
                errorProvider1.SetError(cbModAdmitere, "Selectati modalitatea de admitere!");
            }
            else if (specializari.Count == 0)
            {
                errorProvider1.SetError(listViewSpecializari, "Introduceti specializarile!");
            }
            else
            {
                try
                {
                   
                    string denumire = tbDenumire.Text;
                    string adresa = tbAdresa.Text;
                    string tipAdmitere = cbModAdmitere.Text;
                    Facultate facultate = new Facultate( denumire, adresa, this.specializari, tipAdmitere);
                    MessageBox.Show(facultate.ToString());
                    listaFacultati.Add(facultate);
                    string specializari = string.Join(",", facultate.Specializari.Keys);
                    string nrLocuri = string.Join(",", facultate.Specializari.Values);
                    OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
                    dbConnection.Open();
                    OleDbCommand command= dbConnection.CreateCommand();
                    command.CommandText = "insert into facultate(IDFaculate,Denumire,Adresa,Specializari,NumarLocuri,TipAdmitere) values('" + facultate.Id +"','" 
                        + facultate.Denumire + "','" + facultate.Adresa + "','" + specializari + "','" + nrLocuri + "','" + facultate.TipAdmitere + "')";
                       
                    command.ExecuteNonQuery();
                    dbConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                    tbDenumire.Clear();
                    tbAdresa.Clear();
                    cbModAdmitere.SelectedItem = null;
                    specializari = new Dictionary<string, int>();
                    listViewSpecializari.Items.Clear();
                    errorProvider1.Clear();
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVizualizareFaculate formVizualizareFaculate = new FormVizualizareFaculate(listaFacultati);
            formVizualizareFaculate.ShowDialog();
        }

        private void schibaCuloareaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FormFacultate_Load(object sender, EventArgs e)
        {

        }
    }
}
