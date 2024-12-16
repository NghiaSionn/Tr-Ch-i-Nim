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
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            btnExit = new PictureBox();
            btnOption = new PictureBox();
            btnStart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnStart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 149);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // labelPlayerName
            // 
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelPlayerName.Location = new Point(0, -1);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(837, 85);
            labelPlayerName.TabIndex = 1;
            labelPlayerName.Text = "label2";
            labelPlayerName.Click += labelPlayerName_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(-205, 43);
            label2.Name = "label2";
            label2.Size = new Size(778, 79);
            label2.TabIndex = 2;
            label2.Text = "TRÒ CHƠI NIM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(24, 53);
            axWindowsMediaPlayer1.Margin = new Padding(3, 4, 3, 4);
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
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnOption);
            panel1.Controls.Add(btnStart);
            panel1.Location = new Point(260, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 365);
            panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Image = Properties.Resources.exit_normal;
            btnExit.Location = new Point(125, 272);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 67);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 6;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseLeave += btnExit_Leave;
            btnExit.MouseHover += btnExit_Hover;
            // 
            // btnOption
            // 
            btnOption.BackColor = Color.Transparent;
            btnOption.Image = Properties.Resources.option_normal;
            btnOption.Location = new Point(125, 197);
            btnOption.Margin = new Padding(3, 4, 3, 4);
            btnOption.Name = "btnOption";
            btnOption.Size = new Size(114, 67);
            btnOption.SizeMode = PictureBoxSizeMode.StretchImage;
            btnOption.TabIndex = 6;
            btnOption.TabStop = false;
            btnOption.Click += btnOption_Click;
            btnOption.MouseLeave += btnOption_Leave;
            btnOption.MouseHover += btnOption_Hover;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.Image = Properties.Resources.start_normal;
            btnStart.Location = new Point(125, 123);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(114, 67);
            btnStart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnStart.TabIndex = 6;
            btnStart.TabStop = false;
            btnStart.Click += btnStart_Click;
            btnStart.MouseLeave += btnStart_Leave;
            btnStart.MouseHover += btnStart_Hover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(839, 403);
            Controls.Add(panel1);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(labelPlayerName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOption).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnStart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelPlayerName;
        private Label label2;
        private Button buttonStart;
        private Button buttonSetting;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel panel1;
        private PictureBox btnStart;
        private PictureBox btnOption;
        private PictureBox btnExit;
    }
}