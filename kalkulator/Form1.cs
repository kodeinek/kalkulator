using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        private string currentInput = ""; // Текущее введенное выражение
        private bool isResultShown = false; // Флаг для проверки, отображен ли результат
        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (isResultShown)
            {
                currentInput = ""; // Если был результат, начинаем ввод заново
                isResultShown = false;
            }

            Button button = sender as Button;
            if (button != null)
            {
                currentInput += button.Text; // Добавляем цифру в текущее выражение
                textBox1.Text = currentInput; // Обновляем текстовое поле
            }
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                currentInput += " " + button.Text + " "; // Добавляем операцию с пробелами для читаемости
                textBox1.Text = currentInput; // Обновляем текстовое поле
            }
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double result = EvaluateExpression(currentInput); // Вычисляем выражение
                textBox1.Text = result.ToString(); // Отображаем результат
                currentInput = result.ToString(); // Сохраняем результат как текущее выражение
                isResultShown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message); // Выводим сообщение об ошибке
            }
        }
        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            currentInput += "("; // Добавляем открывающую скобку
            textBox1.Text = currentInput;
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            currentInput += ")"; // Добавляем закрывающую скобку
            textBox1.Text = currentInput;
        }
        private double EvaluateExpression(string expression)
        {
            var table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, string.Empty)); // Вычисляем выражение
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentInput = ""; // Очищаем текущее выражение
            textBox1.Text = ""; // Очищаем текстовое поле
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //main window
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)// helptext value po 2 bajty na linie 
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
