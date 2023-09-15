namespace Kalkulator_zwrotu_kosztów_str_191
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
            label2 = new Label();
            poczatek = new NumericUpDown();
            koniec = new NumericUpDown();
            label3 = new Label();
            kwota = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)poczatek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)koniec).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 0;
            label1.Text = "Początkowy stan licznika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(274, 37);
            label2.TabIndex = 1;
            label2.Text = "Końcowy stan licznika";
            // 
            // poczatek
            // 
            poczatek.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            poczatek.Location = new Point(324, 7);
            poczatek.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            poczatek.Name = "poczatek";
            poczatek.Size = new Size(150, 43);
            poczatek.TabIndex = 2;
            // 
            // koniec
            // 
            koniec.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            koniec.Location = new Point(324, 56);
            koniec.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            koniec.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            koniec.Name = "koniec";
            koniec.Size = new Size(150, 43);
            koniec.TabIndex = 3;
            koniec.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 106);
            label3.Name = "label3";
            label3.Size = new Size(224, 37);
            label3.TabIndex = 4;
            label3.Text = "Kwota do zwrotu:";
            // 
            // kwota
            // 
            kwota.AutoSize = true;
            kwota.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            kwota.Location = new Point(324, 106);
            kwota.Name = "kwota";
            kwota.Size = new Size(0, 41);
            kwota.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(47, 159);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 6;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(230, 159);
            button2.Name = "button2";
            button2.Size = new Size(244, 50);
            button2.TabIndex = 7;
            button2.Text = "Pokaż odległość";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 221);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(kwota);
            Controls.Add(label3);
            Controls.Add(koniec);
            Controls.Add(poczatek);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)poczatek).EndInit();
            ((System.ComponentModel.ISupportInitialize)koniec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown poczatek;
        private NumericUpDown koniec;
        private Label label3;
        private Label kwota;
        private Button button1;
        private Button button2;
    }
}