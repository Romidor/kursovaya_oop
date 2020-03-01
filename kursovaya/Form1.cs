using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox6.Text); int s6 = Convert.ToInt32(textBox11.Text);
            int s2 = Convert.ToInt32(textBox7.Text); int s7 = Convert.ToInt32(textBox12.Text);
            int s3 = Convert.ToInt32(textBox8.Text); int s8 = Convert.ToInt32(textBox13.Text);
            int s4 = Convert.ToInt32(textBox9.Text); int s9 = Convert.ToInt32(textBox14.Text);
            int s5 = Convert.ToInt32(textBox10.Text); int s10 = Convert.ToInt32(textBox15.Text);
            float a, b, c, d, bb; int n = 10;
            a = (s1+s2+s3+s4+s5+s6+s7+s8+s9+s10)/n;
            label1.Text = Convert.ToString(a);

            int s36 = Convert.ToInt32(textBox36.Text); int s41 = Convert.ToInt32(textBox41.Text);
            int s37 = Convert.ToInt32(textBox37.Text); int s42 = Convert.ToInt32(textBox42.Text);
            int s38 = Convert.ToInt32(textBox38.Text); int s43 = Convert.ToInt32(textBox43.Text);
            int s39 = Convert.ToInt32(textBox39.Text); int s44 = Convert.ToInt32(textBox44.Text);
            int s40 = Convert.ToInt32(textBox40.Text); int s45 = Convert.ToInt32(textBox45.Text);
            b = (s36 + s37 + s38 + s39 + s40 + s41 + s42 + s43 + s44 + s45) / n;
            label2.Text = Convert.ToString(b);

            int s46 = Convert.ToInt32(textBox46.Text); int s51 = Convert.ToInt32(textBox51.Text);
            int s47 = Convert.ToInt32(textBox47.Text); int s52 = Convert.ToInt32(textBox52.Text);
            int s48 = Convert.ToInt32(textBox48.Text); int s53 = Convert.ToInt32(textBox53.Text);
            int s49 = Convert.ToInt32(textBox49.Text); int s54 = Convert.ToInt32(textBox54.Text);
            int s50 = Convert.ToInt32(textBox50.Text); int s55 = Convert.ToInt32(textBox55.Text);
            c = (s46 + s47 + s48 + s49 + s50 + s51 + s52 + s53 + s54 + s55) / n;
            label3.Text = Convert.ToString(c);

            int s16 = Convert.ToInt32(textBox16.Text); int s21 = Convert.ToInt32(textBox21.Text);
            int s17 = Convert.ToInt32(textBox17.Text); int s22 = Convert.ToInt32(textBox22.Text);
            int s18 = Convert.ToInt32(textBox18.Text); int s23 = Convert.ToInt32(textBox23.Text);
            int s19 = Convert.ToInt32(textBox19.Text); int s24 = Convert.ToInt32(textBox24.Text);
            int s20 = Convert.ToInt32(textBox20.Text); int s25 = Convert.ToInt32(textBox25.Text);
            d = (s16 + s17 + s18 + s19 + s20 + s21 + s22 + s23 + s24 + s25) / n;
            label4.Text = Convert.ToString(d);

            int s26 = Convert.ToInt32(textBox26.Text); int s31 = Convert.ToInt32(textBox31.Text);
            int s27 = Convert.ToInt32(textBox27.Text); int s32 = Convert.ToInt32(textBox32.Text);
            int s28 = Convert.ToInt32(textBox28.Text); int s33 = Convert.ToInt32(textBox33.Text);
            int s29 = Convert.ToInt32(textBox29.Text); int s34 = Convert.ToInt32(textBox34.Text);
            int s30 = Convert.ToInt32(textBox30.Text); int s35 = Convert.ToInt32(textBox35.Text);
            bb = (s26 + s27 + s28 + s29 + s30 + s31 + s32 + s33 + s34 + s35) / n;
            label5.Text = Convert.ToString(bb);
        }

        private void TextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox11.Clear(); textBox21.Clear(); textBox31.Clear(); textBox41.Clear(); textBox51.Clear();
            textBox2.Clear(); textBox12.Clear(); textBox22.Clear(); textBox32.Clear(); textBox42.Clear(); textBox52.Clear();
            textBox3.Clear(); textBox13.Clear(); textBox23.Clear(); textBox33.Clear(); textBox43.Clear(); textBox53.Clear();
            textBox4.Clear(); textBox14.Clear(); textBox24.Clear(); textBox34.Clear(); textBox44.Clear(); textBox54.Clear();
            textBox5.Clear(); textBox15.Clear(); textBox25.Clear(); textBox35.Clear(); textBox45.Clear(); textBox55.Clear();
            textBox6.Clear(); textBox16.Clear(); textBox26.Clear(); textBox36.Clear(); textBox46.Clear();
            textBox7.Clear(); textBox17.Clear(); textBox27.Clear(); textBox37.Clear(); textBox47.Clear();
            textBox8.Clear(); textBox18.Clear(); textBox28.Clear(); textBox38.Clear(); textBox48.Clear();
            textBox9.Clear(); textBox19.Clear(); textBox29.Clear(); textBox39.Clear(); textBox49.Clear();
            textBox10.Clear();textBox20.Clear(); textBox30.Clear(); textBox40.Clear(); textBox50.Clear();

        }

        private void ИнструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripTextBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Долгов Е.И МОп -1703а 2020 год", "Информация о разработчике", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void ToolStripTextBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рада приветствовать Вас в этой небольшой программе, это окно предназначено для ознокомления с ней. Для работа с приложением заполните поля ФИО и поля оценок, а после нажмини на кнопку, чтобы посчитать результат. Справа от оценок будет среднее их число. К сожалению, это приложение находиться в тестовом режиме, поэтому пока доступно только такое количество оценок и учеников. Надеюсь, что ваша работа станет проще с этой программой.", "Инструкция", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
                );
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
