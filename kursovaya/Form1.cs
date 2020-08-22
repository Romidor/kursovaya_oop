using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private FileStream data;
        private const string file = "journal.txt";

        public ClassJournal()
        {
            InitializeComponent();
            students = new List<Student>(5);
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student());
            }
            
            if (!File.Exists(file))
            {
                data = new FileStream(file, FileMode.CreateNew);
            } 
            else
            {
                data = new FileStream(file, FileMode.Open);
                StreamReader reader = new StreamReader(data);

                string[] fios = reader.ReadLine().Split(' ');
                TextBox[] boxesFio = { textBox1, textBox2, textBox3, textBox4, textBox5 };
                SetUpData(fios, boxesFio);

                TextBox[] marks1tb = { textBox6, textBox36, textBox46, textBox16, textBox26 };
                TextBox[] marks2tb = { textBox7, textBox37, textBox47, textBox17, textBox27 };
                TextBox[] marks3tb = { textBox8, textBox38, textBox48, textBox18, textBox28 };
                TextBox[] marks4tb = { textBox9, textBox39, textBox49, textBox19, textBox29 };
                TextBox[] marks5tb = { textBox10, textBox40, textBox50, textBox20, textBox30 };
                TextBox[] marks6tb = { textBox11, textBox41, textBox51, textBox21, textBox31 };
                TextBox[] marks7tb = { textBox12, textBox42, textBox52, textBox23, textBox32 };
                TextBox[] marks8tb = { textBox13, textBox43, textBox53, textBox22, textBox33 };
                TextBox[] marks9tb = { textBox14, textBox44, textBox54, textBox25, textBox34 };
                TextBox[] marks10tb = { textBox15, textBox45, textBox55, textBox24, textBox35 };
                TextBox[] propusktb = { textBoxPropusk1, textBoxPropusk2, textBoxPropusk3, textBoxPropusk4, textBoxPropusk5 };
                SetUpData(reader.ReadLine().Split(' '), marks1tb);
                SetUpData(reader.ReadLine().Split(' '), marks2tb);
                SetUpData(reader.ReadLine().Split(' '), marks3tb);
                SetUpData(reader.ReadLine().Split(' '), marks4tb);
                SetUpData(reader.ReadLine().Split(' '), marks5tb);
                SetUpData(reader.ReadLine().Split(' '), marks6tb);
                SetUpData(reader.ReadLine().Split(' '), marks7tb);
                SetUpData(reader.ReadLine().Split(' '), marks8tb);
                SetUpData(reader.ReadLine().Split(' '), marks9tb);
                SetUpData(reader.ReadLine().Split(' '), marks10tb);
                SetUpData(reader.ReadLine().Split(' '), propusktb);
                reader.Close();
                data.Close();
            }
        }

        private void SetUpData(string[] data, TextBox[] textBoxes)
        {
            for (int i = 0; i < 5; i++)
            {
                if (!data[i].Equals("-"))
                {
                    textBoxes[i].AppendText(data[i]);
                }
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
            students[0].SetMissedClassesCount(Convert.ToInt32(textBoxPropusk1.Text));
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
            students[1].SetMissedClassesCount(Convert.ToInt32(textBoxPropusk2.Text));
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
            students[2].SetMissedClassesCount(Convert.ToInt32(textBoxPropusk3.Text));
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
            students[3].SetMissedClassesCount(Convert.ToInt32(textBoxPropusk4.Text));
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
            students[4].SetMissedClassesCount(Convert.ToInt32(textBoxPropusk5.Text));
            label5.Text = Convert.ToString(students[4].GetAverageMark());
        }

        private void TextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            //оценки
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

            //средний балл
            label1.ResetText();
            label2.ResetText();
            label3.ResetText();
            label4.ResetText();
            label5.ResetText();

            //пропуски занятий
            textBoxPropusk1.Clear();
            textBoxPropusk2.Clear();
            textBoxPropusk3.Clear();
            textBoxPropusk4.Clear();
            textBoxPropusk5.Clear();

            foreach (Student s in students)
            {
                s.RemoveMarks();
                s.SetMissedClassesCount(0);
            }

            data = new FileStream(file, FileMode.Open);
            StreamReader reader = new StreamReader(data);
            string firstLine = reader.ReadLine();
            reader.Close();
            data.Close();
            data = new FileStream(file, FileMode.Truncate);
            StreamWriter writer = new StreamWriter(data);
            writer.WriteLine(firstLine);
            writer.Close();
            data.Close();
        }

        private void ИнструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void ToolStripTextBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Долгов Е.И МОп -1703а 2020 год", "Информация о разработчике", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void ToolStripTextBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рада приветствовать Вас в этой небольшой программе, это окно предназначено для ознакомления с ней. Для работы с приложением заполните поля ФИО и поля оценок, а после нажмите на кнопку, чтобы посчитать результат. Справа от оценок будет показано их среднее арифметическое. Введенные данные можно сохранить нажатием кнопки \"Сохранить\". Также данные будут автоматически сохранены при выходе из приложения с помощью пункта меню \"Выход\". К сожалению, это приложение находится в тестовом режиме, поэтому пока доступно только такое количество оценок и учеников. Надеюсь, что ваша работа станет проще с этой программой.", "Инструкция", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
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
            string rating = "";
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

        private void button3_Click(object sender, EventArgs e) //save data into a file
        {
            SaveData();
        }

        private void SaveData()
        {
            data = new FileStream(file, FileMode.Truncate);
            StreamWriter writer = new StreamWriter(data);

            TextBox[] boxesFio = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            TextBox[] marks1tb = { textBox6, textBox36, textBox46, textBox16, textBox26 };
            TextBox[] marks2tb = { textBox7, textBox37, textBox47, textBox17, textBox27 };
            TextBox[] marks3tb = { textBox8, textBox38, textBox48, textBox18, textBox28 };
            TextBox[] marks4tb = { textBox9, textBox39, textBox49, textBox19, textBox29 };
            TextBox[] marks5tb = { textBox10, textBox40, textBox50, textBox20, textBox30 };
            TextBox[] marks6tb = { textBox11, textBox41, textBox51, textBox21, textBox31 };
            TextBox[] marks7tb = { textBox12, textBox42, textBox52, textBox23, textBox32 };
            TextBox[] marks8tb = { textBox13, textBox43, textBox53, textBox22, textBox33 };
            TextBox[] marks9tb = { textBox14, textBox44, textBox54, textBox25, textBox34 };
            TextBox[] marks10tb = { textBox15, textBox45, textBox55, textBox24, textBox35 };
            TextBox[] propusktb = { textBoxPropusk1, textBoxPropusk2, textBoxPropusk3, textBoxPropusk4, textBoxPropusk5 };
            writer.WriteLine(CreateLine(boxesFio));
            writer.WriteLine(CreateLine(marks1tb));
            writer.WriteLine(CreateLine(marks2tb));
            writer.WriteLine(CreateLine(marks3tb));
            writer.WriteLine(CreateLine(marks4tb));
            writer.WriteLine(CreateLine(marks5tb));
            writer.WriteLine(CreateLine(marks6tb));
            writer.WriteLine(CreateLine(marks7tb));
            writer.WriteLine(CreateLine(marks8tb));
            writer.WriteLine(CreateLine(marks9tb));
            writer.WriteLine(CreateLine(marks10tb));
            writer.WriteLine(CreateLine(propusktb));

            writer.Flush();
            writer.Close();
            data.Close();
        }

        private string CreateLine(TextBox[] boxes)
        {
            string line = "";
            for (int i = 0; i < boxes.Length - 1; i++)
            {
                line = line + GetStr(boxes[i]) + ' ';
            }
            line = line + GetStr(boxes[boxes.Length - 1]);
            return line;
        }

        private string GetStr(TextBox textBox)
        {
            string result = textBox.Text;
            if (result.Equals(""))
            {
                return "-";
            } else
            {
                return result;
            }
        }
    }
}
