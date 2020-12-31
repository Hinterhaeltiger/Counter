using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_Silvester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            DateTime twelve = DateTime.Parse("01.01.2021 00:00:00");
            TimeSpan difference = twelve - current;
            if (difference.Hours >= 1)
            {
                label2.Text = $"Noch {difference.Hours} Stunden, {difference.Minutes} Minuten und {difference.Seconds} Sekunden bis NeuJahr!";
            }
            else if (difference.Minutes >= 1)
            {
                label2.Text = $"Noch {difference.Minutes} Minuten und {difference.Seconds} Sekunden Bis NeuJahr!";
            }
            else if(difference.Minutes <= 1)
            {
                label2.Text = $"Noch {difference.Seconds} Sekunden bis Neujahr!";
            }
        }
    }
}
