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
    public partial class EditMark : Form
    {
        public EditMark()
        {
            InitializeComponent();
        }

        private void EditMark_Load(object sender, EventArgs e)
        {
            List<string> id = SQLClass.Select(
                "SELECT `ID` FROM `студенты` ORDER BY `ID` ASC");
            comboBox1.Items.AddRange(id.ToArray());

            List<string> sem = SQLClass.Select(
                "SELECT `Семестр` FROM `план` GROUP BY `Семестр`");
            comboBox2.Items.AddRange(sem.ToArray());

            List<string> d = SQLClass.Select(
                "SELECT `Дисциплина` FROM `план` ORDER BY `план`.`Дисциплина` ASC");
            comboBox3.Items.AddRange(d.ToArray());

            List<string> id1 = SQLClass.Select(
                "SELECT `ID` FROM `студенты` ORDER BY `ID` ASC");
            comboBox4.Items.AddRange(id1.ToArray());

            List<string> sem1 = SQLClass.Select(
                "SELECT `Семестр` FROM `план` GROUP BY `Семестр`");
            comboBox5.Items.AddRange(sem1.ToArray());

            List<string> d1 = SQLClass.Select(
                "SELECT `Дисциплина` FROM `план` ORDER BY `план`.`Дисциплина` ASC");
            comboBox6.Items.AddRange(d1.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("INSERT INTO `успеваемость`(`Студент`, `Семестр`, `Дисциплина`, `Оценка`) " +
               "VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "'," +
               "'" + comboBox3.Text + "','" + textBox4.Text + "')");

            Form2 rf = new Form2();
            rf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("UPDATE `успеваемость` SET " +
               "`Семестр`= '" + comboBox5.Text + "'," +
               "`Дисциплина`= '" + comboBox6.Text + "'," +
               "`Оценка`= '" + textBox1.Text + "'" +
               "WHERE `Студент`='" + comboBox4.Text + "';");

            Form2 rf = new Form2();
            rf.ShowDialog();
        }
    }
}
