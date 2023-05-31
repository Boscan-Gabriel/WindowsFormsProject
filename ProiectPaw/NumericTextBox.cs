using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereFacultate
{
    public class NumericTextBox : TextBox
    {
        private  ErrorProvider errorProvider;
        

        public NumericTextBox()
        {
            
            this.errorProvider = new ErrorProvider();
            this.TextChanged += new EventHandler(OnTextChanged);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.errorProvider.Clear();
                return;
            }

            bool valid = this.Text.All(c => char.IsDigit(c) || c == '.');
            if (!valid)
            {
                this.errorProvider.SetError(this, "Introduceți doar cifre.");
            }
            else
            {
                this.errorProvider.Clear();
            }
        }
    }
}

