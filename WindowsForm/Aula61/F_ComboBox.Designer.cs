namespace Aula61
{
    partial class F_ComboBox
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
            this.cb_transporte = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparElementos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_addNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transporte
            // 
            this.cb_transporte.FormattingEnabled = true;
            this.cb_transporte.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem"});
            this.cb_transporte.Location = new System.Drawing.Point(9, 11);
            this.cb_transporte.Name = "cb_transporte";
            this.cb_transporte.Size = new System.Drawing.Size(314, 24);
            this.cb_transporte.TabIndex = 0;
            this.cb_transporte.SelectedIndexChanged += new System.EventHandler(this.cb_transporte_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionado
            // 
            this.btn_mostrarSelecionado.Location = new System.Drawing.Point(329, 11);
            this.btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            this.btn_mostrarSelecionado.Size = new System.Drawing.Size(196, 23);
            this.btn_mostrarSelecionado.TabIndex = 1;
            this.btn_mostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionado.Click += new System.EventHandler(this.btn_mostrarSelecionado_Click);
            // 
            // btn_limparElementos
            // 
            this.btn_limparElementos.Location = new System.Drawing.Point(329, 40);
            this.btn_limparElementos.Name = "btn_limparElementos";
            this.btn_limparElementos.Size = new System.Drawing.Size(196, 24);
            this.btn_limparElementos.TabIndex = 2;
            this.btn_limparElementos.Text = "Limpar Elementos";
            this.btn_limparElementos.UseVisualStyleBackColor = true;
            this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(329, 70);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(196, 24);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(329, 153);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(195, 22);
            this.tb_transporte.TabIndex = 5;
            // 
            // btn_addNovoTransporte
            // 
            this.btn_addNovoTransporte.Location = new System.Drawing.Point(329, 181);
            this.btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            this.btn_addNovoTransporte.Size = new System.Drawing.Size(196, 24);
            this.btn_addNovoTransporte.TabIndex = 6;
            this.btn_addNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_addNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_addNovoTransporte.Click += new System.EventHandler(this.btn_addNovoTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 530);
            this.Controls.Add(this.btn_addNovoTransporte);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_limparElementos);
            this.Controls.Add(this.btn_mostrarSelecionado);
            this.Controls.Add(this.cb_transporte);
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transporte;
        private System.Windows.Forms.Button btn_mostrarSelecionado;
        private System.Windows.Forms.Button btn_limparElementos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_addNovoTransporte;
    }
}