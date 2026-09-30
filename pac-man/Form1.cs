using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pac_man
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            play_button.Hide();
            title_label.Hide();
            pac_picture.Hide();
            
            easy_button.Visible = true;
            easy_button.Enabled = true;
            difficult_button.Visible = true;
            difficult_button.Enabled = true;
            label1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            label1.Visible = false;
            easy_button.Visible = false;
            difficult_button.Visible = false;
        }

        private void easy_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void difficult_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
