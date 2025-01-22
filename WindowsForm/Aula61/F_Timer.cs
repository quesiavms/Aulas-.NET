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
    public partial class F_Timer : Form
    {

        int num = 0;
        int px,py = 0;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            px = png_anime.Location.X;
            py = png_anime.Location.Y;
        }

        private void btn_iniciart1_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 500. //meio segundo
            timer1.Start();
        }

        private void btn_parart1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString(); ;
            timer1.Start();    
        }

        private void btn_iniciart2_Click(object sender, EventArgs e)
        {
            timer_anime.Start();
        }

        private void btn_parart2_Click(object sender, EventArgs e)
        {
            timer_anime.Stop();
        }

        private void timer_anime_Tick(object sender, EventArgs e)
        {
            px+=10;
            if(px >= 598)
            {
                px = 3;
            }
            png_anime.Location = new Point(px, py);
            px = png_anime.Location.X;
        }
    }
}
