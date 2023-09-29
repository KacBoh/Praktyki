namespace Planista_przyjęć_str_238
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
            label1 = new Label();
            People = new NumericUpDown();
            dekoracja = new CheckBox();
            zdrowie = new CheckBox();
            label2 = new Label();
            Koszt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)People).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Ilość osób";
            // 
            // People
            // 
            People.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            People.Location = new Point(22, 49);
            People.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            People.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            People.Name = "People";
            People.Size = new Size(194, 43);
            People.TabIndex = 1;
            People.Value = new decimal(new int[] { 5, 0, 0, 0 });
            People.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dekoracja
            // 
            dekoracja.AutoSize = true;
            dekoracja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dekoracja.Location = new Point(22, 98);
            dekoracja.Name = "dekoracja";
            dekoracja.Size = new Size(215, 32);
            dekoracja.TabIndex = 2;
            dekoracja.Text = "Dekoracje fantazyjne";
            dekoracja.UseVisualStyleBackColor = true;
            dekoracja.CheckedChanged += dekoracja_CheckedChanged;
            // 
            // zdrowie
            // 
            zdrowie.AutoSize = true;
            zdrowie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zdrowie.Location = new Point(22, 136);
            zdrowie.Name = "zdrowie";
            zdrowie.Size = new Size(184, 32);
            zdrowie.TabIndex = 3;
            zdrowie.Text = "Opcja zdrowotna";
            zdrowie.UseVisualStyleBackColor = true;
            zdrowie.CheckedChanged += zdrowie_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 4;
            label2.Text = "Koszt";
            // 
            // Koszt
            // 
            Koszt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Koszt.Location = new Point(106, 168);
            Koszt.Name = "Koszt";
            Koszt.Size = new Size(125, 43);
            Koszt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 226);
            Controls.Add(Koszt);
            Controls.Add(label2);
            Controls.Add(zdrowie);
            Controls.Add(dekoracja);
            Controls.Add(People);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)People).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown People;
        private CheckBox dekoracja;
        private CheckBox zdrowie;
        private Label label2;
        private TextBox Koszt;
    }
}