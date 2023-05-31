using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereFacultate
{
    [Serializable]
    public class Candidatura
    {
        private  Guid id;
        private Guid idFacultate;
        private Guid idCandidat;
        private string[] specializari;
        

        public Candidatura( Guid idFacultate, Guid idCandidat, string[] specializari)
        {
            this.id = Guid.NewGuid();
            this.idFacultate = idFacultate;
            this.idCandidat = idCandidat;
            this.specializari = (string[])specializari.Clone();
           
        }
        public Candidatura(Guid id,Guid idFacultate, Guid idCandidat, string[] specializari)
        {
            this.id = id;
            this.idFacultate = idFacultate;
            this.idCandidat = idCandidat;
            this.specializari = (string[])specializari.Clone();

        }

        public Guid Id { get => id;  }
        public Guid IdFacultate { get => idFacultate;  }
        public Guid IdCandidat { get => idCandidat;  }
        public string[] Specializari { get => specializari; set => specializari = value; }

        public override string ToString()
        {
            string rez ="Specializarile alese: ";
            for (int i = 0; i < specializari.Length - 1; i++)
                rez += specializari[i] + ",";
            rez += specializari[specializari.Length - 1] + ".";
            return rez;
        }
    }



}
