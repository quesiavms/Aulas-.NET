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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           textBox1.Text = treeView1.SelectedNode.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "Minas Gerais";

            TreeNode estado2 = raizEstados.Nodes.Add("Rio de Janeiro");
            estado2.Name = "Rio de Janeiro";
            
            TreeNode estado3 = raizEstados.Nodes.Add("Parana");
            estado3.Name = "Parana";

            TreeNode cor1 = raizCores.Nodes.Add("Vermelho");
            cor1.Name = "Vermelho";

            TreeNode cor2 = raizCores.Nodes.Add("Azul");
            cor2.Name = "Azul";

            TreeNode cor3= raizCores.Nodes.Add("Branco");
            cor3.Name = "Branco";

            TreeNode no = raizEstados.Nodes.Add(textBox1.Text);
            no.Name = textBox1.Text;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover Estados "+ ex.Message);
            }
        }

        private void btn_rmvSelecionado_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover Estados " + ex.Message);
            }
        }
    }
}
