using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // описываем переменные
            double x,y,c;
            // пытаем преобразовать строку из textBox1.Text в целое число
            bool rez1 = double.TryParse(textBox1.Text, out x);
            if (rez1 == false) // если возникла ли ошибка преобразования
            {                  // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                return; // заканчиваем работу метода
            }
            // пытаем преобразовать строку из textBox2.Text в целое число
            bool rez2 = double.TryParse(textBox2.Text, out y);
            if (rez2 == false) // если возникла ли ошибка преобразования
            {                  // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + textBox2.Text + "!");
                return; 
            }
            c = 2 * (Math.Sin(x) + Math.Cos(y));
            string cStr = c.ToString();
            label2.Text = cStr;
            return; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
