namespace RealExamen2
{
    partial class Form1
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
            this.FirstLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.TriGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.FruitListBox = new System.Windows.Forms.ListBox();
            this.TheShowBbutton = new System.Windows.Forms.Button();
            this.TriGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(41, 74);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(52, 20);
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(106, 74);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(125, 27);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(129, 120);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(218, 27);
            this.LastNameTextBox.TabIndex = 2;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(41, 120);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(82, 20);
            this.SecondLabel.TabIndex = 3;
            this.SecondLabel.Text = "Last Name:";
            // 
            // TriGroupBox
            // 
            this.TriGroupBox.Controls.Add(this.ResultTextBox);
            this.TriGroupBox.Controls.Add(this.label4);
            this.TriGroupBox.Controls.Add(this.CalcButton);
            this.TriGroupBox.Controls.Add(this.BTextBox);
            this.TriGroupBox.Controls.Add(this.CTextBox);
            this.TriGroupBox.Controls.Add(this.label3);
            this.TriGroupBox.Controls.Add(this.label2);
            this.TriGroupBox.Controls.Add(this.label1);
            this.TriGroupBox.Location = new System.Drawing.Point(12, 298);
            this.TriGroupBox.Name = "TriGroupBox";
            this.TriGroupBox.Size = new System.Drawing.Size(456, 254);
            this.TriGroupBox.TabIndex = 7;
            this.TriGroupBox.TabStop = false;
            this.TriGroupBox.Text = "Right Triangle:";
            this.TriGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(117, 203);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(194, 27);
            this.ResultTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result:";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(165, 73);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(160, 56);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calc";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(42, 109);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(69, 27);
            this.BTextBox.TabIndex = 11;
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(42, 74);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(69, 27);
            this.CTextBox.TabIndex = 8;
            this.CTextBox.Leave += new System.EventHandler(this.CheckIFNumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "a = sqrt(c2-b2)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "b = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "c =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RealExamen2.Properties.Resources.Crocodile;
            this.pictureBox1.Location = new System.Drawing.Point(490, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectButton);
            this.groupBox1.Controls.Add(this.FruitListBox);
            this.groupBox1.Location = new System.Drawing.Point(490, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 254);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fruit List:";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(109, 197);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(236, 29);
            this.SelectButton.TabIndex = 15;
            this.SelectButton.Text = "You have selected:";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // FruitListBox
            // 
            this.FruitListBox.FormattingEnabled = true;
            this.FruitListBox.ItemHeight = 20;
            this.FruitListBox.Items.AddRange(new object[] {
            "Banana",
            "Strawberry",
            "Orange",
            "Lime",
            "Lemon",
            "Blueberry",
            "Watermelon"});
            this.FruitListBox.Location = new System.Drawing.Point(159, 26);
            this.FruitListBox.Name = "FruitListBox";
            this.FruitListBox.Size = new System.Drawing.Size(150, 144);
            this.FruitListBox.TabIndex = 15;
            // 
            // TheShowBbutton
            // 
            this.TheShowBbutton.Location = new System.Drawing.Point(137, 183);
            this.TheShowBbutton.Name = "TheShowBbutton";
            this.TheShowBbutton.Size = new System.Drawing.Size(186, 61);
            this.TheShowBbutton.TabIndex = 15;
            this.TheShowBbutton.Text = "Show";
            this.TheShowBbutton.UseVisualStyleBackColor = true;
            this.TheShowBbutton.Click += new System.EventHandler(this.TheShowBbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 564);
            this.Controls.Add(this.TheShowBbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TriGroupBox);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FirstLabel);
            this.Name = "Form1";
            this.Text = "Exam2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TriGroupBox.ResumeLayout(false);
            this.TriGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FirstLabel;
        private TextBox NameTextBox;
        private TextBox LastNameTextBox;
        private Label SecondLabel;
        private GroupBox TriGroupBox;
        private TextBox ResultTextBox;
        private Label label4;
        private Button CalcButton;
        private TextBox BTextBox;
        private TextBox CTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button SelectButton;
        private ListBox FruitListBox;
        private Button TheShowBbutton;
    }
}