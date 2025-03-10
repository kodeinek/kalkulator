﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {


        public Kalkulator calc = new Kalkulator();
       

        private string currentInput = ""; // Aktualne wprowadzone wyrażenie
        private bool isResultShown = false; // Flaga do sprawdzania, czy wynik jest wyświetlany

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                currentInput = ""; // Jeśli wynik został pokazany, rozpoczynamy nowe wprowadzenie
                isResultShown = false;
            }

            Button button = sender as Button;
            if (button != null)
            {
                currentInput += button.Text; // Dodajemy cyfrę do aktualnego wyrażenia

                // Sprawdzamy, czy wprowadzenie jest prawidłowe
                try
                {
                    calc.Value = long.Parse(currentInput); // Przekształcamy aktualne wejście na long
                    calc.ConvertTextValue(true); // true powoduje, że HelpTextValue będzie zaktualizowane
                    textBox2.Text = calc.HelpTextValue; // Wyświetlamy pomocniczy tekst w textBox2
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wprowadź prawidłową liczbę.");
                }
                //catch (ArgumentOutOfRangeException)
                //{
                //    MessageBox.Show("Wartość poza zakresem."+ calc.Value);
                //}

                textBox1.Text = currentInput; // Aktualizujemy pole tekstowe
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                currentInput += " " + button.Text + " "; // Dodajemy operator z przestrzenią dla lepszej czytelności
                textBox1.Text = currentInput; // Aktualizujemy pole tekstowe
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double result = EvaluateExpression(currentInput); // Obliczamy wyrażenie
                textBox1.Text = result.ToString(); // Wyświetlamy wynik
                currentInput = result.ToString(); // Zapisujemy wynik jako aktualne wyrażenie
                isResultShown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message); // Wyświetlamy komunikat o błędzie
            }
        }

        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            currentInput += "("; // Dodajemy nawias otwierający
            textBox1.Text = currentInput;
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            currentInput += ")"; // Dodajemy nawias zamykający
            textBox1.Text = currentInput;
        }

        private double EvaluateExpression(string expression)
        {
            var table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, string.Empty)); // Obliczamy wyrażenie
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentInput = ""; // Resetujemy aktualne wyrażenie
            textBox1.Text = ""; // Resetujemy pole tekstowe
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)// helptext value po 2 bajty na linie 
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        // --------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button46_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Odznacz wszystkie elementy przed zaznaczeniem nowego
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != e.Index) checkedListBox1.SetItemChecked(i, false);
            }

            // Ustaw odpowiedni typ kalkulatora
            if (e.NewValue == CheckState.Checked)
            {
                switch (checkedListBox1.Items[e.Index].ToString())
                {
                    case "Hex":
                        calc.ValueType = Kalkulator.KalkulatorType.hex;
                        break;
                    case "Dec":
                        calc.ValueType = Kalkulator.KalkulatorType.dec;
                        break;
                    case "Oct":
                        calc.ValueType = Kalkulator.KalkulatorType.oct;
                        break;
                    case "Bin":
                        calc.ValueType = Kalkulator.KalkulatorType.bin;
                        break;
                }
                calc.ConvertTextValue(true); // Aktualizacja wartości i HelpTextValue
                textBox2.Text = calc.HelpTextValue;
                textBox1.Text = calc.TextValue;
            }
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Odznacz wszystkie elementy przed zaznaczeniem nowego
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (i != e.Index) checkedListBox2.SetItemChecked(i, false);
            }

            // Ustaw odpowiedni rozmiar słowa kalkulatora
            if (e.NewValue == CheckState.Checked)
            {
                switch (checkedListBox2.Items[e.Index].ToString())
                {
                    case "Qword":
                        calc.word_size = Kalkulator.WordSize.qword_;
                        break;
                    case "Dword":
                        calc.word_size = Kalkulator.WordSize.dword_;
                        break;
                    case "Word":
                        calc.word_size = Kalkulator.WordSize.word_;
                        break;
                    case "Bajt":
                        calc.word_size = Kalkulator.WordSize.byte_;
                        break;
                }
                calc.ConvertTextValue(true); // Aktualizacja wartości i HelpTextValue
                textBox2.Text = calc.HelpTextValue;
                textBox1.Text = calc.TextValue;
            }
        }

    }
}
