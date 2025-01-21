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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void btn_selecionado_Click(object sender, EventArgs e)
        {
            string txt;

            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            //MessageBox.Show(txt);
            tb_selecionado.Text = txt;
        }

        private void btn_selecionado2_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    txt = rb.Text;
                }
            }
            //MessageBox.Show(txt);
            tb_selecionado.Text = txt;
        }

    }
}
