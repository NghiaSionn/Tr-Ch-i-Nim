namespace LuuBichNguyen.Views
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            labelPlayerName = new Label();
            label2 = new Label();
            buttonStart = new Button();
            buttonSetting = new Button();
            buttonExit = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            btnStart = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // labelPlayerName
            // 
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelPlayerName.Location = new Point(0, -1);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(732, 64);
            labelPlayerName.TabIndex = 1;
            labelPlayerName.Text = "label2";
            labelPlayerName.Click += labelPlayerName_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(-179, 32);
            label2.Name = "label2";
            label2.Size = new Size(681, 59);
            label2.TabIndex = 2;
            label2.Text = "TRÒ CHƠI NIM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Transparent;
            buttonStart.BackgroundImage = Properties.Resources.Add_Pressed;
            buttonStart.Location = new Point(98, 100);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(122, 42);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "BẮT ĐẦU";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.Location = new Point(98, 148);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(122, 42);
            buttonSetting.TabIndex = 3;
            buttonSetting.Text = "CÀI ĐẶT";
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(98, 196);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(122, 42);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "THOÁT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(24, 53);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 4;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonSetting);
            panel1.Location = new Point(203, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 287);
            panel1.TabIndex = 5;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.Image = Properties.Resources.start_normal;
            btnStart.Location = new Point(74, 123);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 50);
            btnStart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnStart.TabIndex = 6;
            btnStart.TabStop = false;
            btnStart.Click += btnStart_Click;
            btnStart.MouseLeave += btnStart_Leave;
            btnStart.MouseHover += btnStart_Hover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.option_normal;
            pictureBox2.Location = new Point(74, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.exit_normal;
            pictureBox3.Location = new Point(74, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(734, 311);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(labelPlayerName);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelPlayerName;
        private Label label2;
        private Button buttonStart;
        private Button buttonSetting;
        private Button buttonExit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel1;
        private PictureBox btnStart;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}