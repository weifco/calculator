using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace лиман
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Разветвляющийся_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);
                double fx = 0;

                if (radioButtonCos.Checked)
                    fx = Math.Cos(x);
                else if (radioButtonSqr.Checked)
                    fx = x * x;           
                else if (radioButtonExp.Checked)
                    fx = Math.Exp(x);
                else
                {
                    MessageBox.Show("Выберите функцию");
                    return;
                }

                double a;
                if (x * y > 0)
                    a = Math.Log(y + 2) + fx;
                else if (x * y < 0)
                    a = Math.Log(Math.Abs(y)) - Math.Tan(fx);
                else
                    a = fx * y * y * y; 

                txtResult.Text = a.ToString("F4"); // 4 знака после запятой
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }

        }


        private void buttonCalculateClick_Click(object sender, EventArgs e)
        {
             
            // получаем значения X, Y, Z из текстовых полей
            double x = Convert.ToDouble(txtBoxX.Text);
            double y = Convert.ToDouble(txtBoxY.Text);
            double z = Convert.ToDouble(txtBoxZ.Text);

            // вычисляем результат по формуле
            double result = Math.Pow(x, 2) * Math.Cos(x - y / z) / (0.5 + Math.Sin(y)) * (1 + Math.Pow(z, 2) / 5);

            // выводим результат в текстовое поле
            textBoxResult2.Text = result.ToString();
        }
        

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





