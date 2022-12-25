using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekanat
{
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 130;

            if (comboBox1.Text == "Алгебраические структуры")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Алгебраические структуры'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Анатомия")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Анатомия'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Английский язык")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Английский язык'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Гистология")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Гистология'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "История")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'История'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Латинский язык")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Латинский язык'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Математический анализ")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Математический анализ'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Немецкий язык")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Немецкий язык'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Обществознание")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Обществознание'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Организация ЭВМ и систем")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Организация ЭВМ и систем'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Право")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Право'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Программирование")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Программирование'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Психология общения")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Психология общения'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Русский язык")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Русский язык'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Социология")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Социология'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Теория информации")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Теория информации'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Физика")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Физика'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Физиология")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Физиология'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Философия")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Философия'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "Французский язык")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Количество часов` , `Форма отчетности` FROM `план` WHERE `Дисциплина` = 'Французский язык'");

                for (int i = 0; i < students.Count; i += 2)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + "                  " + students[i + 1];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            button1.Enabled = false;
        }
    }
}
