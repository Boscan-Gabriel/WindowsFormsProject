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
    public partial class FormVizualizareFaculate : Form
    {
        List<Facultate> listaFacultati = new List<Facultate>();
        public FormVizualizareFaculate(List<Facultate> list)
        {
            InitializeComponent();
            listaFacultati = list;
            foreach (var f in list)
                textBox1.Text += f.ToString() + Environment.NewLine+Environment.NewLine;
        }

        private void salvareInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(listaFacultati.Count);
                foreach (var f in listaFacultati)
                {
                    streamWriter.WriteLine($"{f.Id},{f.Denumire},{f.Adresa},{f.TipAdmitere},{f.Specializari.Count}");
                    foreach (var x in f.Specializari)
                        streamWriter.WriteLine($"{x.Key},{x.Value}");
                    
                }
                
                streamWriter.Close();
                listaFacultati.Clear();
                textBox1.Clear();
            }
        }

        private void citireDinFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int nrFacultati = Convert.ToInt32(streamReader.ReadLine());
                for(int i=0;i<nrFacultati;i++)
                {
                    string[] atribute = streamReader.ReadLine().Split(',');
                    Guid id = Guid.Parse(atribute[0]);
                    string denumire = atribute[1];
                    string adresa = atribute[2];
                    string tipAdmitere = atribute[3];
                    int nrSpecializari = Convert.ToInt32(atribute[4]);
                    Dictionary<string, int> specializari = new Dictionary<string, int>(nrSpecializari);
                    for(int j=0;j<nrSpecializari;j++)
                    {
                        string[] s = streamReader.ReadLine().Split(',');
                        string specializare = s[0];
                        int nrLocuri = Convert.ToInt32(s[1]);
                        specializari.Add(specializare, nrLocuri);
                    }
                    listaFacultati.Add(new Facultate(id, denumire, adresa, specializari, tipAdmitere));
                }
                streamReader.Close();
                foreach (var f in listaFacultati)
                    textBox1.Text += f.ToString() + Environment.NewLine + Environment.NewLine;
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("facultati.dat", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, listaFacultati);
            fileStream.Close();
            textBox1.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("facultati.dat", FileMode.Open, FileAccess.Read);
            List<Facultate> lista = (List<Facultate>)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            foreach (var f in lista)
                textBox1.Text += f.ToString() + Environment.NewLine + Environment.NewLine;
            
        }

        private void creareBubleChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBubbleChart bubbleChart = new FormBubbleChart(listaFacultati);
            bubbleChart.ShowDialog();
        }
    }
}
