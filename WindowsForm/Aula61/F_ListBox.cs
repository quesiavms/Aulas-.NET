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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Gol");
            carros.Add("Honda");

            lb_carros.DataSource = carros;
        }

        //metodo generico pra atualizar o DataSource, ou seja, a lista
        public void AtualizarLista(ListBox lb, List<string> list)
        {
            lb.DataSource = null;
            lb.DataSource = list;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro");
                tb_carro.Focus(); //focar o cursor no textBox
            }
            else
            {
                carros.Add(tb_carro.Text);
                AtualizarLista(lb_carros, carros);
                tb_carro.Clear();
                tb_carro.Focus();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {            
            carros.RemoveAt(lb_carros.SelectedIndex);
            AtualizarLista(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex].ToString();
        }

        private void btn_limparTudo_Click(object sender, EventArgs e)
        {
            tb_carro.Clear();
            carros.Clear();
            AtualizarLista(lb_carros, carros);
        }


        //error: cliquei em um bottao sem querer
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
