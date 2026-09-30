using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace pac_man
{    
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
        }

        int score = 0;
        int high_score = 0;
        int x = 0; int y = 0;

        Random rnd = new Random();       
        
        PictureBox white_cherries = new PictureBox();        
        PictureBox red_cherries = new PictureBox(); 
        PictureBox invisible = new PictureBox();
        PictureBox invisible_red_cherry = new PictureBox();
        PictureBox invisible_white_cherry = new PictureBox();

        Point next_location = new Point(0, 0);
        Point white_cherry_center = new Point(0, 0);
        Point red_cherry_center = new Point(0, 0);

        List<PictureBox> walls = new List<PictureBox>();

        int time1, time2, time3, time2a, time3a;

        bool ate_white, ate_red;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1 -= 1;
            time_label.Text = "Time left : " + time1 + "s";

            if (time1 == 0)
            {
                timer1.Stop();
                if (score > high_score) {
                    high_score = score;
                    MessageBox.Show("Νέο high score: " + high_score + "!");
                }
                else
                {
                    MessageBox.Show("Ο χρόνος σου τελείωσε. Το σκόρ σου είναι : " + score + ". Highest score : " + high_score + "." );
                }
            }

            time2 -= 1;
            if (time2 == 0)
            {
                remove_white_cherry();
                add_white_cherry();
            }

            time3 -= 1;
            if (time3 == 0)
            {
                remove_red_cherry();
                add_red_cherry();
            }

            if (ate_white)
            {
                time2a -= 1;
                if (time2a == 0)
                {
                    add_white_cherry();
                    time2a = 2;
                    ate_white = false;
                }
            }

            if (ate_red) {
                time3a -= 1;
                if (time3a == 0)
                {
                    add_red_cherry();
                    time3a = 2;
                    ate_red = false;
                }                
            }
        }       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void retryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
            score = 0;
            time1 = 60; time2 = 10; time3 = 5;
        }
    
        private void Form2_Load(object sender, EventArgs e)
        {
            walls.Add(wall1); walls.Add(wall2); walls.Add(wall3); walls.Add(wall4); 
            walls.Add(wall5); walls.Add(wall6); walls.Add(wall7); walls.Add(pictureBox1);
            //picturebox1 είναι το εσωτερικό του # στο οποίο δεν θέλουμε να βρεθεί κάποιο κεράσι          
           
            invisible.Location = new Point(30, 30);
            invisible.Size = new Size(75,75);
            invisible.Visible = false;

            time1 = 60;
            time2 = 10;
            time3 = 5;
            time2a = 2;
            time3a = 2;

            highscore_label.Text = "Highscore: " + high_score.ToString();

            timer1.Start();
                       
            white_cherries.Image = Properties.Resources.white_cherries__2_;
            white_cherries.Size = new Size(50, 50);            
            white_cherries.SizeMode = PictureBoxSizeMode.Zoom;
            add_white_cherry();

            invisible_white_cherry.Size = white_cherries.Size;
            invisible_white_cherry.Visible = false;

            red_cherries.Image = Properties.Resources.cherries__3_;
            red_cherries.Size = new Size(30, 30);
            red_cherries.SizeMode = PictureBoxSizeMode.Zoom;
            add_red_cherry();

            invisible_red_cherry.Size = red_cherries.Size;
            invisible_red_cherry.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void add_red_cherry()
        {
            if (time1 > 0) // when time1 == 0 it stops
            {
                bool b1 = false;
                while (!b1)
                {
                    x = rnd.Next(1, 900);
                    y = rnd.Next(1, 450);
                    next_location = new Point(x, y);
                    invisible_red_cherry.Location = next_location;
                    if (!(invisible_red_cherry.Bounds.IntersectsWith(panel1.Bounds)))
                    {
                        if (check(invisible_red_cherry))
                        {
                            red_cherries.Location = new Point(x, y);
                            this.Controls.Add(red_cherries);
                            time3 = 5;
                            b1 = true;
                        }
                    }
                }
                red_cherry_center = new Point(red_cherries.Left + red_cherries.Width / 2, red_cherries.Top + red_cherries.Height / 2);
            }
        }

        public void remove_red_cherry()
        {
            this.Controls.Remove(red_cherries);
        }        

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //pac man movement
            if (time1 > 0)
            {
                if (e.KeyCode == Keys.Down)
                {
                    pac_man.Image = Properties.Resources.Pac_Man_Down_svg;
                    next_location = new Point(pac_man.Location.X, pac_man.Location.Y + 15);
                    invisible.Location = next_location;
                    //pacman finds wall
                    if (check(invisible))
                    {
                        pac_man.Location = new Point(pac_man.Location.X, pac_man.Location.Y + 15);
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    pac_man.Image = Properties.Resources.Pac_Man_Up_svg;
                    next_location = new Point(pac_man.Location.X, pac_man.Location.Y - 15);
                    invisible.Location = next_location;
                    if (check(invisible))
                    {
                        pac_man.Location = new Point(pac_man.Location.X, pac_man.Location.Y - 15);
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    pac_man.Image = Properties.Resources.Pac_Man_svg;
                    next_location = new Point(pac_man.Location.X + 15, pac_man.Location.Y);
                    invisible.Location = next_location;
                    if (check(invisible))
                    {
                        pac_man.Location = new Point(pac_man.Location.X + 15, pac_man.Location.Y);
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    pac_man.Image = Properties.Resources.Pac_Man_Back_svg;
                    next_location = new Point(pac_man.Location.X - 15, pac_man.Location.Y);
                    invisible.Location = next_location;
                    if (check(invisible))
                    {
                        pac_man.Location = new Point(pac_man.Location.X - 15, pac_man.Location.Y);
                    }
                }
                //Teleportation
                if (pac_man.Left < -10)
                {
                    pac_man.Left = 950;
                }
                if (pac_man.Left > 950)
                {
                    pac_man.Left = 10;
                }
                if (pac_man.Top < 10)
                {
                    pac_man.Top = 500;
                }
                if (pac_man.Top > 500)
                {
                    pac_man.Top = 10;
                }

                //pac man eats cherries
                if (pac_man.Bounds.Contains(white_cherry_center))
                {
                    remove_white_cherry();
                    score += 1;
                    white_cherry_center = new Point(1000, 500);
                    ate_white = true;
                }

                if (pac_man.Bounds.Contains(red_cherry_center))
                {
                    remove_red_cherry();
                    score += 2;
                    red_cherry_center = new Point(1000, 500);
                    ate_red = true;
                }
            }
            score_label.Text = "Score : " + score.ToString();
        }


        public void add_white_cherry()
        {
            if (time1 > 0) // when time1 == 0 it stops
            {
                bool b1 = false;
                while (!b1)
                {
                    x = rnd.Next(5, 900);
                    y = rnd.Next(5, 450);
                    next_location = new Point(x, y);
                    invisible_white_cherry.Location = next_location;
                    if (!(invisible_white_cherry.Bounds.IntersectsWith(panel1.Bounds)))
                    {
                        if (check(invisible_white_cherry))
                        {
                            white_cherries.Location = new Point(x, y);
                            this.Controls.Add(white_cherries);
                            time2 = 10;
                            b1 = true;
                        }
                    }
                }
                white_cherry_center = new Point(white_cherries.Left + white_cherries.Width / 2, white_cherries.Top + white_cherries.Height / 2);
            }
        }

        public void remove_white_cherry() 
        {
            this.Controls.Remove(white_cherries);
        }
        
        //checks that pac man or cherries do not touch any walls
        public bool check(PictureBox p)
        {
            bool b = false;
            int wall_count = 0;            
            foreach (PictureBox w in walls)
            {
                if (!(p.Bounds.IntersectsWith(w.Bounds)))
                {
                    wall_count++;
                }
            }

            if (wall_count == walls.Count) b = true;
                      
            return b;
        }
    }
}
