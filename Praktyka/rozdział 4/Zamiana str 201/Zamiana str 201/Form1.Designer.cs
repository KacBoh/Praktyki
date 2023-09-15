namespace Zamiana_str_201
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
            przycisk1 = new Button();
            przycisk2 = new Button();
            zamiana = new Button();
            SuspendLayout();
            // 
            // przycisk1
            // 
            przycisk1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            przycisk1.Location = new Point(12, 12);
            przycisk1.Name = "przycisk1";
            przycisk1.Size = new Size(128, 48);
            przycisk1.TabIndex = 0;
            przycisk1.Text = "Lioyd";
            przycisk1.UseVisualStyleBackColor = true;
            przycisk1.Click += przycisk1_Click;
            // 
            // przycisk2
            // 
            przycisk2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            przycisk2.Location = new Point(12, 66);
            przycisk2.Name = "przycisk2";
            przycisk2.Size = new Size(128, 48);
            przycisk2.TabIndex = 1;
            przycisk2.Text = "Lucinda";
            przycisk2.UseVisualStyleBackColor = true;
            // 
            // zamiana
            // 
            zamiana.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            zamiana.Location = new Point(12, 120);
            zamiana.Name = "zamiana";
            zamiana.Size = new Size(128, 47);
            zamiana.TabIndex = 2;
            zamiana.Text = "Zamiana";
            zamiana.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(152, 176);
            Controls.Add(zamiana);
            Controls.Add(przycisk2);
            Controls.Add(przycisk1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button przycisk1;
        private Button przycisk2;
        private Button zamiana;
    }
}