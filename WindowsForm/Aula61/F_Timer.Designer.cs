namespace Aula61
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_iniciart1 = new System.Windows.Forms.Button();
            this.btn_parart1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.png_anime = new System.Windows.Forms.PictureBox();
            this.timer_anime = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciart2 = new System.Windows.Forms.Button();
            this.btn_parart2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.png_anime)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_iniciart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_parart1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_resetar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_iniciart1
            // 
            this.btn_iniciart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_iniciart1.Location = new System.Drawing.Point(3, 3);
            this.btn_iniciart1.Name = "btn_iniciart1";
            this.btn_iniciart1.Size = new System.Drawing.Size(260, 35);
            this.btn_iniciart1.TabIndex = 0;
            this.btn_iniciart1.Text = "iniciar";
            this.btn_iniciart1.UseVisualStyleBackColor = true;
            this.btn_iniciart1.Click += new System.EventHandler(this.btn_iniciart1_Click);
            // 
            // btn_parart1
            // 
            this.btn_parart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_parart1.Location = new System.Drawing.Point(269, 3);
            this.btn_parart1.Name = "btn_parart1";
            this.btn_parart1.Size = new System.Drawing.Size(260, 35);
            this.btn_parart1.TabIndex = 1;
            this.btn_parart1.Text = "parar";
            this.btn_parart1.UseVisualStyleBackColor = true;
            this.btn_parart1.Click += new System.EventHandler(this.btn_parart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btn_resetar
            // 
            this.btn_resetar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_resetar.Location = new System.Drawing.Point(535, 3);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(262, 35);
            this.btn_resetar.TabIndex = 2;
            this.btn_resetar.Text = "Reiniciar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // png_anime
            // 
            this.png_anime.Image = ((System.Drawing.Image)(resources.GetObject("png_anime.Image")));
            this.png_anime.Location = new System.Drawing.Point(3, 110);
            this.png_anime.Name = "png_anime";
            this.png_anime.Size = new System.Drawing.Size(190, 73);
            this.png_anime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.png_anime.TabIndex = 2;
            this.png_anime.TabStop = false;
            // 
            // timer_anime
            // 
            this.timer_anime.Tick += new System.EventHandler(this.timer_anime_Tick);
            // 
            // btn_iniciart2
            // 
            this.btn_iniciart2.Location = new System.Drawing.Point(13, 203);
            this.btn_iniciart2.Name = "btn_iniciart2";
            this.btn_iniciart2.Size = new System.Drawing.Size(205, 28);
            this.btn_iniciart2.TabIndex = 3;
            this.btn_iniciart2.Text = "Iniciar";
            this.btn_iniciart2.UseVisualStyleBackColor = true;
            this.btn_iniciart2.Click += new System.EventHandler(this.btn_iniciart2_Click);
            // 
            // btn_parart2
            // 
            this.btn_parart2.Location = new System.Drawing.Point(233, 203);
            this.btn_parart2.Name = "btn_parart2";
            this.btn_parart2.Size = new System.Drawing.Size(205, 28);
            this.btn_parart2.TabIndex = 4;
            this.btn_parart2.Text = "parar";
            this.btn_parart2.UseVisualStyleBackColor = true;
            this.btn_parart2.Click += new System.EventHandler(this.btn_parart2_Click);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_parart2);
            this.Controls.Add(this.btn_iniciart2);
            this.Controls.Add(this.png_anime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "F_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.png_anime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_iniciart1;
        private System.Windows.Forms.Button btn_parart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.PictureBox png_anime;
        private System.Windows.Forms.Timer timer_anime;
        private System.Windows.Forms.Button btn_iniciart2;
        private System.Windows.Forms.Button btn_parart2;
    }
}