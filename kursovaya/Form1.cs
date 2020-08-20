using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class ClassJournal : Form
    {
        private List<Student> students;

        public ClassJournal()
        {
            InitializeComponent();
            students = new List<Student>(5);
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student());
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            students[0].SetName(textBox1.Text);
            students[0].AddMark(Convert.ToInt32(textBox6.Text));
            students[0].AddMark(Convert.ToInt32(textBox7.Text));
            students[0].AddMark(Convert.ToInt32(textBox8.Text));
            students[0].AddMark(Convert.ToInt32(textBox9.Text));
            students[0].AddMark(Convert.ToInt32(textBox10.Text));
            students[0].AddMark(Convert.ToInt32(textBox11.Text));
            students[0].AddMark(Convert.ToInt32(textBox12.Text));
            students[0].AddMark(Convert.ToInt32(textBox13.Text));
            students[0].AddMark(Convert.ToInt32(textBox14.Text));
            students[0].AddMark(Convert.ToInt32(textBox15.Text));
            label1.Text = Convert.ToString(students[0].GetAverageMark());

            students[1].SetName(textBox2.Text);
            students[1].AddMark(Convert.ToInt32(textBox36.Text));
            students[1].AddMark(Convert.ToInt32(textBox37.Text));
            students[1].AddMark(Convert.ToInt32(textBox38.Text));
            students[1].AddMark(Convert.ToInt32(textBox39.Text));
            students[1].AddMark(Convert.ToInt32(textBox40.Text));
            students[1].AddMark(Convert.ToInt32(textBox41.Text));
            students[1].AddMark(Convert.ToInt32(textBox42.Text));
            students[1].AddMark(Convert.ToInt32(textBox43.Text));
            students[1].AddMark(Convert.ToInt32(textBox44.Text));
            students[1].AddMark(Convert.ToInt32(textBox45.Text));
            label2.Text = Convert.ToString(students[1].GetAverageMark());

            students[2].SetName(textBox3.Text);
            students[2].AddMark(Convert.ToInt32(textBox46.Text));
            students[2].AddMark(Convert.ToInt32(textBox47.Text));
            students[2].AddMark(Convert.ToInt32(textBox48.Text));
            students[2].AddMark(Convert.ToInt32(textBox49.Text));
            students[2].AddMark(Convert.ToInt32(textBox50.Text));
            students[2].AddMark(Convert.ToInt32(textBox51.Text));
            students[2].AddMark(Convert.ToInt32(textBox52.Text));
            students[2].AddMark(Convert.ToInt32(textBox53.Text));
            students[2].AddMark(Convert.ToInt32(textBox54.Text));
            students[2].AddMark(Convert.ToInt32(textBox55.Text));
            label3.Text = Convert.ToString(students[2].GetAverageMark());

            students[3].SetName(textBox4.Text);
            students[3].AddMark(Convert.ToInt32(textBox16.Text));
            students[3].AddMark(Convert.ToInt32(textBox17.Text));
            students[3].AddMark(Convert.ToInt32(textBox18.Text));
            students[3].AddMark(Convert.ToInt32(textBox19.Text));
            students[3].AddMark(Convert.ToInt32(textBox20.Text));
            students[3].AddMark(Convert.ToInt32(textBox21.Text));
            students[3].AddMark(Convert.ToInt32(textBox22.Text));
            students[3].AddMark(Convert.ToInt32(textBox23.Text));
            students[3].AddMark(Convert.ToInt32(textBox24.Text));
            students[3].AddMark(Convert.ToInt32(textBox25.Text));
            label4.Text = Convert.ToString(students[3].GetAverageMark());

            students[4].SetName(textBox5.Text);
            students[4].AddMark(Convert.ToInt32(textBox26.Text));
            students[4].AddMark(Convert.ToInt32(textBox27.Text));
            students[4].AddMark(Convert.ToInt32(textBox28.Text));
            students[4].AddMark(Convert.ToInt32(textBox29.Text));
            students[4].AddMark(Convert.ToInt32(textBox30.Text));
            students[4].AddMark(Convert.ToInt32(textBox31.Text));
            students[4].AddMark(Convert.ToInt32(textBox32.Text));
            students[4].AddMark(Convert.ToInt32(textBox33.Text));
            students[4].AddMark(Convert.ToInt32(textBox34.Text));
            students[4].AddMark(Convert.ToInt32(textBox35.Text));
            label5.Text = Convert.ToString(students[4].GetAverageMark());
        }

        private void TextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            //не очищаем поля с фио учеников
            /*textBox1.Clear(); 
            textBox2.Clear(); 
            textBox3.Clear(); 
            textBox4.Clear(); 
            textBox5.Clear();*/
            textBox11.Clear(); textBox21.Clear(); textBox31.Clear(); textBox41.Clear(); textBox51.Clear();
            textBox12.Clear(); textBox22.Clear(); textBox32.Clear(); textBox42.Clear(); textBox52.Clear();
            textBox13.Clear(); textBox23.Clear(); textBox33.Clear(); textBox43.Clear(); textBox53.Clear();
            textBox14.Clear(); textBox24.Clear(); textBox34.Clear(); textBox44.Clear(); textBox54.Clear();
            textBox15.Clear(); textBox25.Clear(); textBox35.Clear(); textBox45.Clear(); textBox55.Clear();
            textBox6.Clear(); textBox16.Clear(); textBox26.Clear(); textBox36.Clear(); textBox46.Clear();
            textBox7.Clear(); textBox17.Clear(); textBox27.Clear(); textBox37.Clear(); textBox47.Clear();
            textBox8.Clear(); textBox18.Clear(); textBox28.Clear(); textBox38.Clear(); textBox48.Clear();
            textBox9.Clear(); textBox19.Clear(); textBox29.Clear(); textBox39.Clear(); textBox49.Clear();
            textBox10.Clear();textBox20.Clear(); textBox30.Clear(); textBox40.Clear(); textBox50.Clear();

            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
            label4.ResetText();
            label5.ResetText();

            foreach (Student s in students)
            {
                s.RemoveMarks();
            }
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
            MessageBox.Show("Рада приветствовать Вас в этой небольшой программе, это окно предназначено для ознакомления с ней. Для работы с приложением заполните поля ФИО и поля оценок, а после нажмите на кнопку, чтобы посчитать результат. Справа от оценок будет показано их среднее арифметическое. К сожалению, это приложение находится в тестовом режиме, поэтому пока доступно только такое количество оценок и учеников. Надеюсь, что ваша работа станет проще с этой программой.", "Инструкция", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
                );
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ClassJournal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //show rating
        {
            string rating = ""; //TODO: create rating from list of students
            students.Sort(compareStudents);
            foreach(Student s in students)
            {
                rating = rating + s.GetName() + ": " + s.GetAverageMark() + '\n';
            }
            MessageBox.Show(rating, "Рейтинг учеников", MessageBoxButtons.OK);
        }

        private int compareStudents(Student a, Student b)
        {
            if (a.GetAverageMark() > b.GetAverageMark())
                return -1;
            else if (a.GetAverageMark() == b.GetAverageMark())
                return 0;
            else return 1;
        }
    }
}
