using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereFacultate
{
    [Serializable]
    public class Candidat
    {
        private Guid id;
        private string nume;
        private string CNP;
        private float medieBac;
        private string status;

        private char sex;

        public Candidat(Guid id, string nume, string CNP, float medieBac, string status,char sex)
        {
            this.id = id;
            this.nume = nume;
            this.CNP = CNP;
            this.medieBac = medieBac;
            this.status = status;
            this.sex = sex;
        }
        public Candidat( string nume, string CNP, float medieBac, string status, char sex)
        {
            this.id = Guid.NewGuid();
            this.nume = nume;
            this.CNP = CNP;
            this.medieBac = medieBac;
            this.status = status;
            this.sex = sex;
        }


        public Guid Id { get => id;  }
        public string Nume { get => nume; set => nume = value; }
        public string CNP1 { get => CNP; set => CNP = value; }
        public float MedieBac { get => medieBac; set => medieBac = value; }
        public string Status { get => status; set => status = value; }
        public char Sex { get => sex; set => sex = value; }

        public override string ToString()
        {
            return "Id candidat: " + id + Environment.NewLine + "Nume candidat: " + nume + Environment.NewLine + "CNP: " + CNP + Environment.NewLine + "Sex: " + sex
                + Environment.NewLine + "Media Bacalaureat: " + medieBac + Environment.NewLine + "Status: " + status;
        }
    }
}
