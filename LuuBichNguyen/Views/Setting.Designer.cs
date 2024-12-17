namespace LuuBichNguyen.Views
{
    partial class Setting
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
            trackBar1 = new TrackBar();
            labelMusic = new Label();
            panel1 = new Panel();
            btnPause = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnPause).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(120, 136);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(425, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 100;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // labelMusic
            // 
            labelMusic.AutoSize = true;
            labelMusic.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelMusic.Location = new Point(42, 146);
            labelMusic.Name = "labelMusic";
            labelMusic.Size = new Size(72, 19);
            labelMusic.TabIndex = 2;
            labelMusic.Text = "Âm Thanh";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.option_menu;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnPause);
            panel1.Controls.Add(labelMusic);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(69, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 282);
            panel1.TabIndex = 3;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.BackgroundImage = Properties.Resources.Menu_Buttons_sprite__BnW_;
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.Location = new Point(0, -5);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(56, 44);
            btnPause.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPause.TabIndex = 7;
            btnPause.TabStop = false;
            btnPause.Click += btnPause_Click;
            btnPause.MouseLeave += btnPause_Leave;
            btnPause.MouseHover += btnPause_Hover;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(734, 311);
            Controls.Add(panel1);
            Name = "Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setting";
            Load += Setting_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnPause).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TrackBar trackBar1;
        private Label labelMusic;
        private Panel panel1;
        private PictureBox btnPause;
    }
}