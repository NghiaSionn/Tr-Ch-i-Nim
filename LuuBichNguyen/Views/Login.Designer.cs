namespace LuuBichNguyen
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            labelWaring = new Label();
            btnLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(279, 42);
            label1.Name = "label1";
            label1.Size = new Size(215, 59);
            label1.TabIndex = 0;
            label1.Text = "TRÒ CHƠI NIM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(181, 146);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Người Chơi";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Location = new Point(279, 143);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(248, 23);
            textBoxLogin.TabIndex = 3;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // labelWaring
            // 
            labelWaring.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelWaring.BackColor = Color.Transparent;
            labelWaring.ForeColor = Color.Red;
            labelWaring.Location = new Point(0, 169);
            labelWaring.Name = "labelWaring";
            labelWaring.Size = new Size(734, 23);
            labelWaring.TabIndex = 4;
            labelWaring.Text = "label3";
            labelWaring.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Image = Properties.Resources.Add_Unpressed;
            btnLogin.Location = new Point(313, 208);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 43);
            btnLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogin.TabIndex = 6;
            btnLogin.TabStop = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(734, 311);
            Controls.Add(btnLogin);
            Controls.Add(labelWaring);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)btnLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private Label labelWaring;
        private PictureBox btnLogin;
    }
}
