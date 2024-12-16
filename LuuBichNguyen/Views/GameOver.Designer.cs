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
            labelMess = new Label();
            btnHome = new PictureBox();
            btnOption = new PictureBox();
            btnExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // labelMess
            // 
            labelMess.BackColor = Color.Transparent;
            labelMess.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMess.Location = new Point(12, 68);
            labelMess.Name = "labelMess";
            labelMess.Size = new Size(776, 100);
            labelMess.TabIndex = 0;
            labelMess.Text = "label1";
            labelMess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Image = Properties.Resources.Menu_Buttons_sprite__BnW____Copy;
            btnHome.Location = new Point(232, 188);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(60, 62);
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
            btnOption.Location = new Point(360, 188);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(60, 60);
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
            btnExit.Location = new Point(491, 188);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 60);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += btnExit_Leave;
            btnExit.MouseHover += btnExit_Hover;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(800, 403);
            Controls.Add(btnExit);
            Controls.Add(btnOption);
            Controls.Add(btnHome);
            Controls.Add(labelMess);
            Name = "GameOver";
            Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOption).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMess;
        private PictureBox btnHome;
        private PictureBox btnOption;
        private PictureBox btnExit;
    }
}