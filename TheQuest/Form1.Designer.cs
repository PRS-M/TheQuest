namespace TheQuest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.ghoulLabel = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveGroupBox = new System.Windows.Forms.GroupBox();
            this.attackGroupBox = new System.Windows.Forms.GroupBox();
            this.attackLeftButton = new System.Windows.Forms.Button();
            this.attackDownButton = new System.Windows.Forms.Button();
            this.attackRightButton = new System.Windows.Forms.Button();
            this.attackUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            this.moveGroupBox.SuspendLayout();
            this.attackGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::TheQuest.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(122, 93);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = global::TheQuest.Properties.Resources.bat;
            this.bat.Location = new System.Drawing.Point(178, 93);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(50, 50);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bat.TabIndex = 1;
            this.bat.TabStop = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = global::TheQuest.Properties.Resources.ghost;
            this.ghost.Location = new System.Drawing.Point(234, 93);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(50, 50);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ghost.TabIndex = 2;
            this.ghost.TabStop = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = global::TheQuest.Properties.Resources.ghoul;
            this.ghoul.Location = new System.Drawing.Point(290, 93);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(50, 50);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ghoul.TabIndex = 3;
            this.ghoul.TabStop = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.bluePotion.Location = new System.Drawing.Point(346, 93);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(50, 50);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bluePotion.TabIndex = 4;
            this.bluePotion.TabStop = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = global::TheQuest.Properties.Resources.potion_red;
            this.redPotion.Location = new System.Drawing.Point(402, 93);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(50, 50);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redPotion.TabIndex = 5;
            this.redPotion.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = global::TheQuest.Properties.Resources.sword;
            this.sword.Location = new System.Drawing.Point(458, 93);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(50, 50);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sword.TabIndex = 6;
            this.sword.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = global::TheQuest.Properties.Resources.bow;
            this.bow.Location = new System.Drawing.Point(514, 93);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(50, 50);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bow.TabIndex = 7;
            this.bow.TabStop = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = global::TheQuest.Properties.Resources.mace;
            this.mace.Location = new System.Drawing.Point(570, 93);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(50, 50);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mace.TabIndex = 8;
            this.mace.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghoulLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghostLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(667, 390);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 62);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(54, 47);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoulHitPoints.TabIndex = 17;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            // 
            // ghoulLabel
            // 
            this.ghoulLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ghoulLabel.AutoSize = true;
            this.ghoulLabel.Location = new System.Drawing.Point(3, 47);
            this.ghoulLabel.Name = "ghoulLabel";
            this.ghoulLabel.Size = new System.Drawing.Size(35, 13);
            this.ghoulLabel.TabIndex = 16;
            this.ghoulLabel.Text = "Ghoul";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(54, 31);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 15;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghostLabel
            // 
            this.ghostLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.Location = new System.Drawing.Point(3, 31);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(35, 13);
            this.ghostLabel.TabIndex = 14;
            this.ghostLabel.Text = "Ghost";
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(54, 16);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 13;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(54, 1);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 11;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // batLabel
            // 
            this.batLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.batLabel.AutoSize = true;
            this.batLabel.Location = new System.Drawing.Point(3, 16);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(23, 13);
            this.batLabel.TabIndex = 12;
            this.batLabel.Text = "Bat";
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(3, 1);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 10;
            this.playerLabel.Text = "Player";
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.Image = global::TheQuest.Properties.Resources.sword;
            this.inventorySword.Location = new System.Drawing.Point(122, 495);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(75, 75);
            this.inventorySword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventorySword.TabIndex = 10;
            this.inventorySword.TabStop = false;
            this.inventorySword.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.Image = global::TheQuest.Properties.Resources.potion_blue;
            this.inventoryBluePotion.Location = new System.Drawing.Point(203, 495);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(75, 75);
            this.inventoryBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryBluePotion.TabIndex = 11;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.inventoryBluePotion_Click);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.Image = global::TheQuest.Properties.Resources.bow;
            this.inventoryBow.Location = new System.Drawing.Point(284, 495);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(75, 75);
            this.inventoryBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryBow.TabIndex = 12;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Click += new System.EventHandler(this.inventoryBow_Click);
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.Image = global::TheQuest.Properties.Resources.potion_red;
            this.inventoryRedPotion.Location = new System.Drawing.Point(365, 495);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(75, 75);
            this.inventoryRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryRedPotion.TabIndex = 13;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.inventoryRedPotion_Click);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.Image = global::TheQuest.Properties.Resources.mace;
            this.inventoryMace.Location = new System.Drawing.Point(446, 495);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(75, 75);
            this.inventoryMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inventoryMace.TabIndex = 14;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Click += new System.EventHandler(this.inventoryMace_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveUpButton.Location = new System.Drawing.Point(47, 19);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(35, 35);
            this.moveUpButton.TabIndex = 15;
            this.moveUpButton.Text = "↑";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveLeftButton.Location = new System.Drawing.Point(6, 34);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(35, 35);
            this.moveLeftButton.TabIndex = 16;
            this.moveLeftButton.Text = "←";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveDownButton.Location = new System.Drawing.Point(47, 60);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(35, 35);
            this.moveDownButton.TabIndex = 17;
            this.moveDownButton.Text = "↓";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveRightButton.Location = new System.Drawing.Point(90, 34);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(35, 35);
            this.moveRightButton.TabIndex = 18;
            this.moveRightButton.Text = "→";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveGroupBox
            // 
            this.moveGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.moveGroupBox.Controls.Add(this.moveLeftButton);
            this.moveGroupBox.Controls.Add(this.moveDownButton);
            this.moveGroupBox.Controls.Add(this.moveRightButton);
            this.moveGroupBox.Controls.Add(this.moveUpButton);
            this.moveGroupBox.Location = new System.Drawing.Point(543, 484);
            this.moveGroupBox.Name = "moveGroupBox";
            this.moveGroupBox.Size = new System.Drawing.Size(133, 102);
            this.moveGroupBox.TabIndex = 19;
            this.moveGroupBox.TabStop = false;
            this.moveGroupBox.Text = "MOVE";
            // 
            // attackGroupBox
            // 
            this.attackGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.attackGroupBox.Controls.Add(this.attackLeftButton);
            this.attackGroupBox.Controls.Add(this.attackDownButton);
            this.attackGroupBox.Controls.Add(this.attackRightButton);
            this.attackGroupBox.Controls.Add(this.attackUpButton);
            this.attackGroupBox.Location = new System.Drawing.Point(694, 484);
            this.attackGroupBox.Name = "attackGroupBox";
            this.attackGroupBox.Size = new System.Drawing.Size(133, 102);
            this.attackGroupBox.TabIndex = 20;
            this.attackGroupBox.TabStop = false;
            this.attackGroupBox.Text = "ATTACK";
            // 
            // attackLeftButton
            // 
            this.attackLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackLeftButton.Location = new System.Drawing.Point(6, 34);
            this.attackLeftButton.Name = "attackLeftButton";
            this.attackLeftButton.Size = new System.Drawing.Size(35, 35);
            this.attackLeftButton.TabIndex = 16;
            this.attackLeftButton.Text = "←";
            this.attackLeftButton.UseVisualStyleBackColor = true;
            this.attackLeftButton.Click += new System.EventHandler(this.attackLeftButton_Click);
            // 
            // attackDownButton
            // 
            this.attackDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackDownButton.Location = new System.Drawing.Point(47, 60);
            this.attackDownButton.Name = "attackDownButton";
            this.attackDownButton.Size = new System.Drawing.Size(35, 35);
            this.attackDownButton.TabIndex = 17;
            this.attackDownButton.Text = "↓";
            this.attackDownButton.UseVisualStyleBackColor = true;
            this.attackDownButton.Click += new System.EventHandler(this.attackDownButton_Click);
            // 
            // attackRightButton
            // 
            this.attackRightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackRightButton.Location = new System.Drawing.Point(90, 34);
            this.attackRightButton.Name = "attackRightButton";
            this.attackRightButton.Size = new System.Drawing.Size(35, 35);
            this.attackRightButton.TabIndex = 18;
            this.attackRightButton.Text = "→";
            this.attackRightButton.UseVisualStyleBackColor = true;
            this.attackRightButton.Click += new System.EventHandler(this.attackRightButton_Click);
            // 
            // attackUpButton
            // 
            this.attackUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackUpButton.Location = new System.Drawing.Point(47, 19);
            this.attackUpButton.Name = "attackUpButton";
            this.attackUpButton.Size = new System.Drawing.Size(35, 35);
            this.attackUpButton.TabIndex = 15;
            this.attackUpButton.Text = "↑";
            this.attackUpButton.UseVisualStyleBackColor = true;
            this.attackUpButton.Click += new System.EventHandler(this.attackUpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheQuest.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 623);
            this.Controls.Add(this.player);
            this.Controls.Add(this.attackGroupBox);
            this.Controls.Add(this.moveGroupBox);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventorySword);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.sword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            this.moveGroupBox.ResumeLayout(false);
            this.attackGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label ghoulLabel;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.GroupBox moveGroupBox;
        private System.Windows.Forms.GroupBox attackGroupBox;
        private System.Windows.Forms.Button attackLeftButton;
        private System.Windows.Forms.Button attackDownButton;
        private System.Windows.Forms.Button attackRightButton;
        private System.Windows.Forms.Button attackUpButton;
    }
}

