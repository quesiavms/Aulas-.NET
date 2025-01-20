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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_DefinirValor_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(tb_valor.Text) >= numericUpDown1.Minimum && 
                decimal.Parse(tb_valor.Text) <= numericUpDown1.Maximum)
            {
            numericUpDown1.Value = decimal.Parse(tb_valor.Text);
            }
            else
            {
                MessageBox.Show("Este numero nao pode ser Inserido");
            }
        }
    }
}
