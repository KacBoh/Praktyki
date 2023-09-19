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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label5 = new Label();
            liczba_literek = new NumericUpDown();
            Koszt2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            People2 = new NumericUpDown();
            Decoration2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)People).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)liczba_literek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)People2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Ilość osób";
            // 
            // People
            // 
            People.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            People.Location = new Point(20, 54);
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
            dekoracja.Location = new Point(20, 103);
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
            zdrowie.Location = new Point(20, 141);
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
            label2.Location = new Point(10, 176);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 4;
            label2.Text = "Koszt";
            // 
            // Koszt
            // 
            Koszt.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Koszt.Location = new Point(104, 173);
            Koszt.Name = "Koszt";
            Koszt.Size = new Size(125, 43);
            Koszt.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 271);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Koszt);
            tabPage1.Controls.Add(People);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dekoracja);
            tabPage1.Controls.Add(zdrowie);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 238);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Przyjęcie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(liczba_literek);
            tabPage2.Controls.Add(Koszt2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(People2);
            tabPage2.Controls.Add(Decoration2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 238);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Urodziny";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 13;
            label5.Text = "Ilość liter";
            label5.Click += label5_Click;
            // 
            // liczba_literek
            // 
            liczba_literek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liczba_literek.Location = new Point(108, 133);
            liczba_literek.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            liczba_literek.Name = "liczba_literek";
            liczba_literek.Size = new Size(103, 34);
            liczba_literek.TabIndex = 12;
            liczba_literek.ValueChanged += liczba_literek_ValueChanged;
            // 
            // Koszt2
            // 
            Koszt2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Koszt2.Location = new Point(102, 171);
            Koszt2.Name = "Koszt2";
            Koszt2.Size = new Size(125, 43);
            Koszt2.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 174);
            label4.Name = "label4";
            label4.Size = new Size(88, 37);
            label4.TabIndex = 10;
            label4.Text = "Koszt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 11);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 7;
            label3.Text = "Ilość osób";
            // 
            // People2
            // 
            People2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            People2.Location = new Point(17, 51);
            People2.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            People2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            People2.Name = "People2";
            People2.Size = new Size(194, 43);
            People2.TabIndex = 8;
            People2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            People2.ValueChanged += People2_ValueChanged;
            // 
            // Decoration2
            // 
            Decoration2.AutoSize = true;
            Decoration2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Decoration2.Location = new Point(17, 100);
            Decoration2.Name = "Decoration2";
            Decoration2.Size = new Size(215, 32);
            Decoration2.TabIndex = 9;
            Decoration2.Text = "Dekoracje fantazyjne";
            Decoration2.UseVisualStyleBackColor = true;
            Decoration2.CheckedChanged += Decoration2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 275);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Kalkulator pryjęć";
            ((System.ComponentModel.ISupportInitialize)People).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)liczba_literek).EndInit();
            ((System.ComponentModel.ISupportInitialize)People2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown People;
        private CheckBox dekoracja;
        private CheckBox zdrowie;
        private Label label2;
        private TextBox Koszt;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private NumericUpDown liczba_literek;
        private TextBox Koszt2;
        private Label label4;
        private Label label3;
        private NumericUpDown People2;
        private CheckBox Decoration2;
    }
}