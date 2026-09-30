namespace pac_man
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.highscore_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.wall6 = new System.Windows.Forms.PictureBox();
            this.wall5 = new System.Windows.Forms.PictureBox();
            this.wall7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pac_man = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pac_man)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(68, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.retryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // retryToolStripMenuItem
            // 
            this.retryToolStripMenuItem.Name = "retryToolStripMenuItem";
            this.retryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.retryToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.retryToolStripMenuItem.Text = "Retry";
            this.retryToolStripMenuItem.Click += new System.EventHandler(this.retryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.highscore_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.time_label);
            this.panel1.Controls.Add(this.score_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 28);
            this.panel1.TabIndex = 3;
            // 
            // highscore_label
            // 
            this.highscore_label.AutoSize = true;
            this.highscore_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.highscore_label.ForeColor = System.Drawing.Color.White;
            this.highscore_label.Location = new System.Drawing.Point(235, 4);
            this.highscore_label.Name = "highscore_label";
            this.highscore_label.Size = new System.Drawing.Size(117, 20);
            this.highscore_label.TabIndex = 7;
            this.highscore_label.Text = "Highscore: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(595, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Easy mode";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(1021, 4);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(131, 20);
            this.time_label.TabIndex = 4;
            this.time_label.Text = "Time left : 60s";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.score_label.ForeColor = System.Drawing.Color.White;
            this.score_label.Location = new System.Drawing.Point(1207, 4);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(86, 20);
            this.score_label.TabIndex = 3;
            this.score_label.Tag = "";
            this.score_label.Text = "Score : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(846, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall1.Location = new System.Drawing.Point(255, 210);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(30, 250);
            this.wall1.TabIndex = 4;
            this.wall1.TabStop = false;
            this.wall1.Tag = "wall";
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall2.Location = new System.Drawing.Point(255, 196);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(250, 30);
            this.wall2.TabIndex = 5;
            this.wall2.TabStop = false;
            this.wall2.Tag = "wall";
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall3.Location = new System.Drawing.Point(255, 441);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(250, 30);
            this.wall3.TabIndex = 6;
            this.wall3.TabStop = false;
            this.wall3.Tag = "wall";
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall4.Location = new System.Drawing.Point(805, 134);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(30, 420);
            this.wall4.TabIndex = 7;
            this.wall4.TabStop = false;
            this.wall4.Tag = "wall";
            // 
            // wall6
            // 
            this.wall6.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall6.Location = new System.Drawing.Point(971, 134);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(30, 420);
            this.wall6.TabIndex = 8;
            this.wall6.TabStop = false;
            this.wall6.Tag = "wall";
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall5.Location = new System.Drawing.Point(688, 222);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(420, 30);
            this.wall5.TabIndex = 9;
            this.wall5.TabStop = false;
            this.wall5.Tag = "wall";
            // 
            // wall7
            // 
            this.wall7.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall7.Location = new System.Drawing.Point(697, 415);
            this.wall7.Name = "wall7";
            this.wall7.Size = new System.Drawing.Size(420, 30);
            this.wall7.TabIndex = 10;
            this.wall7.TabStop = false;
            this.wall7.Tag = "wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(841, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 151);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pac_man
            // 
            this.pac_man.Image = global::pac_man.Properties.Resources.Pac_Man_svg;
            this.pac_man.Location = new System.Drawing.Point(70, 100);
            this.pac_man.Name = "pac_man";
            this.pac_man.Size = new System.Drawing.Size(85, 85);
            this.pac_man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pac_man.TabIndex = 12;
            this.pac_man.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1325, 653);
            this.Controls.Add(this.pac_man);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wall7);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.wall6);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pac Man!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pac_man)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retryToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.PictureBox wall3;
        private System.Windows.Forms.PictureBox wall4;
        private System.Windows.Forms.PictureBox wall6;
        private System.Windows.Forms.PictureBox wall5;
        private System.Windows.Forms.PictureBox wall7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pac_man;
        private System.Windows.Forms.Label highscore_label;
    }
}