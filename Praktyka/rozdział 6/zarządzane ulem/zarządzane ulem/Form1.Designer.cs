namespace zarządzane_ulem
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            shifts = new NumericUpDown();
            label2 = new Label();
            workerBeeJob = new ComboBox();
            label1 = new Label();
            NextShift = new Button();
            report = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(shifts);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(workerBeeJob);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Przydział prac";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 108);
            button1.Name = "button1";
            button1.Size = new Size(366, 39);
            button1.TabIndex = 4;
            button1.Text = "Przypisz tę prace pszczolę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // shifts
            // 
            shifts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            shifts.Location = new Point(269, 67);
            shifts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            shifts.Name = "shifts";
            shifts.Size = new Size(103, 34);
            shifts.TabIndex = 3;
            shifts.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(281, 36);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 2;
            label2.Text = "Zmiany";
            label2.Click += label2_Click;
            // 
            // workerBeeJob
            // 
            workerBeeJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            workerBeeJob.FormattingEnabled = true;
            workerBeeJob.Items.AddRange(new object[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Utrzymywanie ula", "Nauczanie pszczółek", "Patrol z żądłami" });
            workerBeeJob.Location = new Point(6, 66);
            workerBeeJob.Name = "workerBeeJob";
            workerBeeJob.Size = new Size(257, 36);
            workerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "Zadanie robotnicy";
            // 
            // NextShift
            // 
            NextShift.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            NextShift.Location = new Point(396, 27);
            NextShift.Name = "NextShift";
            NextShift.Size = new Size(255, 153);
            NextShift.TabIndex = 1;
            NextShift.Text = "Przepracuj następna zmianę";
            NextShift.UseVisualStyleBackColor = true;
            NextShift.Click += NextShift_Click;
            // 
            // report
            // 
            report.Location = new Point(12, 186);
            report.Multiline = true;
            report.Name = "report";
            report.Size = new Size(639, 208);
            report.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 406);
            Controls.Add(report);
            Controls.Add(NextShift);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shifts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox workerBeeJob;
        private Label label1;
        private Button button1;
        private NumericUpDown shifts;
        private Label label2;
        private Button NextShift;
        private TextBox report;
    }
}