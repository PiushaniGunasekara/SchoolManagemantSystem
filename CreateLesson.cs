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
    public partial class CreateLesson : Form
    {
        public CreateLesson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Module m = new Module();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected file 
                textBox2.Text = ofd.FileName;
        }
    }
}
