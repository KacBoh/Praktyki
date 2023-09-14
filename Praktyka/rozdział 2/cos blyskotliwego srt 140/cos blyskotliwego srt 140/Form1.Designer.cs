namespace cos_blyskotliwego_srt_140
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
            przycisk = new Button();
            SuspendLayout();
            // 
            // przycisk
            // 
            przycisk.Location = new Point(345, 152);
            przycisk.Name = "przycisk";
            przycisk.Size = new Size(89, 73);
            przycisk.TabIndex = 0;
            przycisk.Text = "Start";
            przycisk.UseVisualStyleBackColor = true;
            przycisk.Click += przycisk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(przycisk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button przycisk;
    }
}