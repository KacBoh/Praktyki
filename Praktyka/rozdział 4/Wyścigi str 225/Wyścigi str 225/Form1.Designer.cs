namespace Wyścigi_str_225
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RaceTrackBox = new PictureBox();
            dogPicture1 = new PictureBox();
            dogPicture4 = new PictureBox();
            dogPicture3 = new PictureBox();
            dogPicture2 = new PictureBox();
            JanekRadio = new RadioButton();
            BartekRadio = new RadioButton();
            ArekRadio = new RadioButton();
            imie = new Label();
            button1 = new Button();
            updownZaklad = new NumericUpDown();
            label1 = new Label();
            updownPies = new NumericUpDown();
            Start = new Button();
            JanekLabel = new TextBox();
            BartekLabel = new TextBox();
            ArekLabel = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)RaceTrackBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updownZaklad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updownPies).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RaceTrackBox
            // 
            RaceTrackBox.Image = (Image)resources.GetObject("RaceTrackBox.Image");
            RaceTrackBox.Location = new Point(1, 1);
            RaceTrackBox.Name = "RaceTrackBox";
            RaceTrackBox.Size = new Size(603, 201);
            RaceTrackBox.TabIndex = 0;
            RaceTrackBox.TabStop = false;
            // 
            // dogPicture1
            // 
            dogPicture1.Image = (Image)resources.GetObject("dogPicture1.Image");
            dogPicture1.Location = new Point(12, 12);
            dogPicture1.Name = "dogPicture1";
            dogPicture1.Size = new Size(75, 20);
            dogPicture1.TabIndex = 1;
            dogPicture1.TabStop = false;
            // 
            // dogPicture4
            // 
            dogPicture4.Image = (Image)resources.GetObject("dogPicture4.Image");
            dogPicture4.Location = new Point(12, 165);
            dogPicture4.Name = "dogPicture4";
            dogPicture4.Size = new Size(75, 20);
            dogPicture4.TabIndex = 2;
            dogPicture4.TabStop = false;
            // 
            // dogPicture3
            // 
            dogPicture3.Image = (Image)resources.GetObject("dogPicture3.Image");
            dogPicture3.Location = new Point(12, 117);
            dogPicture3.Name = "dogPicture3";
            dogPicture3.Size = new Size(75, 20);
            dogPicture3.TabIndex = 3;
            dogPicture3.TabStop = false;
            // 
            // dogPicture2
            // 
            dogPicture2.Image = (Image)resources.GetObject("dogPicture2.Image");
            dogPicture2.Location = new Point(12, 55);
            dogPicture2.Name = "dogPicture2";
            dogPicture2.Size = new Size(75, 20);
            dogPicture2.TabIndex = 4;
            dogPicture2.TabStop = false;
            // 
            // JanekRadio
            // 
            JanekRadio.AutoSize = true;
            JanekRadio.Location = new Point(6, 93);
            JanekRadio.Name = "JanekRadio";
            JanekRadio.Size = new Size(91, 24);
            JanekRadio.TabIndex = 5;
            JanekRadio.TabStop = true;
            JanekRadio.Text = "Janek ma";
            JanekRadio.UseVisualStyleBackColor = true;
            // 
            // BartekRadio
            // 
            BartekRadio.AutoSize = true;
            BartekRadio.Location = new Point(6, 60);
            BartekRadio.Name = "BartekRadio";
            BartekRadio.Size = new Size(97, 24);
            BartekRadio.TabIndex = 6;
            BartekRadio.TabStop = true;
            BartekRadio.Text = "Bartek ma";
            BartekRadio.UseVisualStyleBackColor = true;
            // 
            // ArekRadio
            // 
            ArekRadio.AutoSize = true;
            ArekRadio.Location = new Point(6, 29);
            ArekRadio.Name = "ArekRadio";
            ArekRadio.Size = new Size(85, 24);
            ArekRadio.TabIndex = 7;
            ArekRadio.TabStop = true;
            ArekRadio.Text = "Arek ma";
            ArekRadio.UseVisualStyleBackColor = true;
            // 
            // imie
            // 
            imie.AutoSize = true;
            imie.Location = new Point(6, 141);
            imie.Name = "imie";
            imie.Size = new Size(38, 20);
            imie.TabIndex = 8;
            imie.Text = "imie";
            // 
            // button1
            // 
            button1.Location = new Point(63, 137);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "stawia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updownZaklad
            // 
            updownZaklad.Location = new Point(163, 139);
            updownZaklad.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            updownZaklad.Name = "updownZaklad";
            updownZaklad.Size = new Size(86, 27);
            updownZaklad.TabIndex = 10;
            updownZaklad.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 141);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 11;
            label1.Text = "zł na charta nr";
            // 
            // updownPies
            // 
            updownPies.Location = new Point(363, 139);
            updownPies.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            updownPies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            updownPies.Name = "updownPies";
            updownPies.Size = new Size(40, 27);
            updownPies.TabIndex = 12;
            updownPies.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Start
            // 
            Start.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Start.Location = new Point(403, 19);
            Start.Name = "Start";
            Start.Size = new Size(172, 114);
            Start.TabIndex = 13;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // JanekLabel
            // 
            JanekLabel.Location = new Point(107, 26);
            JanekLabel.Name = "JanekLabel";
            JanekLabel.Size = new Size(204, 27);
            JanekLabel.TabIndex = 14;
            JanekLabel.Text = "Janek nie zawarł zakładu";
            // 
            // BartekLabel
            // 
            BartekLabel.Location = new Point(107, 59);
            BartekLabel.Name = "BartekLabel";
            BartekLabel.Size = new Size(204, 27);
            BartekLabel.TabIndex = 15;
            BartekLabel.Text = "Bartek nie zawarł zakładu";
            // 
            // ArekLabel
            // 
            ArekLabel.Location = new Point(107, 92);
            ArekLabel.Name = "ArekLabel";
            ArekLabel.Size = new Size(204, 27);
            ArekLabel.TabIndex = 16;
            ArekLabel.Text = "Arek nie zawarł zakładu";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ArekRadio);
            groupBox1.Controls.Add(Start);
            groupBox1.Controls.Add(ArekLabel);
            groupBox1.Controls.Add(updownPies);
            groupBox1.Controls.Add(BartekRadio);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BartekLabel);
            groupBox1.Controls.Add(updownZaklad);
            groupBox1.Controls.Add(JanekRadio);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(JanekLabel);
            groupBox1.Controls.Add(imie);
            groupBox1.Location = new Point(12, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 172);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 392);
            Controls.Add(groupBox1);
            Controls.Add(dogPicture2);
            Controls.Add(dogPicture3);
            Controls.Add(dogPicture4);
            Controls.Add(dogPicture1);
            Controls.Add(RaceTrackBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)RaceTrackBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dogPicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)updownZaklad).EndInit();
            ((System.ComponentModel.ISupportInitialize)updownPies).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox RaceTrackBox;
        private PictureBox dogPicture1;
        private PictureBox dogPicture4;
        private PictureBox dogPicture3;
        private PictureBox dogPicture2;
        private RadioButton JanekRadio;
        private RadioButton BartekRadio;
        private RadioButton ArekRadio;
        private Label imie;
        private Button button1;
        private NumericUpDown updownZaklad;
        private Label label1;
        private NumericUpDown updownPies;
        private Button Start;
        private TextBox JanekLabel;
        private TextBox BartekLabel;
        private TextBox ArekLabel;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
    }
}