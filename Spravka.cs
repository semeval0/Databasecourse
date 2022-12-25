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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void Spravka_Load(object sender, EventArgs e)
        {
            List<string> id = SQLClass.Select(
               "SELECT `ID` FROM `студенты` ORDER BY `ID` ASC");
            comboBox1.Items.AddRange(id.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 150;

            System.Collections.Generic.List<string> students = SQLClass.Select(
                "SELECT `Семестр` , `Дисциплина` , `Оценка` FROM `успеваемость` " +
                "WHERE `Студент` =" + comboBox1.Text + ";");

            for (int i = 0; i < students.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(15, y);
                lbl.Size = new Size(800, 30);
                lbl.Text = students[i] + "                       " + students[i + 1] + 
                    "                       " + students[i + 2];
                Controls.Add(lbl);
                y += 30;
            }
        }
    }
}
