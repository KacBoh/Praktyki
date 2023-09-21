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
            listBox1 = new ListBox();
            Name = new TextBox();
            buttonStart = new Button();
            textProgress = new TextBox();
            textBox1 = new TextBox();
            buttonAsk = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(398, 11);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(159, 304);
            listBox1.TabIndex = 0;
            // 
            // Name
            // 
            Name.Location = new Point(12, 12);
            Name.Name = "Name";
            Name.Size = new Size(175, 27);
            Name.TabIndex = 1;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(193, 11);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(199, 29);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Rozpocznij grę";
            buttonStart.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 265);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(380, 85);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonAsk
            // 
            buttonAsk.Location = new Point(398, 321);
            buttonAsk.Name = "buttonAsk";
            buttonAsk.Size = new Size(159, 29);
            buttonAsk.TabIndex = 5;
            buttonAsk.Text = "button1";
            buttonAsk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAsk);
            Controls.Add(textBox1);
            Controls.Add(textProgress);
            Controls.Add(buttonStart);
            Controls.Add(Name);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox Name;
        private Button buttonStart;
        private TextBox textProgress;
        private TextBox textBox1;
        private Button buttonAsk;
    }
}