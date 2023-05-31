using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereFacultate
{
    public partial class FormVizualizareCandidat : Form
    {
        List<Candidat> candidati;
        public FormVizualizareCandidat(List<Candidat>list)
        {
            InitializeComponent();
            candidati = list;
            foreach (var c in list)
                textBox1.Text += c.ToString() + Environment.NewLine + Environment.NewLine;
        }

        private void salvareInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                foreach (var c in candidati)
                    streamWriter.WriteLine($"{c.Id},{c.Nume},{c.CNP1},{c.MedieBac},{c.Status},{c.Sex}");
                streamWriter.Close();
                candidati.Clear();
                textBox1.Clear();
            }
            
        }

        private void citireDinFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                string linie = null;
                while ((linie = streamReader.ReadLine()) != null)
                {
                    string[] atribute = linie.Split(',');
                    Guid id = Guid.Parse(atribute[0]);
                    string nume = atribute[1];
                    string CNP = atribute[2];
                    float medie = float.Parse(atribute[3]);
                    string status = atribute[4];
                    char sex = Convert.ToChar(atribute[5]);
                    candidati.Add(new Candidat(id, nume, CNP, medie, status, sex));
                }
                streamReader.Close();
                foreach (var c in candidati)
                    textBox1.Text += c.ToString() + Environment.NewLine + Environment.NewLine;
            }

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("candidati.dat", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, candidati);
            fileStream.Close();
            textBox1.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("candidati.dat", FileMode.Open, FileAccess.Read);
            List<Candidat> list = (List<Candidat>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            foreach (var c in list)
                textBox1.Text += c.ToString() + Environment.NewLine + Environment.NewLine;
        }
    }
}
