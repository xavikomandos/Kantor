namespace Waluty
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxEURO = new System.Windows.Forms.TextBox();
            this.textBoxCHF = new System.Windows.Forms.TextBox();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelEURO = new System.Windows.Forms.Label();
            this.labelCHF = new System.Windows.Forms.Label();
            this.labelPOL = new System.Windows.Forms.Label();
            this.textBoxPLN = new System.Windows.Forms.TextBox();
            this.radioButtonUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonEURO = new System.Windows.Forms.RadioButton();
            this.radioButtonCHF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "POBIERZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 227);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 211);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Location = new System.Drawing.Point(81, 6);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(100, 23);
            this.textBoxUSD.TabIndex = 2;
            // 
            // textBoxEURO
            // 
            this.textBoxEURO.Location = new System.Drawing.Point(81, 41);
            this.textBoxEURO.Name = "textBoxEURO";
            this.textBoxEURO.Size = new System.Drawing.Size(100, 23);
            this.textBoxEURO.TabIndex = 3;
            // 
            // textBoxCHF
            // 
            this.textBoxCHF.Location = new System.Drawing.Point(81, 76);
            this.textBoxCHF.Name = "textBoxCHF";
            this.textBoxCHF.Size = new System.Drawing.Size(100, 23);
            this.textBoxCHF.TabIndex = 4;
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(12, 9);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(55, 15);
            this.labelUSD.TabIndex = 5;
            this.labelUSD.Text = "Kurs USD";
            // 
            // labelEURO
            // 
            this.labelEURO.AutoSize = true;
            this.labelEURO.Location = new System.Drawing.Point(12, 44);
            this.labelEURO.Name = "labelEURO";
            this.labelEURO.Size = new System.Drawing.Size(63, 15);
            this.labelEURO.TabIndex = 6;
            this.labelEURO.Text = "Kurs EURO";
            // 
            // labelCHF
            // 
            this.labelCHF.AutoSize = true;
            this.labelCHF.Location = new System.Drawing.Point(12, 76);
            this.labelCHF.Name = "labelCHF";
            this.labelCHF.Size = new System.Drawing.Size(56, 15);
            this.labelCHF.TabIndex = 7;
            this.labelCHF.Text = "Kurs CHF";
            // 
            // labelPOL
            // 
            this.labelPOL.AutoSize = true;
            this.labelPOL.Location = new System.Drawing.Point(28, 133);
            this.labelPOL.Name = "labelPOL";
            this.labelPOL.Size = new System.Drawing.Size(65, 15);
            this.labelPOL.TabIndex = 8;
            this.labelPOL.Text = "Kwota PLN";
            // 
            // textBoxPLN
            // 
            this.textBoxPLN.Location = new System.Drawing.Point(12, 157);
            this.textBoxPLN.Name = "textBoxPLN";
            this.textBoxPLN.Size = new System.Drawing.Size(100, 23);
            this.textBoxPLN.TabIndex = 9;
            // 
            // radioButtonUSD
            // 
            this.radioButtonUSD.AutoSize = true;
            this.radioButtonUSD.Location = new System.Drawing.Point(134, 131);
            this.radioButtonUSD.Name = "radioButtonUSD";
            this.radioButtonUSD.Size = new System.Drawing.Size(47, 19);
            this.radioButtonUSD.TabIndex = 10;
            this.radioButtonUSD.TabStop = true;
            this.radioButtonUSD.Text = "USD";
            this.radioButtonUSD.UseVisualStyleBackColor = true;
            this.radioButtonUSD.Click += new System.EventHandler(this.Exchange);
            // 
            // radioButtonEURO
            // 
            this.radioButtonEURO.AutoSize = true;
            this.radioButtonEURO.Location = new System.Drawing.Point(134, 157);
            this.radioButtonEURO.Name = "radioButtonEURO";
            this.radioButtonEURO.Size = new System.Drawing.Size(55, 19);
            this.radioButtonEURO.TabIndex = 11;
            this.radioButtonEURO.TabStop = true;
            this.radioButtonEURO.Text = "EURO";
            this.radioButtonEURO.UseVisualStyleBackColor = true;
            this.radioButtonEURO.Click += new System.EventHandler(this.Exchange);
            // 
            // radioButtonCHF
            // 
            this.radioButtonCHF.AutoSize = true;
            this.radioButtonCHF.Location = new System.Drawing.Point(134, 182);
            this.radioButtonCHF.Name = "radioButtonCHF";
            this.radioButtonCHF.Size = new System.Drawing.Size(48, 19);
            this.radioButtonCHF.TabIndex = 12;
            this.radioButtonCHF.TabStop = true;
            this.radioButtonCHF.Text = "CHF";
            this.radioButtonCHF.UseVisualStyleBackColor = true;
            this.radioButtonCHF.Click += new System.EventHandler(this.Exchange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kwota Po Wymianie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonCHF);
            this.Controls.Add(this.radioButtonEURO);
            this.Controls.Add(this.radioButtonUSD);
            this.Controls.Add(this.textBoxPLN);
            this.Controls.Add(this.labelPOL);
            this.Controls.Add(this.labelCHF);
            this.Controls.Add(this.labelEURO);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.textBoxCHF);
            this.Controls.Add(this.textBoxEURO);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox textBoxUSD;
        private TextBox textBoxEURO;
        private TextBox textBoxCHF;
        private Label labelUSD;
        private Label labelEURO;
        private Label labelCHF;
        private Label labelPOL;
        private TextBox textBoxPLN;
        private RadioButton radioButtonUSD;
        private RadioButton radioButtonEURO;
        private RadioButton radioButtonCHF;
        private Label label1;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}