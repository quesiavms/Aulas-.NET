using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula61
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb_somenteTexto.Checked)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = mtb_cpf.Text;
            MessageBox.Show(msg);
        }

        private void mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarSenha.Checked)
            {
                mtb_senha.PasswordChar = '\0';
            }
            else
            {
                mtb_senha.PasswordChar= '*';
            }
        }
    }
}
