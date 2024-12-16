namespace LuuBichNguyen.Views
{
    partial class Rock
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
            label1 = new Label();
            buttonAcpect = new Button();
            textBoxInt = new TextBox();
            labelWaring = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(279, 61);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhập Số Lượng Sỏi";
            label1.Click += label1_Click;
            // 
            // buttonAcpect
            // 
            buttonAcpect.Font = new Font("Microsoft Sans Serif", 8.25F);
            buttonAcpect.Location = new Point(361, 228);
            buttonAcpect.Name = "buttonAcpect";
            buttonAcpect.Size = new Size(75, 23);
            buttonAcpect.TabIndex = 1;
            buttonAcpect.Text = "Xác Nhận";
            buttonAcpect.UseVisualStyleBackColor = true;
            buttonAcpect.Click += buttonAcpect_Click;
            // 
            // textBoxInt
            // 
            textBoxInt.Location = new Point(235, 155);
            textBoxInt.Name = "textBoxInt";
            textBoxInt.Size = new Size(332, 23);
            textBoxInt.TabIndex = 2;
            textBoxInt.TextChanged += textBoxInt_TextChanged;
            // 
            // labelWaring
            // 
            labelWaring.ForeColor = Color.Red;
            labelWaring.Location = new Point(0, 181);
            labelWaring.Name = "labelWaring";
            labelWaring.Size = new Size(800, 23);
            labelWaring.TabIndex = 3;
            labelWaring.Text = "label2";
            labelWaring.TextAlign = ContentAlignment.MiddleCenter;
            labelWaring.Click += labelWaring_Click;
            // 
            // Rock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(labelWaring);
            Controls.Add(textBoxInt);
            Controls.Add(buttonAcpect);
            Controls.Add(label1);
            Name = "Rock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock";
            Load += Rock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAcpect;
        private TextBox textBoxInt;
        private Label labelWaring;
    }
}