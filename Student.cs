using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;


namespace Dekanat
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 100;

            if (comboBox1.Text == "очная")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT * FROM `студенты` WHERE `Форма обучения` = 'очная' ORDER BY `ID` ASC");

                for (int i = 0; i < students.Count; i += 8)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(15, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + " " + students[i + 1] + " " + students[i+2] + " " +
                        students[i + 3] + " " + students[i + 4] + " " + students[i + 5] + " " + 
                        students[i + 6] + " " + students[i + 7];
                    Controls.Add(lbl);
                    y += 30;
                }

            }

            if (comboBox1.Text == "вечерняя")
            {
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT * FROM `студенты` WHERE `Форма обучения` = 'вечерняя' ORDER BY `ID` ASC");
                for (int i = 0; i < students.Count; i += 8)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(12, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + " " + students[i + 1] + " " + students[i + 2] + " " +
                        students[i + 3] + " " + students[i + 4] + " " + students[i + 5] + " " +
                        students[i + 6] + " " + students[i + 7];
                    Controls.Add(lbl);
                    y += 30;
                }
            }

            if (comboBox1.Text == "заочная")
            {                
                System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT * FROM `студенты` WHERE `Форма обучения` = 'заочная' ORDER BY `ID` ASC");
                for (int i = 0; i < students.Count; i += 8)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(12, y);
                    lbl.Size = new Size(800, 30);
                    lbl.Text = students[i] + " " + students[i + 1] + " " + students[i + 2] + " " +
                        students[i + 3] + " " + students[i + 4] + " " + students[i + 5] + " " +
                        students[i + 6] + " " + students[i + 7];
                    Controls.Add(lbl);
                    y += 30;
                }
            }

            button1.Enabled = false;
        }

    }   
}
