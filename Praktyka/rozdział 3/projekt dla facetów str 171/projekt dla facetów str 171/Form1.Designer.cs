namespace projekt_dla_facetów_str_171
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
            JoeCash = new Label();
            BobsCash = new Label();
            BankCash = new Label();
            Receive = new Button();
            Give = new Button();
            SuspendLayout();
            // 
            // JoeCash
            // 
            JoeCash.AutoSize = true;
            JoeCash.Location = new Point(42, 40);
            JoeCash.Name = "JoeCash";
            JoeCash.Size = new Size(50, 20);
            JoeCash.TabIndex = 0;
            JoeCash.Text = "label1";
            JoeCash.Click += label1_Click;
            // 
            // BobsCash
            // 
            BobsCash.AutoSize = true;
            BobsCash.Location = new Point(41, 79);
            BobsCash.Name = "BobsCash";
            BobsCash.Size = new Size(50, 20);
            BobsCash.TabIndex = 1;
            BobsCash.Text = "label2";
            // 
            // BankCash
            // 
            BankCash.AutoSize = true;
            BankCash.Location = new Point(42, 114);
            BankCash.Name = "BankCash";
            BankCash.Size = new Size(50, 20);
            BankCash.TabIndex = 2;
            BankCash.Text = "label3";
            // 
            // Receive
            // 
            Receive.Location = new Point(32, 163);
            Receive.Name = "Receive";
            Receive.Size = new Size(150, 31);
            Receive.TabIndex = 3;
            Receive.Text = "Daj Joe 10zł";
            Receive.UseVisualStyleBackColor = true;
            Receive.Click += Receive_Click;
            // 
            // Give
            // 
            Give.Location = new Point(32, 213);
            Give.Name = "Give";
            Give.Size = new Size(150, 29);
            Give.TabIndex = 4;
            Give.Text = "Zabierz Bobowi 5zł";
            Give.UseVisualStyleBackColor = true;
            Give.Click += Give_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 283);
            Controls.Add(Give);
            Controls.Add(Receive);
            Controls.Add(BankCash);
            Controls.Add(BobsCash);
            Controls.Add(JoeCash);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JoeCash;
        private Label BobsCash;
        private Label BankCash;
        private Button Receive;
        private Button Give;
    }
}