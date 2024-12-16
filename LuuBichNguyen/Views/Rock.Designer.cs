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
            textBoxInt = new TextBox();
            labelWaring = new Label();
            btnAcepct = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnAcepct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(294, 80);
            label1.Name = "label1";
            label1.Size = new Size(362, 38);
            label1.TabIndex = 0;
            label1.Text = "Nhập Số Lượng Túi Sỏi";
            label1.Click += label1_Click;
            // 
            // textBoxInt
            // 
            textBoxInt.Location = new Point(269, 207);
            textBoxInt.Margin = new Padding(3, 4, 3, 4);
            textBoxInt.Name = "textBoxInt";
            textBoxInt.Size = new Size(379, 27);
            textBoxInt.TabIndex = 2;
            textBoxInt.TextChanged += textBoxInt_TextChanged;
            // 
            // labelWaring
            // 
            labelWaring.BackColor = Color.Transparent;
            labelWaring.ForeColor = Color.Red;
            labelWaring.Location = new Point(0, 241);
            labelWaring.Name = "labelWaring";
            labelWaring.Size = new Size(914, 31);
            labelWaring.TabIndex = 3;
            labelWaring.Text = "label2";
            labelWaring.TextAlign = ContentAlignment.MiddleCenter;
            labelWaring.Click += labelWaring_Click;
            // 
            // btnAcepct
            // 
            btnAcepct.BackColor = Color.Transparent;
            btnAcepct.Image = Properties.Resources.Add_Unpressed;
            btnAcepct.Location = new Point(403, 300);
            btnAcepct.Margin = new Padding(3, 4, 3, 4);
            btnAcepct.Name = "btnAcepct";
            btnAcepct.Size = new Size(104, 40);
            btnAcepct.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAcepct.TabIndex = 4;
            btnAcepct.TabStop = false;
            btnAcepct.Click += btnAcepct_Click;
            btnAcepct.MouseLeave += btnAcepct_Leave;
            btnAcepct.MouseHover += btnAcepct_Hover;
            // 
            // Rock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1126081792_612x612;
            ClientSize = new Size(914, 372);
            Controls.Add(btnAcepct);
            Controls.Add(labelWaring);
            Controls.Add(textBoxInt);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Rock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock";
            Load += Rock_Load;
            ((System.ComponentModel.ISupportInitialize)btnAcepct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxInt;
        private Label labelWaring;
        private PictureBox btnAcepct;
    }
}