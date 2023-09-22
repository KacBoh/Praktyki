namespace śniadanie_dla_drwali_str_439
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
            LumberJack_name = new TextBox();
            button1 = new Button();
            line = new ListBox();
            howMany = new NumericUpDown();
            Crispy = new RadioButton();
            Soggy = new RadioButton();
            Rum = new RadioButton();
            Banan = new RadioButton();
            groupBox1 = new GroupBox();
            nextInLine = new ListBox();
            Next = new Button();
            AddFJ = new Button();
            ((System.ComponentModel.ISupportInitialize)howMany).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię drwala";
            // 
            // LumberJack_name
            // 
            LumberJack_name.Location = new Point(105, 6);
            LumberJack_name.Name = "LumberJack_name";
            LumberJack_name.Size = new Size(139, 27);
            LumberJack_name.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 39);
            button1.Name = "button1";
            button1.Size = new Size(232, 29);
            button1.TabIndex = 2;
            button1.Text = "Dodaj drwala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // line
            // 
            line.FormattingEnabled = true;
            line.ItemHeight = 20;
            line.Location = new Point(12, 74);
            line.Name = "line";
            line.Size = new Size(113, 304);
            line.TabIndex = 3;
            // 
            // howMany
            // 
            howMany.Location = new Point(6, 21);
            howMany.Name = "howMany";
            howMany.Size = new Size(98, 27);
            howMany.TabIndex = 4;
            // 
            // Crispy
            // 
            Crispy.AutoSize = true;
            Crispy.Location = new Point(6, 51);
            Crispy.Name = "Crispy";
            Crispy.Size = new Size(95, 24);
            Crispy.TabIndex = 5;
            Crispy.TabStop = true;
            Crispy.Text = "Chrupiący";
            Crispy.UseVisualStyleBackColor = true;
            // 
            // Soggy
            // 
            Soggy.AutoSize = true;
            Soggy.Location = new Point(6, 81);
            Soggy.Name = "Soggy";
            Soggy.Size = new Size(90, 24);
            Soggy.TabIndex = 6;
            Soggy.TabStop = true;
            Soggy.Text = "Wilgotny";
            Soggy.UseVisualStyleBackColor = true;
            // 
            // Rum
            // 
            Rum.AutoSize = true;
            Rum.Location = new Point(6, 111);
            Rum.Name = "Rum";
            Rum.Size = new Size(87, 24);
            Rum.TabIndex = 7;
            Rum.TabStop = true;
            Rum.Text = "Rumiany";
            Rum.UseVisualStyleBackColor = true;
            // 
            // Banan
            // 
            Banan.AutoSize = true;
            Banan.Location = new Point(6, 141);
            Banan.Name = "Banan";
            Banan.Size = new Size(98, 24);
            Banan.TabIndex = 8;
            Banan.TabStop = true;
            Banan.Text = "Bananowy";
            Banan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nextInLine);
            groupBox1.Controls.Add(Next);
            groupBox1.Controls.Add(AddFJ);
            groupBox1.Controls.Add(Crispy);
            groupBox1.Controls.Add(Banan);
            groupBox1.Controls.Add(howMany);
            groupBox1.Controls.Add(Rum);
            groupBox1.Controls.Add(Soggy);
            groupBox1.Location = new Point(131, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(113, 304);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // nextInLine
            // 
            nextInLine.FormattingEnabled = true;
            nextInLine.ItemHeight = 20;
            nextInLine.Location = new Point(6, 202);
            nextInLine.Name = "nextInLine";
            nextInLine.Size = new Size(95, 64);
            nextInLine.TabIndex = 11;
            // 
            // Next
            // 
            Next.Location = new Point(6, 269);
            Next.Name = "Next";
            Next.Size = new Size(94, 29);
            Next.TabIndex = 10;
            Next.Text = "Następny";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // AddFJ
            // 
            AddFJ.Location = new Point(6, 167);
            AddFJ.Name = "AddFJ";
            AddFJ.Size = new Size(94, 29);
            AddFJ.TabIndex = 9;
            AddFJ.Text = "Dodaj";
            AddFJ.UseVisualStyleBackColor = true;
            AddFJ.Click += AddFJ_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 389);
            Controls.Add(groupBox1);
            Controls.Add(line);
            Controls.Add(button1);
            Controls.Add(LumberJack_name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)howMany).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LumberJack_name;
        private Button button1;
        private ListBox line;
        private NumericUpDown howMany;
        private RadioButton Crispy;
        private RadioButton Soggy;
        private RadioButton Rum;
        private RadioButton Banan;
        private GroupBox groupBox1;
        private Button Next;
        private Button AddFJ;
        private ListBox nextInLine;
    }
}