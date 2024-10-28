namespace CAR_CRASH
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.roadGrey2 = new System.Windows.Forms.PictureBox();
            this.roadGrey1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.oHŘEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oHŘEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.oHŘEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.oAUTORCEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oAUTORCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadGrey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadGrey1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.roadGrey2);
            this.panel1.Controls.Add(this.roadGrey1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 600);
            this.panel1.TabIndex = 0;
            // 
            // award
            // 
            this.award.Image = ((System.Drawing.Image)(resources.GetObject("award.Image")));
            this.award.Location = new System.Drawing.Point(105, 95);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(360, 360);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 9;
            this.award.TabStop = false;
            this.award.Tag = "gameover";
            this.award.Click += new System.EventHandler(this.award_Click);
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(262, 472);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 101);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 8;
            this.player.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AI2.Image = ((System.Drawing.Image)(resources.GetObject("AI2.Image")));
            this.AI2.Location = new System.Drawing.Point(520, 51);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 7;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // explosion
            // 
            this.explosion.Image = ((System.Drawing.Image)(resources.GetObject("explosion.Image")));
            this.explosion.Location = new System.Drawing.Point(219, 258);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.Image = ((System.Drawing.Image)(resources.GetObject("AI1.Image")));
            this.AI1.Location = new System.Drawing.Point(25, 83);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 100);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 5;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // roadGrey2
            // 
            this.roadGrey2.Image = ((System.Drawing.Image)(resources.GetObject("roadGrey2.Image")));
            this.roadGrey2.Location = new System.Drawing.Point(0, 0);
            this.roadGrey2.Name = "roadGrey2";
            this.roadGrey2.Size = new System.Drawing.Size(584, 600);
            this.roadGrey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadGrey2.TabIndex = 4;
            this.roadGrey2.TabStop = false;
            // 
            // roadGrey1
            // 
            this.roadGrey1.Image = ((System.Drawing.Image)(resources.GetObject("roadGrey1.Image")));
            this.roadGrey1.Location = new System.Drawing.Point(0, -600);
            this.roadGrey1.Name = "roadGrey1";
            this.roadGrey1.Size = new System.Drawing.Size(584, 600);
            this.roadGrey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadGrey1.TabIndex = 3;
            this.roadGrey1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(239, 650);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold);
            this.txtScore.Location = new System.Drawing.Point(463, 603);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(88, 18);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "SKÓRE: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // oHŘEToolStripMenuItem
            // 
            this.oHŘEToolStripMenuItem.Name = "oHŘEToolStripMenuItem";
            this.oHŘEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oHŘEToolStripMenuItem.Text = "O HŘE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oHŘEToolStripMenuItem2});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(9, 621);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(81, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "O HŘE";
            this.menuStrip1.Click += new System.EventHandler(this.OHreMenuItem_Click);
            // 
            // oHŘEToolStripMenuItem2
            // 
            this.oHŘEToolStripMenuItem2.Name = "oHŘEToolStripMenuItem2";
            this.oHŘEToolStripMenuItem2.Size = new System.Drawing.Size(75, 22);
            this.oHŘEToolStripMenuItem2.Text = "O HŘE";
            // 
            // oHŘEToolStripMenuItem1
            // 
            this.oHŘEToolStripMenuItem1.Name = "oHŘEToolStripMenuItem1";
            this.oHŘEToolStripMenuItem1.Size = new System.Drawing.Size(75, 22);
            this.oHŘEToolStripMenuItem1.Text = "O HŘE";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAUTORCEToolStripMenuItem1});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip2.Location = new System.Drawing.Point(9, 652);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(128, 26);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Click += new System.EventHandler(this.OAutorceMenuItem_Click);
            // 
            // oAUTORCEToolStripMenuItem1
            // 
            this.oAUTORCEToolStripMenuItem1.Name = "oAUTORCEToolStripMenuItem1";
            this.oAUTORCEToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.oAUTORCEToolStripMenuItem1.Text = "O AUTORCE";
            // 
            // oAUTORCEToolStripMenuItem
            // 
            this.oAUTORCEToolStripMenuItem.Name = "oAUTORCEToolStripMenuItem";
            this.oAUTORCEToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.oAUTORCEToolStripMenuItem.Text = "O AUTORCE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Tag = "CAR CRASH";
            this.Text = "CAR CRASH";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadGrey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadGrey1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox roadGrey1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox roadGrey2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ToolStripMenuItem oHŘEToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem oHŘEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oAUTORCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oHŘEToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oAUTORCEToolStripMenuItem1;
    }
}

