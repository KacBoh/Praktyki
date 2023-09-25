namespace Wymówki_str_463
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
            label3 = new Label();
            label4 = new Label();
            description = new TextBox();
            results = new TextBox();
            textBox3 = new TextBox();
            lastUsed = new DateTimePicker();
            folder = new Button();
            save = new Button();
            open = new Button();
            randomExcuse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 7);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 0;
            label1.Text = "Wymówka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 1;
            label2.Text = "Wyniki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 2;
            label3.Text = "Ostatnio użyte ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 3;
            label4.Text = "Data pliku";
            // 
            // description
            // 
            description.Location = new Point(144, 6);
            description.Name = "description";
            description.Size = new Size(316, 27);
            description.TabIndex = 4;
            description.TextChanged += description_TextChanged;
            // 
            // results
            // 
            results.Location = new Point(144, 39);
            results.Name = "results";
            results.Size = new Size(316, 27);
            results.TabIndex = 5;
            results.TextChanged += results_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 104);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(316, 27);
            textBox3.TabIndex = 6;
            // 
            // lastUsed
            // 
            lastUsed.Location = new Point(144, 73);
            lastUsed.Name = "lastUsed";
            lastUsed.Size = new Size(316, 27);
            lastUsed.TabIndex = 9;
            lastUsed.ValueChanged += lastUsed_ValueChanged;
            // 
            // folder
            // 
            folder.Location = new Point(11, 143);
            folder.Name = "folder";
            folder.Size = new Size(94, 29);
            folder.TabIndex = 10;
            folder.Text = "Folder";
            folder.UseVisualStyleBackColor = true;
            folder.Click += folder_Click;
            // 
            // save
            // 
            save.Location = new Point(111, 143);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 11;
            save.Text = "Zapisz";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // open
            // 
            open.Location = new Point(211, 143);
            open.Name = "open";
            open.Size = new Size(94, 29);
            open.TabIndex = 12;
            open.Text = "Otwórz";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // randomExcuse
            // 
            randomExcuse.Location = new Point(311, 143);
            randomExcuse.Name = "randomExcuse";
            randomExcuse.Size = new Size(149, 29);
            randomExcuse.TabIndex = 13;
            randomExcuse.Text = "Losowa wymówka";
            randomExcuse.UseVisualStyleBackColor = true;
            randomExcuse.Click += randomExcuse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 184);
            Controls.Add(randomExcuse);
            Controls.Add(open);
            Controls.Add(save);
            Controls.Add(folder);
            Controls.Add(lastUsed);
            Controls.Add(textBox3);
            Controls.Add(results);
            Controls.Add(description);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox description;
        private TextBox results;
        private TextBox textBox3;
        private DateTimePicker lastUsed;
        private Button folder;
        private Button save;
        private Button open;
        private Button randomExcuse;
    }
}