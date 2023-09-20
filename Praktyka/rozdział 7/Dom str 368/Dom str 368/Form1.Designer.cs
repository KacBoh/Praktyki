namespace Dom_str_368
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
            description = new TextBox();
            button1 = new Button();
            goThroughTheDoor = new Button();
            exits = new ComboBox();
            SuspendLayout();
            // 
            // description
            // 
            description.Location = new Point(1, 0);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(366, 149);
            description.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 155);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 1;
            button1.Text = "Idź do:";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // goThroughTheDoor
            // 
            goThroughTheDoor.Location = new Point(12, 190);
            goThroughTheDoor.Name = "goThroughTheDoor";
            goThroughTheDoor.Size = new Size(344, 29);
            goThroughTheDoor.TabIndex = 2;
            goThroughTheDoor.Text = "Przejdź przez dźwi";
            goThroughTheDoor.UseVisualStyleBackColor = true;
            goThroughTheDoor.Click += button2_Click;
            // 
            // exits
            // 
            exits.DropDownStyle = ComboBoxStyle.DropDownList;
            exits.FormattingEnabled = true;
            exits.Location = new Point(139, 156);
            exits.Name = "exits";
            exits.Size = new Size(217, 28);
            exits.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 227);
            Controls.Add(exits);
            Controls.Add(goThroughTheDoor);
            Controls.Add(button1);
            Controls.Add(description);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox description;
        private Button button1;
        private Button goThroughTheDoor;
        private ComboBox exits;
    }
}