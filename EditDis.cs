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
    public partial class EditDis : Form
    {
        public EditDis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("INSERT INTO `план`(`Специальность`, `Дисциплина`, `Семестр`, `Количество часов`, `Форма отчетности`) " +
               "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "'," +
               "'" + textBox3.Text + "','" + textBox4.Text + "'," +
               "'" + textBox5.Text + "')");
            Form2 rf = new Form2();
            rf.ShowDialog();
        }

        private void EditDis_Load(object sender, EventArgs e)
        {
            List<string> id = SQLClass.Select(
                "SELECT `Дисциплина` FROM `план` ORDER BY `план`.`Дисциплина` ASC");
            comboBox1.Items.AddRange(id.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("UPDATE `план` SET " +
                "`Специальность`= '" + textBox6.Text + "'," +
                "`Семестр`= '" + textBox8.Text + "'," +
                "`Количество часов`= '" + textBox9.Text + "'," +
                "`Форма отчетности`= '" + textBox10.Text + "'" +
                "WHERE `Дисциплина`='" + comboBox1.Text + "';");

            Form2 rf = new Form2();
            rf.ShowDialog();
        }
    }
}
