namespace Aula61
{
    partial class F_checkedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.tb_novoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(8, 11);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(199, 344);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(230, 18);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(210, 27);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(229, 51);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(211, 27);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(229, 84);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(211, 24);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar Lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(229, 297);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(208, 27);
            this.btn_addNovoTransporte.TabIndex = 4;
            this.btn_addNovoTransporte.Text = "Adicionar novo Transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // tb_novoTransporte
            // 
            this.tb_novoTransporte.Location = new System.Drawing.Point(230, 269);
            this.tb_novoTransporte.Name = "tb_novoTransporte";
            this.tb_novoTransporte.Size = new System.Drawing.Size(210, 22);
            this.tb_novoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um Novo Transporte";
            // 
            // F_checkedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_novoTransporte);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_checkedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_resetarLista;
        private System.Windows.Forms.Button btn_addNovoTransporte;
        private System.Windows.Forms.TextBox tb_novoTransporte;
        private System.Windows.Forms.Label label1;
    }
}