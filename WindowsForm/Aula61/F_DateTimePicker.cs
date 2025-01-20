using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula61
{
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;

            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;

            dia = Int32.Parse(tb_dia.Text);
            mes = Int32.Parse(tb_mes.Text);
            ano = Int32.Parse(tb_ano.Text);

            DateTime dt = new DateTime(ano, mes, dia);

            dtp_data.Value = dt;
            tb_data.Text = dt.ToString();
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dtp_data.Value = dt;

            tb_dia.Text = dt.Day.ToString();
            tb_ano.Text = dt.Year.ToString();
            tb_mes.Text = dt.Month.ToString();
            tb_data.Text = dt.ToString("dd/MM/yyyy HH:mm:ss");

        }
    }
}
