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
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
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
            labelPlayerName.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelPlayerName.Location = new Point(0, -1);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(788, 64);
            labelPlayerName.TabIndex = 1;
            labelPlayerName.Text = "label2";
            labelPlayerName.Click += labelPlayerName_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(24, 53);
            label2.Name = "label2";
            label2.Size = new Size(681, 59);
            label2.TabIndex = 2;
            label2.Text = "TRÒ CHƠI NIM";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(298, 128);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(122, 42);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "BẮT ĐẦU";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.Location = new Point(298, 176);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(122, 42);
            buttonSetting.TabIndex = 3;
            buttonSetting.Text = "CÀI ĐẶT";
            buttonSetting.UseVisualStyleBackColor = true;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(298, 224);
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 311);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSetting);
            Controls.Add(buttonStart);
            Controls.Add(label2);
            Controls.Add(labelPlayerName);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
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
    }
}