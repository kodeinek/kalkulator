using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kalkulator;
using static kalkulator.Kalkulator;


namespace kalkulator.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            if(calc.TextValue != "0")
            {
                button.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            if (calc.ValueType != KalkulatorType.dec)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            if (calc.Value != 0)
            {
                button.BackColor = Color.Red;
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            if (calc.sum(2, 2) != 4)
            {
                button.BackColor = Color.Red;
            }
        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            if (calc.multiply(2, 2) != 4)
            {
                button.BackColor = Color.Red;
            }
        }
     

        private void button5_Click_1(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            if (calc.sub(2, 2) != 0)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            if (calc.dev(2, 2) != 1)
            {
                button.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(button1, null);
            button2_Click(button2, null);
            button3_Click(button3, null);
            button4_Click(button4, null);
            button5_Click_1(button5, null);
            button6_Click(button6, null);
            button7_Click_1(button7, null);
        }
    }
}
