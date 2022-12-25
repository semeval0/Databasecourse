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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student rf = new Student();
            rf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditDis rf = new EditDis();
            rf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditStud rf = new EditStud();
            rf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Discipline rf = new Discipline();
            rf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditMark rf = new EditMark();
            rf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Spravka rf = new Spravka();
            rf.ShowDialog();
        }
    }
}
