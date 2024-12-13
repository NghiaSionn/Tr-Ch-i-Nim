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
            buttonLogin = new Button();
            textBoxLogin = new TextBox();
            labelWaring = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(181, 146);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Người Chơi";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(298, 225);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(125, 33);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Đăng Nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(279, 143);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(248, 23);
            textBoxLogin.TabIndex = 3;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // labelWaring
            // 
            labelWaring.ForeColor = Color.Red;
            labelWaring.Location = new Point(1, 169);
            labelWaring.Name = "labelWaring";
            labelWaring.Size = new Size(733, 23);
            labelWaring.TabIndex = 4;
            labelWaring.Text = "label3";
            labelWaring.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 311);
            Controls.Add(labelWaring);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private TextBox textBoxLogin;
        private Label labelWaring;
    }
}
