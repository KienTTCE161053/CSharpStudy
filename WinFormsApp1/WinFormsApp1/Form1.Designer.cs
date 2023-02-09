namespace WinFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGamePicture = new System.Windows.Forms.Panel();
            this.pgbHP = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGameInfo = new System.Windows.Forms.Panel();
            this.lblAPPText = new System.Windows.Forms.Label();
            this.lblAPP = new System.Windows.Forms.Label();
            this.lblADPText = new System.Windows.Forms.Label();
            this.lblADP = new System.Windows.Forms.Label();
            this.lblHPText = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblMobNameText = new System.Windows.Forms.Label();
            this.lblMobName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlGamePicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // pnlGamePicture
            // 
            this.pnlGamePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlGamePicture.Controls.Add(this.pgbHP);
            this.pnlGamePicture.Controls.Add(this.pictureBox1);
            this.pnlGamePicture.Location = new System.Drawing.Point(12, 27);
            this.pnlGamePicture.Name = "pnlGamePicture";
            this.pnlGamePicture.Size = new System.Drawing.Size(776, 298);
            this.pnlGamePicture.TabIndex = 1;
            // 
            // pgbHP
            // 
            this.pgbHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgbHP.Location = new System.Drawing.Point(0, 0);
            this.pgbHP.Name = "pgbHP";
            this.pgbHP.Size = new System.Drawing.Size(776, 23);
            this.pgbHP.TabIndex = 8;
            this.pgbHP.Value = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 298);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlGameInfo
            // 
            this.pnlGameInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlGameInfo.Controls.Add(this.lblAPPText);
            this.pnlGameInfo.Controls.Add(this.lblAPP);
            this.pnlGameInfo.Controls.Add(this.lblADPText);
            this.pnlGameInfo.Controls.Add(this.lblADP);
            this.pnlGameInfo.Controls.Add(this.lblHPText);
            this.pnlGameInfo.Controls.Add(this.lblHP);
            this.pnlGameInfo.Controls.Add(this.lblMobNameText);
            this.pnlGameInfo.Controls.Add(this.lblMobName);
            this.pnlGameInfo.Location = new System.Drawing.Point(12, 333);
            this.pnlGameInfo.Name = "pnlGameInfo";
            this.pnlGameInfo.Size = new System.Drawing.Size(776, 231);
            this.pnlGameInfo.TabIndex = 2;
            // 
            // lblAPPText
            // 
            this.lblAPPText.AutoSize = true;
            this.lblAPPText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAPPText.Location = new System.Drawing.Point(164, 133);
            this.lblAPPText.Name = "lblAPPText";
            this.lblAPPText.Size = new System.Drawing.Size(208, 21);
            this.lblAPPText.TabIndex = 7;
            this.lblAPPText.Text = "Mod Magic Damage Depend";
            // 
            // lblAPP
            // 
            this.lblAPP.AutoSize = true;
            this.lblAPP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAPP.Location = new System.Drawing.Point(3, 133);
            this.lblAPP.Name = "lblAPP";
            this.lblAPP.Size = new System.Drawing.Size(38, 21);
            this.lblAPP.TabIndex = 6;
            this.lblAPP.Text = "APP";
            // 
            // lblADPText
            // 
            this.lblADPText.AutoSize = true;
            this.lblADPText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblADPText.Location = new System.Drawing.Point(164, 91);
            this.lblADPText.Name = "lblADPText";
            this.lblADPText.Size = new System.Drawing.Size(222, 21);
            this.lblADPText.TabIndex = 5;
            this.lblADPText.Text = "Mod Physical Damage Depend\r\n";
            // 
            // lblADP
            // 
            this.lblADP.AutoSize = true;
            this.lblADP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblADP.Location = new System.Drawing.Point(3, 91);
            this.lblADP.Name = "lblADP";
            this.lblADP.Size = new System.Drawing.Size(40, 21);
            this.lblADP.TabIndex = 4;
            this.lblADP.Text = "ADP";
            // 
            // lblHPText
            // 
            this.lblHPText.AutoSize = true;
            this.lblHPText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHPText.Location = new System.Drawing.Point(164, 54);
            this.lblHPText.Name = "lblHPText";
            this.lblHPText.Size = new System.Drawing.Size(102, 21);
            this.lblHPText.TabIndex = 3;
            this.lblHPText.Text = "Your mob HP";
            this.lblHPText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHP.Location = new System.Drawing.Point(3, 54);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(30, 21);
            this.lblHP.TabIndex = 2;
            this.lblHP.Text = "HP";
            // 
            // lblMobNameText
            // 
            this.lblMobNameText.AutoSize = true;
            this.lblMobNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMobNameText.Location = new System.Drawing.Point(164, 19);
            this.lblMobNameText.Name = "lblMobNameText";
            this.lblMobNameText.Size = new System.Drawing.Size(205, 21);
            this.lblMobNameText.TabIndex = 1;
            this.lblMobNameText.Text = "Your mob name will be here";
            this.lblMobNameText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMobName
            // 
            this.lblMobName.AutoSize = true;
            this.lblMobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMobName.Location = new System.Drawing.Point(3, 19);
            this.lblMobName.Name = "lblMobName";
            this.lblMobName.Size = new System.Drawing.Size(52, 21);
            this.lblMobName.TabIndex = 0;
            this.lblMobName.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 571);
            this.Controls.Add(this.pnlGameInfo);
            this.Controls.Add(this.pnlGamePicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGamePicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlGameInfo.ResumeLayout(false);
            this.pnlGameInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGamePicture;
        private System.Windows.Forms.Panel pnlGameInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMobName;
        private System.Windows.Forms.Label lblHPText;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblMobNameText;
        private System.Windows.Forms.Label lblAPPText;
        private System.Windows.Forms.Label lblAPP;
        private System.Windows.Forms.Label lblADPText;
        private System.Windows.Forms.Label lblADP;
        private System.Windows.Forms.ProgressBar pgbHP;
    }
}
