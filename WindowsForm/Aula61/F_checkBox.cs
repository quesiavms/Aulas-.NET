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
    public partial class F_checkBox : Form
    {
        public F_checkBox()
        {
            InitializeComponent();
        }

        private void F_checkBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }
            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }
            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + ", ";
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcada");
            }
        }
    }
}
