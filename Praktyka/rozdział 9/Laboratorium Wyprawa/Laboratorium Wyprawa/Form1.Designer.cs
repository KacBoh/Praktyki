namespace Laboratorium_Wyprawa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            picBat = new PictureBox();
            picBluePotion = new PictureBox();
            picGhost = new PictureBox();
            picRedPotion = new PictureBox();
            picPlayer = new PictureBox();
            picGhoul = new PictureBox();
            picBow = new PictureBox();
            picSword = new PictureBox();
            picMace = new PictureBox();
            inventorySword = new PictureBox();
            inventoryBow = new PictureBox();
            inventoryMace = new PictureBox();
            inventoryBluePotion = new PictureBox();
            inventoryRedPotion = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            playerHitPoits = new Label();
            batHitPoints = new Label();
            Ghostlabel = new Label();
            ghostHitPoints = new Label();
            label7 = new Label();
            ghoulHitPoints = new Label();
            label = new Label();
            batlabe = new Label();
            moveUP = new Button();
            moveDown = new Button();
            moveLeft = new Button();
            moveRight = new Button();
            attackRight = new Button();
            attackLeft = new Button();
            attackDown = new Button();
            attackUp = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBluePotion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGhost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRedPotion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGhoul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventorySword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryMace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBluePotion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryRedPotion).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 402);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picBat
            // 
            picBat.BackColor = Color.Transparent;
            picBat.BorderStyle = BorderStyle.FixedSingle;
            picBat.Image = (Image)resources.GetObject("picBat.Image");
            picBat.Location = new Point(259, 59);
            picBat.Name = "picBat";
            picBat.Size = new Size(30, 30);
            picBat.SizeMode = PictureBoxSizeMode.Zoom;
            picBat.TabIndex = 1;
            picBat.TabStop = false;
            picBat.Click += pictureBox2_Click;
            // 
            // picBluePotion
            // 
            picBluePotion.BackColor = Color.Transparent;
            picBluePotion.Image = (Image)resources.GetObject("picBluePotion.Image");
            picBluePotion.Location = new Point(115, 59);
            picBluePotion.Name = "picBluePotion";
            picBluePotion.Size = new Size(30, 30);
            picBluePotion.SizeMode = PictureBoxSizeMode.Zoom;
            picBluePotion.TabIndex = 2;
            picBluePotion.TabStop = false;
            picBluePotion.Click += pictureBox3_Click;
            // 
            // picGhost
            // 
            picGhost.Image = (Image)resources.GetObject("picGhost.Image");
            picGhost.Location = new Point(223, 59);
            picGhost.Name = "picGhost";
            picGhost.Size = new Size(30, 30);
            picGhost.SizeMode = PictureBoxSizeMode.Zoom;
            picGhost.TabIndex = 3;
            picGhost.TabStop = false;
            // 
            // picRedPotion
            // 
            picRedPotion.Image = (Image)resources.GetObject("picRedPotion.Image");
            picRedPotion.Location = new Point(367, 59);
            picRedPotion.Name = "picRedPotion";
            picRedPotion.Size = new Size(30, 30);
            picRedPotion.SizeMode = PictureBoxSizeMode.Zoom;
            picRedPotion.TabIndex = 4;
            picRedPotion.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.Image = (Image)resources.GetObject("picPlayer.Image");
            picPlayer.Location = new Point(79, 59);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(30, 30);
            picPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer.TabIndex = 5;
            picPlayer.TabStop = false;
            // 
            // picGhoul
            // 
            picGhoul.Image = (Image)resources.GetObject("picGhoul.Image");
            picGhoul.Location = new Point(295, 59);
            picGhoul.Name = "picGhoul";
            picGhoul.Size = new Size(30, 30);
            picGhoul.SizeMode = PictureBoxSizeMode.Zoom;
            picGhoul.TabIndex = 6;
            picGhoul.TabStop = false;
            // 
            // picBow
            // 
            picBow.Image = (Image)resources.GetObject("picBow.Image");
            picBow.Location = new Point(187, 59);
            picBow.Name = "picBow";
            picBow.Size = new Size(30, 30);
            picBow.SizeMode = PictureBoxSizeMode.Zoom;
            picBow.TabIndex = 7;
            picBow.TabStop = false;
            // 
            // picSword
            // 
            picSword.Image = (Image)resources.GetObject("picSword.Image");
            picSword.Location = new Point(151, 59);
            picSword.Name = "picSword";
            picSword.Size = new Size(30, 30);
            picSword.SizeMode = PictureBoxSizeMode.Zoom;
            picSword.TabIndex = 8;
            picSword.TabStop = false;
            // 
            // picMace
            // 
            picMace.Image = (Image)resources.GetObject("picMace.Image");
            picMace.Location = new Point(331, 59);
            picMace.Name = "picMace";
            picMace.Size = new Size(30, 30);
            picMace.SizeMode = PictureBoxSizeMode.Zoom;
            picMace.TabIndex = 9;
            picMace.TabStop = false;
            // 
            // inventorySword
            // 
            inventorySword.BackColor = Color.White;
            inventorySword.Image = (Image)resources.GetObject("inventorySword.Image");
            inventorySword.Location = new Point(79, 320);
            inventorySword.Name = "inventorySword";
            inventorySword.Size = new Size(50, 50);
            inventorySword.TabIndex = 10;
            inventorySword.TabStop = false;
            inventorySword.Click += inventorySword_Click;
            // 
            // inventoryBow
            // 
            inventoryBow.BackColor = Color.White;
            inventoryBow.Image = (Image)resources.GetObject("inventoryBow.Image");
            inventoryBow.Location = new Point(135, 320);
            inventoryBow.Name = "inventoryBow";
            inventoryBow.Size = new Size(50, 50);
            inventoryBow.TabIndex = 11;
            inventoryBow.TabStop = false;
            inventoryBow.Click += inventoryBow_Click;
            // 
            // inventoryMace
            // 
            inventoryMace.BackColor = Color.White;
            inventoryMace.Image = (Image)resources.GetObject("inventoryMace.Image");
            inventoryMace.Location = new Point(191, 320);
            inventoryMace.Name = "inventoryMace";
            inventoryMace.Size = new Size(50, 50);
            inventoryMace.TabIndex = 12;
            inventoryMace.TabStop = false;
            inventoryMace.Click += inventoryMace_Click;
            // 
            // inventoryBluePotion
            // 
            inventoryBluePotion.BackColor = Color.White;
            inventoryBluePotion.Image = (Image)resources.GetObject("inventoryBluePotion.Image");
            inventoryBluePotion.Location = new Point(247, 320);
            inventoryBluePotion.Name = "inventoryBluePotion";
            inventoryBluePotion.Size = new Size(50, 50);
            inventoryBluePotion.TabIndex = 13;
            inventoryBluePotion.TabStop = false;
            inventoryBluePotion.Click += inventoryBluePotion_Click;
            // 
            // inventoryRedPotion
            // 
            inventoryRedPotion.BackColor = Color.Transparent;
            inventoryRedPotion.Image = (Image)resources.GetObject("inventoryRedPotion.Image");
            inventoryRedPotion.Location = new Point(303, 320);
            inventoryRedPotion.Name = "inventoryRedPotion";
            inventoryRedPotion.Size = new Size(50, 50);
            inventoryRedPotion.TabIndex = 14;
            inventoryRedPotion.TabStop = false;
            inventoryRedPotion.Click += inventoryRedPotion_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(playerHitPoits, 1, 0);
            tableLayoutPanel1.Controls.Add(batHitPoints, 1, 1);
            tableLayoutPanel1.Controls.Add(Ghostlabel, 0, 2);
            tableLayoutPanel1.Controls.Add(ghostHitPoints, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(ghoulHitPoints, 1, 3);
            tableLayoutPanel1.Controls.Add(label, 0, 0);
            tableLayoutPanel1.Controls.Add(batlabe, 0, 1);
            tableLayoutPanel1.Location = new Point(606, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.42857F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.57143F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(195, 101);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // playerHitPoits
            // 
            playerHitPoits.AutoSize = true;
            playerHitPoits.Location = new Point(100, 0);
            playerHitPoits.Name = "playerHitPoits";
            playerHitPoits.Size = new Size(0, 20);
            playerHitPoits.TabIndex = 1;
            // 
            // batHitPoints
            // 
            batHitPoints.AutoSize = true;
            batHitPoints.Location = new Point(100, 22);
            batHitPoints.Name = "batHitPoints";
            batHitPoints.Size = new Size(0, 20);
            batHitPoints.TabIndex = 3;
            // 
            // Ghostlabel
            // 
            Ghostlabel.AutoSize = true;
            Ghostlabel.Location = new Point(3, 48);
            Ghostlabel.Name = "Ghostlabel";
            Ghostlabel.Size = new Size(67, 20);
            Ghostlabel.TabIndex = 4;
            Ghostlabel.Text = "GhostHp";
            // 
            // ghostHitPoints
            // 
            ghostHitPoints.AutoSize = true;
            ghostHitPoints.Location = new Point(100, 48);
            ghostHitPoints.Name = "ghostHitPoints";
            ghostHitPoints.Size = new Size(0, 20);
            ghostHitPoints.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 72);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 6;
            label7.Text = "GhoulHp";
            // 
            // ghoulHitPoints
            // 
            ghoulHitPoints.AutoSize = true;
            ghoulHitPoints.Location = new Point(100, 72);
            ghoulHitPoints.Name = "ghoulHitPoints";
            ghoulHitPoints.Size = new Size(0, 20);
            ghoulHitPoints.TabIndex = 7;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(3, 0);
            label.Name = "label";
            label.Size = new Size(68, 20);
            label.TabIndex = 0;
            label.Text = "PlayerHP";
            // 
            // batlabe
            // 
            batlabe.AutoSize = true;
            batlabe.Location = new Point(3, 22);
            batlabe.Name = "batlabe";
            batlabe.Size = new Size(51, 20);
            batlabe.TabIndex = 2;
            batlabe.Text = "BatHp";
            // 
            // moveUP
            // 
            moveUP.Location = new Point(675, 142);
            moveUP.Name = "moveUP";
            moveUP.Size = new Size(55, 29);
            moveUP.TabIndex = 16;
            moveUP.Text = "Up";
            moveUP.UseVisualStyleBackColor = true;
            moveUP.Click += moveUP_Click;
            // 
            // moveDown
            // 
            moveDown.Location = new Point(675, 212);
            moveDown.Name = "moveDown";
            moveDown.Size = new Size(64, 29);
            moveDown.TabIndex = 17;
            moveDown.Text = "Down";
            moveDown.UseVisualStyleBackColor = true;
            moveDown.Click += button2_Click;
            // 
            // moveLeft
            // 
            moveLeft.Location = new Point(645, 177);
            moveLeft.Name = "moveLeft";
            moveLeft.Size = new Size(55, 29);
            moveLeft.TabIndex = 18;
            moveLeft.Text = "Left";
            moveLeft.UseVisualStyleBackColor = true;
            moveLeft.Click += moveLeft_Click;
            // 
            // moveRight
            // 
            moveRight.Location = new Point(706, 177);
            moveRight.Name = "moveRight";
            moveRight.Size = new Size(55, 29);
            moveRight.TabIndex = 19;
            moveRight.Text = "Right";
            moveRight.UseVisualStyleBackColor = true;
            moveRight.Click += moveRight_Click;
            // 
            // attackRight
            // 
            attackRight.Location = new Point(706, 320);
            attackRight.Name = "attackRight";
            attackRight.Size = new Size(55, 29);
            attackRight.TabIndex = 23;
            attackRight.Text = "Right";
            attackRight.UseVisualStyleBackColor = true;
            attackRight.Click += attackRight_Click;
            // 
            // attackLeft
            // 
            attackLeft.Location = new Point(645, 320);
            attackLeft.Name = "attackLeft";
            attackLeft.Size = new Size(55, 29);
            attackLeft.TabIndex = 22;
            attackLeft.Text = "Left";
            attackLeft.UseVisualStyleBackColor = true;
            attackLeft.Click += attackLeft_Click;
            // 
            // attackDown
            // 
            attackDown.Location = new Point(675, 355);
            attackDown.Name = "attackDown";
            attackDown.Size = new Size(64, 29);
            attackDown.TabIndex = 21;
            attackDown.Text = "Down";
            attackDown.UseVisualStyleBackColor = true;
            attackDown.Click += attackDown_Click;
            // 
            // attackUp
            // 
            attackUp.Location = new Point(675, 285);
            attackUp.Name = "attackUp";
            attackUp.Size = new Size(55, 29);
            attackUp.TabIndex = 20;
            attackUp.Text = "Up";
            attackUp.UseVisualStyleBackColor = true;
            attackUp.Click += attackUp_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(668, 111);
            label9.Name = "label9";
            label9.Size = new Size(62, 28);
            label9.TabIndex = 24;
            label9.Text = "Move";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(662, 254);
            label10.Name = "label10";
            label10.Size = new Size(68, 28);
            label10.TabIndex = 25;
            label10.Text = "Attack";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 405);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(attackRight);
            Controls.Add(attackLeft);
            Controls.Add(attackDown);
            Controls.Add(attackUp);
            Controls.Add(moveRight);
            Controls.Add(moveLeft);
            Controls.Add(moveDown);
            Controls.Add(moveUP);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(inventoryRedPotion);
            Controls.Add(inventoryBluePotion);
            Controls.Add(inventoryMace);
            Controls.Add(inventoryBow);
            Controls.Add(picPlayer);
            Controls.Add(inventorySword);
            Controls.Add(picMace);
            Controls.Add(picSword);
            Controls.Add(picBow);
            Controls.Add(picGhoul);
            Controls.Add(picRedPotion);
            Controls.Add(picGhost);
            Controls.Add(picBluePotion);
            Controls.Add(picBat);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBluePotion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGhost).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRedPotion).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGhoul).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSword).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMace).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventorySword).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryMace).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBluePotion).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryRedPotion).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox picBat;
        private PictureBox picBluePotion;
        private PictureBox picGhost;
        private PictureBox picRedPotion;
        private PictureBox picPlayer;
        private PictureBox picGhoul;
        private PictureBox picBow;
        private PictureBox picSword;
        private PictureBox picMace;
        private PictureBox inventorySword;
        private PictureBox inventoryBow;
        private PictureBox inventoryMace;
        private PictureBox inventoryBluePotion;
        private PictureBox inventoryRedPotion;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label;
        private Label playerHitPoits;
        private Label batHitPoints;
        private Label Ghostlabel;
        private Label ghostHitPoints;
        private Label label7;
        private Label ghoulHitPoints;
        private Label batlabe;
        private Button moveUP;
        private Button moveDown;
        private Button moveLeft;
        private Button moveRight;
        private Button attackRight;
        private Button attackLeft;
        private Button attackDown;
        private Button attackUp;
        private Label label9;
        private Label label10;
    }
}