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
    public partial class EditStud : Form
    {
        public EditStud()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("INSERT INTO `студенты`(`ID`, `Фамилия`, `Имя`, `Отчество`, `Год поступления`, `Форма обучения`, `Номер группы`, `Название группы`) " +
                "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "'," +
                "'" + textBox3.Text + "','" + textBox4.Text + "'," +
                "'" + textBox5.Text + "','" + textBox6.Text + "'," +
                "'" + textBox7.Text + "','" + textBox8.Text + "')");
            Form2 rf = new Form2();
            rf.ShowDialog();
        }

        private void EditStud_Load(object sender, EventArgs e)
        {
            List<string> id = SQLClass.Select(
                "SELECT `ID` FROM `студенты` ORDER BY `студенты`.`ID` ASC");
            comboBox1.Items.AddRange(id.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("UPDATE `студенты` SET " +
                "`Фамилия`= '" + textBox10.Text + "'," +
                "`Имя`= '" + textBox11.Text + "'," +
                "`Отчество`= '" + textBox12.Text + "'," +
                "`Год поступления`= '" + textBox13.Text + "'," +
                "`Форма обучения`= '" + textBox14.Text + "'," +
                "`Номер группы`= '" + textBox15.Text + "'," +
                "`Название группы`= '" + textBox16.Text + "'" +
                "WHERE `ID`=" + comboBox1.Text + ";");

            Form2 rf = new Form2();
            rf.ShowDialog();
        }
    }
}
