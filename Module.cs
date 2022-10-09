using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendence
{
    public partial class Module : Form
    {
        public Module()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateLesson cl = new CreateLesson();
            cl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAssignment ca = new CreateAssignment();
            ca.Show();
            this.Hide();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Submissions s = new Submissions();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TeacherInterface tf = new TeacherInterface();
            tf.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
