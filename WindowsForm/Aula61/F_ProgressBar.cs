﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Aula61
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text) >= progressBar1.Minimum && 
               int.Parse(textBox1.Text) <= progressBar1.Maximum)
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Apenas escolha numeros de 0 a 100");
            }
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text); 
            for (int i = 0; i <= int.Parse(textBox2.Text); i++)
            { 
                label1.Text = i.ToString();
                progressBar1.Maximum = i;
                progressBar1.Value = i;
                //Thread.Sleep(200); //em milisegundos
            }
        }
    }
}
