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

        private void Unexpected(string message)
        {
            textBox1.AppendText(message + Environment.NewLine);  // Dodaje komunikat do TextBox
            textBox1.ScrollToCaret(); // Przewija do ostatniej linii
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            if (calc.TextValue != "0")
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


        private void button8_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            calc.word_size = Kalkulator.WordSize.byte_;

            calc.Value = 16;
            calc.ConvertTextValue(true); 
            if (calc.HelpTextValue != "0001 0000")  
            {
                button.BackColor = Color.Red;  
            }

            
            calc.Value = 127;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "0111 1111") 
            {
                button.BackColor = Color.Red;
            }

            
            calc.Value = 129;
            if (calc.RepresentWord() == true) 
            {
                button.BackColor = Color.Red;  
            }
        }
        private void button9_Click(object sender, EventArgs e) // test word
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            // Ustawiamy wartość i typ na 'word_'
            calc.word_size = Kalkulator.WordSize.word_;

            // Test z wartością 256
            calc.Value = 256;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "0000 0001 0000 0000")  // 256 w binarnym
            {
                button.BackColor = Color.Red;
            }

            // Test z wartością maksymalną
            calc.Value = 32767;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "0111 1111 1111 1111")  // 32767 w binarnym
            {
                button.BackColor = Color.Red;
            }

            // Test z wartością minimalną
            calc.Value = -32768;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "1000 0000 0000 0000")  // -32768 w binarnym
            {
                button.BackColor = Color.Red;
            }

            // Test z wartością poza zakresem
            calc.Value = 32768;  // Poza zakresem 'word_'
            if (calc.RepresentWord() != false)
            {
                button.BackColor = Color.Red;
            }
        }
       
        private void button10_Click(object sender, EventArgs e) // test dword
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            // Ustawiamy wartość i typ na 'dword_'
            calc.word_size = Kalkulator.WordSize.dword_;

            // Test z wartością 1048576
            calc.Value = 1048576;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "0000 0000 0001 0000 0000 0000 0000 0000")  // 1048576 w binarnym
            {
                button.BackColor = Color.Red;
                Unexpected(calc.HelpTextValue);

            }

            // Test z wartością maksymalną
            calc.Value = 2147483647;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "0111 1111 1111 1111 1111 1111 1111 1111")  // 2147483647 w binarnym
            {
                button.BackColor = Color.Red;
                Unexpected(calc.HelpTextValue);
            }

            // Test z wartością minimalną
            calc.Value = -2147483648;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "1000 0000 0000 0000 0000 0000 0000 0000")  // -2147483648 w binarnym
            {
                button.BackColor = Color.Red;
            }

            // Test z wartością poza zakresem
            calc.Value = 2147483648;  // Poza zakresem 'dword_'
            if (calc.RepresentWord() != false)
            {
                button.BackColor = Color.Red;
                Unexpected(calc.HelpTextValue);

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e) // textbox
        {
        }

        private void button11_Click(object sender, EventArgs e)//test bin,dec,oct,hex
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            long[] testValues = { 0, 255, -128, 1024 };
            string[] expectedResults;

            foreach (long value in testValues)
            {
                calc.Value = value;

                // Test binarnej reprezentacji
                calc.ValueType = KalkulatorType.bin;
                calc.ConvertTextValue();
                expectedResults = new string[]
                {
            Convert.ToString(value, 2) // Wynik w systemie binarnym
                };
                if (!expectedResults.Contains(calc.TextValue))
                {
                    button.BackColor = Color.Red;
                    Unexpected($"BIN failed for value {value}, got {calc.TextValue}");
                }

                // Test ósemkowej reprezentacji
                calc.ValueType = KalkulatorType.oct;
                calc.ConvertTextValue();
                expectedResults = new string[]
                {
            Convert.ToString(value, 8) // Wynik w systemie ósemkowym
                };
                if (!expectedResults.Contains(calc.TextValue))
                {
                    button.BackColor = Color.Red;
                    Unexpected($"OCT failed for value {value}, got {calc.TextValue}");
                }

                // Test dziesiętnej reprezentacji
                calc.ValueType = KalkulatorType.dec;
                calc.ConvertTextValue();
                if (calc.TextValue != value.ToString())
                {
                    button.BackColor = Color.Red;
                    Unexpected($"DEC failed for value {value}, got {calc.TextValue}");
                }

                // Test szesnastkowej reprezentacji
                calc.ValueType = KalkulatorType.hex;
                calc.ConvertTextValue();
                expectedResults = new string[]
                {
            Convert.ToString(value, 16).ToUpper() // Wynik w systemie szesnastkowym
                };
                if (!expectedResults.Contains(calc.TextValue))
                {
                    button.BackColor = Color.Red;
                    Unexpected($"HEX failed for value {value}, got {calc.TextValue}");
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            // Test NOT
            int resultNot = calc.BitwiseNot(5);
            if (resultNot != -6) // NOT(5) = -6
            {
                button.BackColor = Color.Red;
                Unexpected($"NOT(5) failed: {resultNot}");
            }

            // Test AND
            int resultAnd = calc.BitwiseAnd(5, 3);
            if (resultAnd != 1) // 5 AND 3 = 1
            {
                button.BackColor = Color.Red;
                Unexpected($"AND(5, 3) failed: {resultAnd}");
            }

            // Test OR
            int resultOr = calc.BitwiseOr(5, 3);
            if (resultOr != 7) // 5 OR 3 = 7
            {
                button.BackColor = Color.Red;
                Unexpected($"OR(5, 3) failed: {resultOr}");
            }

            // Test XOR
            int resultXor = calc.BitwiseXor(5, 3);
            if (resultXor != 6) // 5 XOR 3 = 6
            {
                button.BackColor = Color.Red;
                Unexpected($"XOR(5, 3) failed: {resultXor}");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            // Test Shift Left (SHL)
            int resultShl = calc.ShiftLeft(5, 1);
            if (resultShl != 10) // 5 << 1 = 10
            {
                button.BackColor = Color.Red;
                Unexpected($"SHL(5, 1) failed: {resultShl}");
            }

            // Test Shift Right (SHR)
            int resultShr = calc.ShiftRight(5, 1);
            if (resultShr != 2) // 5 >> 1 = 2
            {
                button.BackColor = Color.Red;
                Unexpected($"SHR(5, 1) failed: {resultShr}");
            }

            // Additional Shift Left/Right edge cases
            int largeShiftLeft = calc.ShiftLeft(1, 30); // 1 << 30
            if (largeShiftLeft != 1073741824)
            {
                button.BackColor = Color.Red;
                Unexpected($"SHL(1, 30) failed: {largeShiftLeft}");
            }

            int largeShiftRight = calc.ShiftRight(-2147483648, 31); // -2147483648 >> 31
            if (largeShiftRight != -1)
            {
                button.BackColor = Color.Red;
                Unexpected($"SHR(-2147483648, 31) failed: {largeShiftRight}");
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
            button8_Click(button8, null);
            button9_Click(button9, null);
            button10_Click(button10, null);
            button11_Click(button11, null);
            button12_Click(button12, null);
            button13_Click(button13, null);



        }

    }
}