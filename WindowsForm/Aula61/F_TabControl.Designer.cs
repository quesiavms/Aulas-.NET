namespace Aula61
{
    partial class F_TabControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_componentes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_novaTab = new System.Windows.Forms.TextBox();
            this.btn_novaTab = new System.Windows.Forms.Button();
            this.btn_removerTabAtual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionarTab = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_componentes
            // 
            this.tab_componentes.Location = new System.Drawing.Point(4, 25);
            this.tab_componentes.Name = "tab_componentes";
            this.tab_componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_componentes.Size = new System.Drawing.Size(768, 307);
            this.tab_componentes.TabIndex = 0;
            this.tab_componentes.Text = "Componentes";
            this.tab_componentes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_novaTab
            // 
            this.tb_novaTab.Location = new System.Drawing.Point(12, 13);
            this.tb_novaTab.Name = "tb_novaTab";
            this.tb_novaTab.Size = new System.Drawing.Size(258, 22);
            this.tb_novaTab.TabIndex = 1;
            // 
            // btn_novaTab
            // 
            this.btn_novaTab.Location = new System.Drawing.Point(276, 13);
            this.btn_novaTab.Name = "btn_novaTab";
            this.btn_novaTab.Size = new System.Drawing.Size(172, 23);
            this.btn_novaTab.TabIndex = 2;
            this.btn_novaTab.Text = "Nova Tab";
            this.btn_novaTab.UseVisualStyleBackColor = true;
            this.btn_novaTab.Click += new System.EventHandler(this.btn_novaTab_Click);
            // 
            // btn_removerTabAtual
            // 
            this.btn_removerTabAtual.Location = new System.Drawing.Point(454, 12);
            this.btn_removerTabAtual.Name = "btn_removerTabAtual";
            this.btn_removerTabAtual.Size = new System.Drawing.Size(192, 23);
            this.btn_removerTabAtual.TabIndex = 3;
            this.btn_removerTabAtual.Text = "Remover Tab Atual";
            this.btn_removerTabAtual.UseVisualStyleBackColor = true;
            this.btn_removerTabAtual.Click += new System.EventHandler(this.btn_removerTabAtual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(255, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_posicionarTab
            // 
            this.btn_posicionarTab.Location = new System.Drawing.Point(276, 49);
            this.btn_posicionarTab.Name = "btn_posicionarTab";
            this.btn_posicionarTab.Size = new System.Drawing.Size(172, 23);
            this.btn_posicionarTab.TabIndex = 5;
            this.btn_posicionarTab.Text = "Posicionar Tab";
            this.btn_posicionarTab.UseVisualStyleBackColor = true;
            this.btn_posicionarTab.Click += new System.EventHandler(this.btn_posicionarTab_Click);
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_posicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTabAtual);
            this.Controls.Add(this.btn_novaTab);
            this.Controls.Add(this.tb_novaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_TabControl";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_componentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_novaTab;
        private System.Windows.Forms.Button btn_novaTab;
        private System.Windows.Forms.Button btn_removerTabAtual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicionarTab;
    }
}