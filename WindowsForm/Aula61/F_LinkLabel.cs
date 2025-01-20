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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            //adicionando mulitplos links
            //parametros, {posicao que se inicia (no vetor), tamanho que ocupa, o link}
            ll_multiplosLinks.Links.Add(0,6,"www.google.com.br");
            ll_multiplosLinks.Links.Add(9, 6, "http://github.com/" + tb_nome.Text);
            ll_multiplosLinks.Links.Add(18, 7, "http://youtube.com/");

            //desabilitar algum link
            ll_multiplosLinks.Links[2].Enabled = false;
        }

        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/"+tb_nome.Text);

            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
            //trocando a corzinha do link visitado
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //fazendo funcionar os links separados
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
