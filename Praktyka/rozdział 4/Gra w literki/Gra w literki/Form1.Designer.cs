namespace Gra_w_literki
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            statusStrip1 = new StatusStrip();
            corretLabel = new ToolStripStatusLabel();
            missedLabel = new ToolStripStatusLabel();
            totalLabel = new ToolStripStatusLabel();
            accuracyLabel = new ToolStripStatusLabel();
            difficultyProgresBar = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 159;
            listBox1.Items.AddRange(new object[] { "" });
            listBox1.Location = new Point(0, 0);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 190);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { corretLabel, missedLabel, totalLabel, accuracyLabel, difficultyProgresBar });
            statusStrip1.Location = new Point(0, 164);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // corretLabel
            // 
            corretLabel.Name = "corretLabel";
            corretLabel.Size = new Size(119, 20);
            corretLabel.Text = "Prawidłowych: 0 ";
            // 
            // missedLabel
            // 
            missedLabel.Name = "missedLabel";
            missedLabel.Size = new Size(61, 20);
            missedLabel.Text = "Błędy: 0";
            // 
            // totalLabel
            // 
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(88, 20);
            totalLabel.Text = "Wszystkie: 0";
            // 
            // accuracyLabel
            // 
            accuracyLabel.Name = "accuracyLabel";
            accuracyLabel.Size = new Size(111, 20);
            accuracyLabel.Text = "Dokładność 0%";
            // 
            // difficultyProgresBar
            // 
            difficultyProgresBar.Alignment = ToolStripItemAlignment.Right;
            difficultyProgresBar.Maximum = 800;
            difficultyProgresBar.Name = "difficultyProgresBar";
            difficultyProgresBar.Size = new Size(100, 18);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 800;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 190);
            Controls.Add(statusStrip1);
            Controls.Add(listBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Gra w literki";
            KeyDown += Form1_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel corretLabel;
        private ToolStripStatusLabel missedLabel;
        private ToolStripStatusLabel totalLabel;
        private ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.Timer timer1;
        private ToolStripProgressBar difficultyProgresBar;
    }
}