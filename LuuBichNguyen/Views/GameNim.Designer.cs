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
            labelHealth = new Label();
            labelAIHealth = new Label();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.BackColor = Color.Transparent;
            labelTime.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTime.Location = new Point(14, 12);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(887, 41);
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
            labelPlayer1.Location = new Point(80, 303);
            labelPlayer1.Name = "labelPlayer1";
            labelPlayer1.Size = new Size(86, 27);
            labelPlayer1.TabIndex = 1;
            labelPlayer1.Text = "Player1";
            labelPlayer1.Click += labelPlayer1_Click;
            // 
            // labelPlayer2
            // 
            labelPlayer2.AutoSize = true;
            labelPlayer2.BackColor = Color.Transparent;
            labelPlayer2.Font = new Font("Times New Roman", 14.25F);
            labelPlayer2.Location = new Point(747, 303);
            labelPlayer2.Name = "labelPlayer2";
            labelPlayer2.Size = new Size(37, 27);
            labelPlayer2.TabIndex = 2;
            labelPlayer2.Text = "AI";
            // 
            // labelMess
            // 
            labelMess.BackColor = Color.Transparent;
            labelMess.Location = new Point(14, 93);
            labelMess.Name = "labelMess";
            labelMess.Size = new Size(887, 20);
            labelMess.TabIndex = 3;
            labelMess.Text = "label3";
            labelMess.TextAlign = ContentAlignment.MiddleCenter;
            labelMess.Click += labelMess_Click;
            // 
            // buttonTake
            // 
            buttonTake.Location = new Point(410, 335);
            buttonTake.Margin = new Padding(3, 4, 3, 4);
            buttonTake.Name = "buttonTake";
            buttonTake.Size = new Size(86, 31);
            buttonTake.TabIndex = 4;
            buttonTake.Text = "Lấy";
            buttonTake.UseVisualStyleBackColor = true;
            buttonTake.Click += buttonTake_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 503);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.BackColor = Color.Transparent;
            labelHealth.Location = new Point(95, 335);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(50, 20);
            labelHealth.TabIndex = 6;
            labelHealth.Text = "label2";
            // 
            // labelAIHealth
            // 
            labelAIHealth.AutoSize = true;
            labelAIHealth.BackColor = Color.Transparent;
            labelAIHealth.Location = new Point(747, 335);
            labelAIHealth.Name = "labelAIHealth";
            labelAIHealth.Size = new Size(50, 20);
            labelAIHealth.TabIndex = 7;
            labelAIHealth.Text = "label3";
            // 
            // GameNim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(914, 389);
            Controls.Add(labelAIHealth);
            Controls.Add(labelHealth);
            Controls.Add(label1);
            Controls.Add(buttonTake);
            Controls.Add(labelMess);
            Controls.Add(labelPlayer2);
            Controls.Add(labelPlayer1);
            Controls.Add(labelTime);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameNim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += GameNim_Load;
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
        private Label labelHealth;
        private Label labelAIHealth;
    }
}