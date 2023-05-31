using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereFacultate
{
    public partial class Form1 : Form
    {
        
        
        private FormFacultate formFacultate = new FormFacultate();
        private FormCandidat formCandidat;
        private List<Candidat> listaCandidati = new List<Candidat>();
        public Form1()
        {
            InitializeComponent();
            formCandidat= new FormCandidat(listaCandidati);


        }

       
        
        

        private void btnFacultate_Click(object sender, EventArgs e)
        {
           
            formFacultate.ShowDialog();
        }

        private void btnCandidat_Click(object sender, EventArgs e)
        {
            
            formCandidat.ShowDialog();
        }

        private void btnCandidatura_Click(object sender, EventArgs e)
        {
            if (formFacultate.GetListaFacultati().Count == 0)
                MessageBox.Show("Nu exista facultati introduse!");
            else
            {
                FormCandidatura formCandidatura = new FormCandidatura();
                formCandidatura.setListaFacultati(formFacultate.GetListaFacultati());
                formCandidatura.setListaCandidati(listaCandidati);
                formCandidatura.ShowDialog();
            }
        }
    }
}
