﻿namespace Aula61
{
    partial class F_checkBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transportesMarcados = new System.Windows.Forms.Button();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(20, 20);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(62, 20);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(20, 56);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(64, 20);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(20, 92);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(65, 20);
            this.cb_navio.TabIndex = 2;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(20, 127);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(71, 20);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transportesMarcados
            // 
            this.btn_transportesMarcados.Location = new System.Drawing.Point(164, 16);
            this.btn_transportesMarcados.Name = "btn_transportesMarcados";
            this.btn_transportesMarcados.Size = new System.Drawing.Size(226, 24);
            this.btn_transportesMarcados.TabIndex = 4;
            this.btn_transportesMarcados.Text = "Transportes Marcados";
            this.btn_transportesMarcados.UseVisualStyleBackColor = true;
            this.btn_transportesMarcados.Click += new System.EventHandler(this.btn_transportesMarcados_Click);
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(20, 205);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(78, 20);
            this.cb_patinete.TabIndex = 5;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir Form Filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.btn_transportesMarcados);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_checkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.Load += new System.EventHandler(this.F_checkBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transportesMarcados;
        private System.Windows.Forms.CheckBox cb_patinete;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_navio;
        public System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button button1;
    }
}