using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdmitereFacultate
{
    [Serializable]
    public class Facultate
    {
        private Guid id;
        private string denumire;
        private string adresa;
        //nr locuri si specializare intr-un map 
        private Dictionary<string, int> specializari;
        private string tipAdmitere;

        public Facultate( string denumire, string adresa, Dictionary<string, int> specializari, string tipAdmitere)
        {
            this.id = Guid.NewGuid();
            this.denumire = denumire;
            this.adresa = adresa;
            this.specializari = specializari;
            this.tipAdmitere = tipAdmitere;
        }
        public Facultate(Guid id,string denumire, string adresa, Dictionary<string, int> specializari, string tipAdmitere)
        {
            this.id = id;
            this.denumire = denumire;
            this.adresa = adresa;
            this.specializari = specializari;
            this.tipAdmitere = tipAdmitere;
        }

        public Guid Id { get => id;  }
        public string Denumire { get => denumire; set => denumire = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public Dictionary<string, int> Specializari { get => specializari; set => specializari = value; }
        public string TipAdmitere { get => tipAdmitere; set => tipAdmitere = value; }

        public override string ToString()
        {
            string rezultat = "Id: " + id + Environment.NewLine + "Denumire: " + denumire + Environment.NewLine
                + "Adresa: " + adresa + Environment.NewLine + "Tip admitere: " + tipAdmitere +
                Environment.NewLine + "Specializarile facultatii si numarul aferent de locuri sunt:" + Environment.NewLine;
            foreach (var specializare in specializari)
            {
                rezultat += specializare.Key + "-->" + specializare.Value + Environment.NewLine;
            }
            return rezultat;
        }
        public int calculNumarLocuriTotal()
        {
            int rez = 0;
            foreach (var s in specializari)
            {
        
                rez += s.Value;
            }
            return rez;
        }
    }
}
