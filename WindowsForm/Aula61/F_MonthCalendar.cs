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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();

            TimeSpan diferenca = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;

            int diasDiferenca = diferenca.Days;

            textBox4.Text = diasDiferenca.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();

            TimeSpan diferenca = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;

            int diasDiferenca = diferenca.Days;

            textBox4.Text = diasDiferenca.ToString();
        }
    }
}
