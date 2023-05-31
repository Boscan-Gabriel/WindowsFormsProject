using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereFacultate
{
    public partial class FormVizualizareCandidatura : Form
    {
          List<Candidatura> candidaturi;

        public FormVizualizareCandidatura(List<Candidatura> lista)
        {
            InitializeComponent();
            candidaturi = lista;
            foreach (Candidatura c in lista)
            {
                
                textBox1.Text +="Facultate: "+citireDenumireFacultate(c.IdFacultate)+ Environment.NewLine+
                   "Candidat: "+citireNumeCandidat(c.IdCandidat) + Environment.NewLine + c.ToString() + Environment.NewLine + Environment.NewLine;
            }
        }


       
        private string citireNumeCandidat(Guid idCandidat)
        {

            OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
            dbConnection.Open();
            OleDbCommand command1 = dbConnection.CreateCommand();
            command1.CommandText = "SELECT Candidat.nume FROM Candidat INNER JOIN Candidatura ON Candidat.IdCandidat = Candidatura.IdCandidat WHERE (((Candidat.[idCandidat])='"+idCandidat+"'));";
            //command1.Parameters.AddWithValue("@IdCandidat", idCandidat);
            string nume = null;
            //nume= (string)command.ExecuteScalar();   
             OleDbDataReader reader = command1.ExecuteReader();
             //string nume = null;
             while(reader.Read())
            {
                nume = reader["nume"].ToString();   
            }
            dbConnection.Close();
            return nume;
        }
        private string citireDenumireFacultate(Guid idFacultate)
        {

            OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\bosca\source\repos\ProiectPaw\ProiectPaw\AdmitereFacultate.accdb");
            dbConnection.Open();
            OleDbCommand command = dbConnection.CreateCommand();
            command.CommandText = "SELECT denumire FROM facultate WHERE IDFacultate = @idFacultate";
            command.Parameters.AddWithValue("@idFacultate", idFacultate);
            OleDbDataReader reader = command.ExecuteReader();
            string s = null;
            while (reader.Read())
            {

                s = reader["denumire"].ToString();

            }
            dbConnection.Close();
            return s;

        }

        private void salvareInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                //streamWriter.WriteLine(textBox1.Text);
                foreach (Candidatura c in candidaturi)
                    streamWriter.WriteLine($"{c.Id},{c.IdFacultate},{c.IdCandidat},{string.Join(",", c.Specializari)}");
                streamWriter.Close();
                textBox1.Clear();
                candidaturi.Clear();
            }



        }

        private void citireDinFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {

                string linie = null;
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                while ((linie = streamReader.ReadLine()) != null)
                {
                    string[] atribute = linie.Split(',');
                    Guid id = Guid.Parse(atribute[0]);
                    Guid idFaclutate = Guid.Parse(atribute[1]);
                    Guid idCandidat = Guid.Parse(atribute[2]);
                    string[] specializari = new string[atribute.Length - 3];
                    Array.Copy(atribute, 3, specializari, 0, atribute.Length - 3);
                    candidaturi.Add(new Candidatura(id, idFaclutate, idCandidat, specializari));
                    
                }
                streamReader.Close();
                foreach (Candidatura c in candidaturi)
                {

                    textBox1.Text += "Facultate: " + citireDenumireFacultate(c.IdFacultate) + Environment.NewLine
                        + c.ToString() + Environment.NewLine + Environment.NewLine;
                }
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("candidatura.dat",FileMode.Create,FileAccess.Write);
            binaryFormatter.Serialize(fileStream, candidaturi);
            fileStream.Close();
            textBox1.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("candidatura.dat", FileMode.Open, FileAccess.Read);
            List<Candidatura> list = (List<Candidatura>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            foreach (Candidatura c in list)
            {

                textBox1.Text += "Facultate: " + citireDenumireFacultate(c.IdFacultate) + Environment.NewLine
                    + c.ToString() + Environment.NewLine + Environment.NewLine;
            }

        }
    }
}
