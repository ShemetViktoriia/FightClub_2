namespace FightClub_2
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblComputerHp = new System.Windows.Forms.Label();
            this.lblHumanHp = new System.Windows.Forms.Label();
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.progressBarComputer = new System.Windows.Forms.ProgressBar();
            this.progressBarHuman = new System.Windows.Forms.ProgressBar();
            this.btnHead = new System.Windows.Forms.Button();
            this.btnLegs = new System.Windows.Forms.Button();
            this.btnTorso = new System.Windows.Forms.Button();
            this.lblAttackOrProtect = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pctBoxHuman = new System.Windows.Forms.PictureBox();
            this.pctBoxComputer = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComputerHp
            // 
            this.lblComputerHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComputerHp.Location = new System.Drawing.Point(734, 50);
            this.lblComputerHp.Name = "lblComputerHp";
            this.lblComputerHp.Size = new System.Drawing.Size(110, 20);
            this.lblComputerHp.TabIndex = 76;
            this.lblComputerHp.Text = "ComputerHp";
            this.lblComputerHp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHumanHp
            // 
            this.lblHumanHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHumanHp.Location = new System.Drawing.Point(277, 46);
            this.lblHumanHp.Name = "lblHumanHp";
            this.lblHumanHp.Size = new System.Drawing.Size(89, 20);
            this.lblHumanHp.TabIndex = 75;
            this.lblHumanHp.Text = "HumanHp";
            this.lblHumanHp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHuman.Location = new System.Drawing.Point(12, 46);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(129, 24);
            this.lblHuman.TabIndex = 74;
            this.lblHuman.Text = "Player Name";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComputer.Location = new System.Drawing.Point(490, 46);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(101, 24);
            this.lblComputer.TabIndex = 73;
            this.lblComputer.Text = "Computer";
            // 
            // progressBarComputer
            // 
            this.progressBarComputer.Location = new System.Drawing.Point(494, 76);
            this.progressBarComputer.Name = "progressBarComputer";
            this.progressBarComputer.Size = new System.Drawing.Size(350, 50);
            this.progressBarComputer.TabIndex = 72;
            // 
            // progressBarHuman
            // 
            this.progressBarHuman.Location = new System.Drawing.Point(16, 73);
            this.progressBarHuman.Name = "progressBarHuman";
            this.progressBarHuman.Size = new System.Drawing.Size(350, 50);
            this.progressBarHuman.TabIndex = 71;
            // 
            // btnHead
            // 
            this.btnHead.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHead.Location = new System.Drawing.Point(381, 180);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(94, 70);
            this.btnHead.TabIndex = 77;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.ButtonPartBody_Click);
            // 
            // btnLegs
            // 
            this.btnLegs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLegs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLegs.Location = new System.Drawing.Point(381, 360);
            this.btnLegs.Name = "btnLegs";
            this.btnLegs.Size = new System.Drawing.Size(94, 70);
            this.btnLegs.TabIndex = 79;
            this.btnLegs.Text = "Legs";
            this.btnLegs.UseVisualStyleBackColor = true;
            this.btnLegs.Click += new System.EventHandler(this.ButtonPartBody_Click);
            // 
            // btnTorso
            // 
            this.btnTorso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTorso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTorso.Location = new System.Drawing.Point(381, 270);
            this.btnTorso.Name = "btnTorso";
            this.btnTorso.Size = new System.Drawing.Size(94, 70);
            this.btnTorso.TabIndex = 78;
            this.btnTorso.Text = "Torso";
            this.btnTorso.UseVisualStyleBackColor = true;
            this.btnTorso.Click += new System.EventHandler(this.ButtonPartBody_Click);
            // 
            // lblAttackOrProtect
            // 
            this.lblAttackOrProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAttackOrProtect.Location = new System.Drawing.Point(384, 153);
            this.lblAttackOrProtect.Name = "lblAttackOrProtect";
            this.lblAttackOrProtect.Size = new System.Drawing.Size(91, 24);
            this.lblAttackOrProtect.TabIndex = 80;
            this.lblAttackOrProtect.Text = "Attack/Protect";
            this.lblAttackOrProtect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLog.Location = new System.Drawing.Point(862, 126);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(106, 24);
            this.lblLog.TabIndex = 81;
            this.lblLog.Text = "Log Game";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1230, 33);
            this.menuStrip.TabIndex = 83;
            this.menuStrip.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 30);
            this.aboutToolStripMenuItem1.Text = "Game";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox.Location = new System.Drawing.Point(866, 153);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(350, 300);
            this.richTextBox.TabIndex = 84;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 482);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1230, 26);
            this.statusStrip.TabIndex = 85;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(150, 21);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // pctBoxHuman
            // 
            this.pctBoxHuman.Image = global::FightClub_2.Properties.Resources.Left;
            this.pctBoxHuman.Location = new System.Drawing.Point(16, 153);
            this.pctBoxHuman.Name = "pctBoxHuman";
            this.pctBoxHuman.Size = new System.Drawing.Size(350, 300);
            this.pctBoxHuman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxHuman.TabIndex = 86;
            this.pctBoxHuman.TabStop = false;
            // 
            // pctBoxComputer
            // 
            this.pctBoxComputer.Image = global::FightClub_2.Properties.Resources.Right;
            this.pctBoxComputer.Location = new System.Drawing.Point(494, 153);
            this.pctBoxComputer.Name = "pctBoxComputer";
            this.pctBoxComputer.Size = new System.Drawing.Size(350, 300);
            this.pctBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxComputer.TabIndex = 87;
            this.pctBoxComputer.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1230, 508);
            this.Controls.Add(this.pctBoxComputer);
            this.Controls.Add(this.pctBoxHuman);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblAttackOrProtect);
            this.Controls.Add(this.btnHead);
            this.Controls.Add(this.btnLegs);
            this.Controls.Add(this.btnTorso);
            this.Controls.Add(this.lblComputerHp);
            this.Controls.Add(this.lblHumanHp);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.progressBarComputer);
            this.Controls.Add(this.progressBarHuman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxHuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComputerHp;
        private System.Windows.Forms.Label lblHumanHp;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.ProgressBar progressBarComputer;
        private System.Windows.Forms.ProgressBar progressBarHuman;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.Button btnLegs;
        private System.Windows.Forms.Button btnTorso;
        private System.Windows.Forms.Label lblAttackOrProtect;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.PictureBox pctBoxHuman;
        private System.Windows.Forms.PictureBox pctBoxComputer;
    }
}

