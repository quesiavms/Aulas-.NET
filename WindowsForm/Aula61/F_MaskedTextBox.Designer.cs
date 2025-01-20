namespace Aula61
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrarCPF = new System.Windows.Forms.Button();
            this.cb_somenteTexto = new System.Windows.Forms.CheckBox();
            this.cb_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(11, 54);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(318, 22);
            this.mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira uma Senha";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(11, 126);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(175, 22);
            this.mtb_cpf.TabIndex = 2;
            this.mtb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira CPF";
            // 
            // btn_mostrarCPF
            // 
            this.btn_mostrarCPF.Location = new System.Drawing.Point(328, 129);
            this.btn_mostrarCPF.Name = "btn_mostrarCPF";
            this.btn_mostrarCPF.Size = new System.Drawing.Size(130, 23);
            this.btn_mostrarCPF.TabIndex = 4;
            this.btn_mostrarCPF.Text = "Mostrar CPF";
            this.btn_mostrarCPF.UseVisualStyleBackColor = true;
            this.btn_mostrarCPF.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_somenteTexto
            // 
            this.cb_somenteTexto.AutoSize = true;
            this.cb_somenteTexto.Location = new System.Drawing.Point(192, 129);
            this.cb_somenteTexto.Name = "cb_somenteTexto";
            this.cb_somenteTexto.Size = new System.Drawing.Size(120, 20);
            this.cb_somenteTexto.TabIndex = 5;
            this.cb_somenteTexto.Text = "Somente Texto";
            this.cb_somenteTexto.UseVisualStyleBackColor = true;
            // 
            // cb_mostrarSenha
            // 
            this.cb_mostrarSenha.AutoSize = true;
            this.cb_mostrarSenha.Location = new System.Drawing.Point(346, 56);
            this.cb_mostrarSenha.Name = "cb_mostrarSenha";
            this.cb_mostrarSenha.Size = new System.Drawing.Size(116, 20);
            this.cb_mostrarSenha.TabIndex = 6;
            this.cb_mostrarSenha.Text = "Mostrar Senha";
            this.cb_mostrarSenha.UseVisualStyleBackColor = true;
            this.cb_mostrarSenha.CheckedChanged += new System.EventHandler(this.mostrarSenha_CheckedChanged);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.cb_mostrarSenha);
            this.Controls.Add(this.cb_somenteTexto);
            this.Controls.Add(this.btn_mostrarCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_senha);
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_mostrarCPF;
        private System.Windows.Forms.CheckBox cb_somenteTexto;
        private System.Windows.Forms.CheckBox cb_mostrarSenha;
    }
}