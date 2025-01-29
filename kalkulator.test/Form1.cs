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

        private void Unexpected(string message)// początkowa wartość tekstowa
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

        private void button2_Click(object sender, EventArgs e)// startowy system
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            if (calc.ValueType != KalkulatorType.dec)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)//początkowa wartość
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            if (calc.Value != 0)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e) // Test sumowania
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            calc.Value = 2;
            calc.Value2 = 2;
            calc.sum(); // Teraz funkcja modyfikuje Value

            if (calc.Value != 4) // Sprawdzamy zmodyfikowaną wartość
            {
                button.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e) // Test mnożenia
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            calc.Value = 2;
            calc.Value2 = 2;
            calc.multiply();

            if (calc.Value != 4)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button5_Click_1(object sender, EventArgs e) // Test odejmowania
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            calc.Value = 2;
            calc.Value2 = 2;
            calc.sub();

            if (calc.Value != 0)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button7_Click_1(object sender, EventArgs e) // Test dzielenia
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            calc.Value = 2;
            calc.Value2 = 2;
            calc.dev();

            if (calc.Value != 1)
            {
                button.BackColor = Color.Red;
            }
        }

        private void button8_Click(object sender, EventArgs e)// test reprezentacji binarnej, graniczny 
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
        private void button9_Click(object sender, EventArgs e) // test długości słowa word , graniczny
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
                Unexpected(calc.HelpTextValue);

            }

            // Test z wartością maksymalną
            calc.Value = 32767;
            calc.ConvertTextValue(true);
            if (calc.HelpTextValue != "0111 1111 1111 1111")  // 32767 w binarnym
            {
                button.BackColor = Color.Red;
                Unexpected(calc.HelpTextValue);

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
       
        private void button10_Click(object sender, EventArgs e) // test dword, graniczny 
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

        private void button12_Click(object sender, EventArgs e) //
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            calc.Value = 5;
            calc.Value2 = 3;
            // Test NOT
            long resultNot = calc.BitwiseNot();
            if (resultNot != -6) // NOT(5) = -6
            {
                button.BackColor = Color.Red;
                Unexpected($"NOT(5) failed: {resultNot}");
            }

            // Test AND
            long resultAnd = calc.BitwiseAnd();
            if (resultAnd != 1) // 5 AND 3 = 1
            {
                button.BackColor = Color.Red;
                Unexpected($"AND(5, 3) failed: {resultAnd}");
            }

            // Test OR
            long resultOr = calc.BitwiseOr();
            if (resultOr != 7) // 5 OR 3 = 7
            {
                button.BackColor = Color.Red;
                Unexpected($"OR(5, 3) failed: {resultOr}");
            }

            // Test XOR
            long resultXor = calc.BitwiseXor();
            if (resultXor != 6) // 5 XOR 3 = 6
            {
                button.BackColor = Color.Red;
                Unexpected($"XOR(5, 3) failed: {resultXor}");
            }
        }

        private void button13_Click(object sender, EventArgs e)// graniczny
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;
            calc.Value = 5;
            calc.Value2 = 3;

            // Test Shift Left (SHL)
            long resultShl = calc.ShiftLeft(1);
            if (resultShl != 10) // 5 << 1 = 10
            {
                button.BackColor = Color.Red;
                Unexpected($"SHL(5, 1) failed: {resultShl}");
            }

            // Test Shift Right (SHR)
            long resultShr = calc.ShiftRight(1);
            if (resultShr != 2) // 5 >> 1 = 2
            {
                button.BackColor = Color.Red;
                Unexpected($"SHR(5, 1) failed: {resultShr}");
            }

            calc.Value = 1;
            long largeShiftLeft = calc.ShiftLeft(30); // 1 << 30
            if (largeShiftLeft != 1073741824)
            {
                button.BackColor = Color.Red;
                Unexpected($"SHL(1, 30) failed: {largeShiftLeft}");
            }
            calc.Value = -2147483648;
            long largeShiftRight = calc.ShiftRight(31); // -2147483648 >> 31
            if (largeShiftRight != -1)
            {
                button.BackColor = Color.Red;
                Unexpected($"SHR(-2147483648, 31) failed: {largeShiftRight}");
            }
        }

        private void button14_Click(object sender, EventArgs e) // Test modulo
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            calc.Value = 10;
            calc.Value2 = 3;
            if (calc.Modulo() != 1) // 10 % 3 = 1
            {
                button.BackColor = Color.Red;
                Unexpected($"Modulo(10, 3) failed: {calc.Modulo()}");
            }

            calc.Value = -10;
            if (calc.Modulo() != -1) // -10 % 3 = -1
            {
                button.BackColor = Color.Red;
                Unexpected($"Modulo(-10, 3) failed: {calc.Modulo()}");
            }

            calc.Value2 = 0;
            try
            {
                calc.Modulo(); // Próba wykonania dzielenia przez zero
                button.BackColor = Color.Red;
                Unexpected("Modulo division by zero did not throw an exception");
            }
            catch (DivideByZeroException)
            {
                // Oczekiwane zachowanie
            }
        }

        private void button15_Click(object sender, EventArgs e) // Test pamięci
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            calc.Value = 42;
            calc.SaveMemory(); // Zapisuje 42 do pamięci

            calc.Value = 0;
            calc.LoadMemory(); // Odczytuje z pamięci

            if (calc.Value != 42)
            {
                button.BackColor = Color.Red;
                Unexpected($"Memory load failed: {calc.Value}");
            }

            calc.MemoryClear(); // Czyści pamięć
            calc.LoadMemory();
            if (calc.Value != 0)
            {
                button.BackColor = Color.Red;
                Unexpected($"Memory clear failed: {calc.Value}");
            }
        }

        private void button16_Click(object sender, EventArgs e) // Test usuwania znaku
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            calc.TextValue = "12345";
            calc.RemoveLastCharacter();
            if (calc.TextValue != "1234")
            {
                button.BackColor = Color.Red;
                Unexpected($"RemoveLastCharacter failed: {calc.TextValue}");
            }

            calc.TextValue = "1";
            calc.RemoveLastCharacter();
            if (calc.TextValue != "0")
            {
                button.BackColor = Color.Red;
                Unexpected($"RemoveLastCharacter to empty string failed: {calc.TextValue}");
            }
        }


        private void button17_Click(object sender, EventArgs e) // Test zmiany znaku
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            calc.Value = 123;
            calc.ChangeSign();
            if (calc.Value != -123)
            {
                button.BackColor = Color.Red;
                Unexpected($"ChangeSign failed: {calc.Value}");
            }

            calc.ChangeSign();
            if (calc.Value != 123)
            {
                button.BackColor = Color.Red;
                Unexpected($"ChangeSign twice failed: {calc.Value}");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            try
            {
                // Test dla byte
                calc.word_size = Kalkulator.WordSize.byte_;
                calc.Value = 127;
                calc.Value2 = 1;

                if (calc.sum())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum exceeded byte range but was not detected");
                }

                calc.Value = -128;
                calc.Value2 = 1;

                if (calc.sub())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Subtraction exceeded byte range but was not detected");
                }

                // Test dla word
                calc.word_size = Kalkulator.WordSize.word_;
                calc.Value = 32767;
                calc.Value2 = 1;

                if (calc.sum())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum exceeded word range but was not detected");
                }

                calc.Value = -32768;
                calc.Value2 = 1;

                if (calc.sub())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Subtraction exceeded word range but was not detected");
                }

                // Test dla dword
                calc.word_size = Kalkulator.WordSize.dword_;
                calc.Value = 2147483647;
                calc.Value2 = 1;

                if (calc.sum())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum exceeded dword range but was not detected");
                }

                calc.Value = -2147483648;
                calc.Value2 = 1;

                if (calc.sub())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Subtraction exceeded dword range but was not detected");
                }

                // Test dla qword (dla long nie będzie wyjątku, ale sprawdzamy poprawność wartości)
                calc.word_size = Kalkulator.WordSize.qword_;
                calc.Value = 9223372036854775807; // Max long
                calc.Value2 = 1;

                if (calc.sum())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum exceeded qword range but was not detected");
                }

                calc.Value = -9223372036854775808; // Min long
                calc.Value2 = 1;

                if (calc.sub())
                {
                    button.BackColor = Color.Red;
                    Unexpected("Subtraction exceeded qword range but was not detected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

        private void button19_Click(object sender, EventArgs e) // Test operacji arytmetycznych
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            try
            {
                // Test dla byte
                calc.word_size = Kalkulator.WordSize.byte_;
                calc.Value = 99;
                calc.Value2 = 99;

                if (!calc.sum())
                {
                    Console.WriteLine("Overflow detected correctly for byte");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum of 99 + 99 for byte was not detected as overflow");
                }

                // Test dla word
                calc.word_size = Kalkulator.WordSize.word_;
                calc.Value = 32000;
                calc.Value2 = 1000;

                if (!calc.sum())
                {
                    Console.WriteLine("Overflow detected correctly for word");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum of 32000 + 1000 for word was not detected as overflow");
                }

                // Test dla dword
                calc.word_size = Kalkulator.WordSize.dword_;
                calc.Value = 2147483640;
                calc.Value2 = 10;

                if (!calc.sum())
                {
                    Console.WriteLine("Overflow detected correctly for dword");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Sum of 2147483640 + 10 for dword was not detected as overflow");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var calc = new Kalkulator();
            var button = (Button)sender;

            button.BackColor = Color.Green;

            try
            {
                // Test dla byte
                calc.word_size = Kalkulator.WordSize.byte_;
                calc.Value = 127;
                calc.Value2 = 1;
                var previousValue = calc.Value;

                if (!calc.sum() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sum()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sum()");
                }

                calc.Value = -128;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sub() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sub()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sub()");
                }

                // Test dla word
                calc.word_size = Kalkulator.WordSize.word_;
                calc.Value = 32767;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sum() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sum()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sum()");
                }

                calc.Value = -32768;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sub() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sub()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sub()");
                }

                // Test dla dword
                calc.word_size = Kalkulator.WordSize.dword_;
                calc.Value = 2147483647;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sum() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sum()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sum()");
                }

                calc.Value = -2147483648;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sub() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sub()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sub()");
                }

                // Test dla qword (long)
                calc.word_size = Kalkulator.WordSize.qword_;
                calc.Value = 9223372036854775807;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sum() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sum()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sum()");
                }

                calc.Value = -9223372036854775808;
                calc.Value2 = 1;
                previousValue = calc.Value;

                if (!calc.sub() && calc.Value == previousValue)
                {
                    Console.WriteLine("Previous value restored after overflow in sub()");
                }
                else
                {
                    button.BackColor = Color.Red;
                    Unexpected("Value was not restored after overflow in sub()");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
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
            button14_Click(button14, null);
            button15_Click(button15, null);
            button16_Click(button16, null);
            button17_Click(button17, null);
            button18_Click(button18, null);
            button19_Click(button19, null);
            button20_Click(button20, null);


        }


    }
}