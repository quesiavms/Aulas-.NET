﻿using System;
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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novaTab_Click(object sender, EventArgs e)
        {
            if(tb_novaTab.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_novaTab.Text;
                pagina.Name = tb_novaTab.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(pagina);
                tb_novaTab.Clear();
                tb_novaTab.Focus();
                definarMaximo();
            }
        }

        private void btn_removerTabAtual_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void btn_posicionarTab_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = int.Parse(numericUpDown1.Value.ToString());
            }
        }
        private void definarMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count - 1;
        }
    }
}
