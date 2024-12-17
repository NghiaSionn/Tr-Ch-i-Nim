namespace LuuBichNguyen.Views
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            labelMess = new Label();
            btnHome = new PictureBox();
            btnOption = new PictureBox();
            btnExit = new PictureBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // labelMess
            // 
            labelMess.BackColor = Color.Transparent;
            labelMess.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMess.Location = new Point(10, 51);
            labelMess.Name = "labelMess";
            labelMess.Size = new Size(679, 75);
            labelMess.TabIndex = 0;
            labelMess.Text = "label1";
            labelMess.TextAlign = ContentAlignment.MiddleCenter;
            labelMess.Click += labelMess_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Image = Properties.Resources.Menu_Buttons_sprite__BnW____Copy;
            btnHome.Location = new Point(203, 141);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(52, 46);
            btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            btnHome.MouseLeave += btnHome_Leave;
            btnHome.MouseHover += btnHome_Hover;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.Transparent;
            btnOption.Image = Properties.Resources.restart_normal;
            btnOption.Location = new Point(315, 141);
            btnOption.Margin = new Padding(3, 2, 3, 2);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(52, 45);
            btnOption.SizeMode = PictureBoxSizeMode.StretchImage;
            btnOption.TabIndex = 2;
            btnOption.TabStop = false;
            btnOption.Click += btnOption_Click;
            btnOption.MouseLeave += btnOption_Leave;
            btnOption.MouseHover += btnOption_Hover;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Image = Properties.Resources.quit_normal;
            btnExit.Location = new Point(430, 141);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(52, 45);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += btnExit_Leave;
            btnExit.MouseHover += btnExit_Hover;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(25, 25);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(700, 302);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(btnExit);
            Controls.Add(btnOption);
            Controls.Add(btnHome);
            Controls.Add(labelMess);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameOver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOver";
            Load += GameOver_Load;
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOption).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label labelMess;
        private PictureBox btnHome;
        private PictureBox btnOption;
        private PictureBox btnExit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}