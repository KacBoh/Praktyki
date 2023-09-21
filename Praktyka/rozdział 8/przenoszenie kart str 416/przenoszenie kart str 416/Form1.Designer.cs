namespace przenoszenie_kart_str_416
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
            ListDeck1 = new ListBox();
            ListDeck2 = new ListBox();
            MoveToDeck2 = new Button();
            MoveToDeck1 = new Button();
            Reset1 = new Button();
            Reset2 = new Button();
            Mix1 = new Button();
            Mix2 = new Button();
            SuspendLayout();
            // 
            // ListDeck1
            // 
            ListDeck1.FormattingEnabled = true;
            ListDeck1.ItemHeight = 20;
            ListDeck1.Location = new Point(12, 12);
            ListDeck1.Name = "ListDeck1";
            ListDeck1.Size = new Size(150, 244);
            ListDeck1.TabIndex = 0;
            // 
            // ListDeck2
            // 
            ListDeck2.FormattingEnabled = true;
            ListDeck2.ItemHeight = 20;
            ListDeck2.Location = new Point(245, 12);
            ListDeck2.Name = "ListDeck2";
            ListDeck2.Size = new Size(150, 244);
            ListDeck2.TabIndex = 1;
            // 
            // MoveToDeck2
            // 
            MoveToDeck2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MoveToDeck2.Location = new Point(168, 79);
            MoveToDeck2.Name = "MoveToDeck2";
            MoveToDeck2.Size = new Size(71, 37);
            MoveToDeck2.TabIndex = 2;
            MoveToDeck2.Text = ">>";
            MoveToDeck2.UseVisualStyleBackColor = true;
            MoveToDeck2.Click += MoveToDeck2_Click;
            // 
            // MoveToDeck1
            // 
            MoveToDeck1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MoveToDeck1.Location = new Point(168, 122);
            MoveToDeck1.Name = "MoveToDeck1";
            MoveToDeck1.Size = new Size(71, 37);
            MoveToDeck1.TabIndex = 3;
            MoveToDeck1.Text = "<<";
            MoveToDeck1.UseVisualStyleBackColor = true;
            MoveToDeck1.Click += MoveToDeck1_Click;
            // 
            // Reset1
            // 
            Reset1.Location = new Point(12, 262);
            Reset1.Name = "Reset1";
            Reset1.Size = new Size(150, 29);
            Reset1.TabIndex = 4;
            Reset1.Text = "Przywróć zestaw 1";
            Reset1.UseVisualStyleBackColor = true;
            Reset1.Click += Reset1_Click;
            // 
            // Reset2
            // 
            Reset2.Location = new Point(245, 262);
            Reset2.Name = "Reset2";
            Reset2.Size = new Size(150, 29);
            Reset2.TabIndex = 5;
            Reset2.Text = "Przywróć zestaw 2";
            Reset2.UseVisualStyleBackColor = true;
            Reset2.Click += Reset2_Click;
            // 
            // Mix1
            // 
            Mix1.Location = new Point(12, 297);
            Mix1.Name = "Mix1";
            Mix1.Size = new Size(150, 29);
            Mix1.TabIndex = 6;
            Mix1.Text = "Wymieszaj zestaw 1";
            Mix1.UseVisualStyleBackColor = true;
            Mix1.Click += Mix1_Click;
            // 
            // Mix2
            // 
            Mix2.Location = new Point(245, 297);
            Mix2.Name = "Mix2";
            Mix2.Size = new Size(150, 29);
            Mix2.TabIndex = 7;
            Mix2.Text = "Wymieszaj zestaw 2";
            Mix2.UseVisualStyleBackColor = true;
            Mix2.Click += Mix2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 334);
            Controls.Add(Mix2);
            Controls.Add(Mix1);
            Controls.Add(Reset2);
            Controls.Add(Reset1);
            Controls.Add(MoveToDeck1);
            Controls.Add(MoveToDeck2);
            Controls.Add(ListDeck2);
            Controls.Add(ListDeck1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Dwie talie";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListDeck1;
        private ListBox ListDeck2;
        private Button MoveToDeck2;
        private Button MoveToDeck1;
        private Button Reset1;
        private Button Reset2;
        private Button Mix1;
        private Button Mix2;
    }
}