using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula61.Properties;



namespace Aula61
{
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            /*
             Declaramos nossos arquivos de recursos em
             Properties > Resources.resx
             quando usamos o arquivo de recursos, podemos acessa-los em qualquer lugar do nosso programa
             Propertier.Resources.NomeDoRecurso
             */

            label1.Text = Properties.Resources.Nome;
            label2.Text = Properties.Resources.NomeGit;
            linkLabel1.Text = Properties.Resources.NomeGit;
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, Properties.Resources.NomeGit);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.NomeGit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.moon_wallpaper;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.wallpaper_cloud;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sasuke_wallpaper;
        }
    }
}
