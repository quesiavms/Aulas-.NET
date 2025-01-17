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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transporte.Text);
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transporte.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");

            cb_transporte.Items.AddRange(tr.ToArray());
        }

        private void cb_transporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transporte.Text;
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_transporte.Text != "")
            {
                if (cb_transporte.FindString(tb_transporte.Text) < 0) 
                {
                   cb_transporte.Items.Add(tb_transporte.Text);
                    MessageBox.Show("Transporte adicionado com sucesso");
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Transporte ja existente");
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
            }
        }
    }
}
