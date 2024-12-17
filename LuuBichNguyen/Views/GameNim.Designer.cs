namespace LuuBichNguyen.Views
{
    partial class GameNim
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
            labelTime = new Label();
            labelPlayer1 = new Label();
            labelPlayer2 = new Label();
            labelMess = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonTake = new Button();
            label1 = new Label();
            btnPause = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnPause).BeginInit();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.BackColor = Color.Transparent;
            labelTime.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTime.Location = new Point(12, 9);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(776, 31);
            labelTime.TabIndex = 0;
            labelTime.Text = "label1";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            labelTime.Click += labelTime_Click;
            // 
            // labelPlayer1
            // 
            labelPlayer1.AutoSize = true;
            labelPlayer1.BackColor = Color.Transparent;
            labelPlayer1.Font = new Font("Times New Roman", 14.25F);
            labelPlayer1.Location = new Point(70, 227);
            labelPlayer1.Name = "labelPlayer1";
            labelPlayer1.Size = new Size(65, 21);
            labelPlayer1.TabIndex = 1;
            labelPlayer1.Text = "Player1";
            labelPlayer1.Click += labelPlayer1_Click;
            // 
            // labelPlayer2
            // 
            labelPlayer2.AutoSize = true;
            labelPlayer2.BackColor = Color.Transparent;
            labelPlayer2.Font = new Font("Times New Roman", 14.25F);
            labelPlayer2.Location = new Point(654, 227);
            labelPlayer2.Name = "labelPlayer2";
            labelPlayer2.Size = new Size(29, 21);
            labelPlayer2.TabIndex = 2;
            labelPlayer2.Text = "AI";
            // 
            // labelMess
            // 
            labelMess.BackColor = Color.Transparent;
            labelMess.Location = new Point(12, 70);
            labelMess.Name = "labelMess";
            labelMess.Size = new Size(776, 15);
            labelMess.TabIndex = 3;
            labelMess.Text = "label3";
            labelMess.TextAlign = ContentAlignment.MiddleCenter;
            labelMess.Click += labelMess_Click;
            // 
            // buttonTake
            // 
            buttonTake.Location = new Point(359, 251);
            buttonTake.Name = "buttonTake";
            buttonTake.Size = new Size(75, 23);
            buttonTake.TabIndex = 4;
            buttonTake.Text = "Lấy";
            buttonTake.UseVisualStyleBackColor = true;
            buttonTake.Click += buttonTake_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 377);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.BackgroundImage = Properties.Resources.Menu_Buttons_sprite__BnW_;
            btnPause.BackgroundImageLayout = ImageLayout.Stretch;
            btnPause.Location = new Point(12, 9);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(56, 44);
            btnPause.SizeMode = PictureBoxSizeMode.StretchImage;
            btnPause.TabIndex = 6;
            btnPause.TabStop = false;
            btnPause.Click += btnPause_Click;
            btnPause.MouseLeave += btnPause_Leave;
            btnPause.MouseHover += btnPause_Hover;
            // 
            // GameNim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(800, 292);
            Controls.Add(btnPause);
            Controls.Add(label1);
            Controls.Add(buttonTake);
            Controls.Add(labelMess);
            Controls.Add(labelPlayer2);
            Controls.Add(labelPlayer1);
            Controls.Add(labelTime);
            Name = "GameNim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += GameNim_Load;
            ((System.ComponentModel.ISupportInitialize)btnPause).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTime;
        private Label labelPlayer1;
        private Label labelPlayer2;
        private Label labelMess;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonTake;
        private Label label1;
        private PictureBox btnPause;
    }
}