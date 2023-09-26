namespace idź_na_ryby
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
            listHand = new ListBox();
            textName = new TextBox();
            buttonStart = new Button();
            textProgress = new TextBox();
            textBooks = new TextBox();
            buttonAsk = new Button();
            SuspendLayout();
            // 
            // listHand
            // 
            listHand.FormattingEnabled = true;
            listHand.ItemHeight = 20;
            listHand.Location = new Point(398, 11);
            listHand.Name = "listHand";
            listHand.Size = new Size(159, 304);
            listHand.TabIndex = 0;
            // 
            // textName
            // 
            textName.Location = new Point(12, 12);
            textName.Name = "textName";
            textName.Size = new Size(175, 27);
            textName.TabIndex = 1;
            textName.Text = "Form1";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(193, 11);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(199, 29);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Rozpocznij grę";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textProgress
            // 
            textProgress.Location = new Point(13, 47);
            textProgress.Multiline = true;
            textProgress.Name = "textProgress";
            textProgress.ReadOnly = true;
            textProgress.Size = new Size(379, 212);
            textProgress.TabIndex = 3;
            // 
            // textBooks
            // 
            textBooks.Location = new Point(12, 265);
            textBooks.Multiline = true;
            textBooks.Name = "textBooks";
            textBooks.ReadOnly = true;
            textBooks.Size = new Size(380, 85);
            textBooks.TabIndex = 4;
            textBooks.TextChanged += textBox1_TextChanged;
            // 
            // buttonAsk
            // 
            buttonAsk.Location = new Point(398, 321);
            buttonAsk.Name = "buttonAsk";
            buttonAsk.Size = new Size(159, 29);
            buttonAsk.TabIndex = 5;
            buttonAsk.Text = "button1";
            buttonAsk.UseVisualStyleBackColor = true;
            buttonAsk.Click += buttonAsk_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 361);
            Controls.Add(buttonAsk);
            Controls.Add(textBooks);
            Controls.Add(textProgress);
            Controls.Add(buttonStart);
            Controls.Add(textName);
            Controls.Add(listHand);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listHand;
        private TextBox textName;
        private Button buttonStart;
        private TextBox textProgress;
        private TextBox textBooks;
        private Button buttonAsk;
    }
}