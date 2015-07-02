namespace Culminating
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrSprite = new System.Windows.Forms.Timer(this.components);
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.pgbStamina = new System.Windows.Forms.ProgressBar();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pgbHealth = new System.Windows.Forms.ProgressBar();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.tmrStamina = new System.Windows.Forms.Timer(this.components);
            this.pgbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.pbMouse = new System.Windows.Forms.PictureBox();
            this.pbD = new System.Windows.Forms.PictureBox();
            this.pbS = new System.Windows.Forms.PictureBox();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.pbW = new System.Windows.Forms.PictureBox();
            this.pbStamina = new System.Windows.Forms.PictureBox();
            this.pbStaminaBack = new System.Windows.Forms.PictureBox();
            this.pbKyubey = new System.Windows.Forms.PictureBox();
            this.pbArena = new System.Windows.Forms.PictureBox();
            this.lblWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStamina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaminaBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKyubey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArena)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSprite
            // 
            this.tmrSprite.Enabled = true;
            this.tmrSprite.Tick += new System.EventHandler(this.tmrSprite_Tick);
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 1;
            this.tmrMovement.Tick += new System.EventHandler(this.tmrMovement_Tick);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(12, 540);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 2;
            this.lblTest.Text = "label1";
            this.lblTest.Visible = false;
            // 
            // pgbStamina
            // 
            this.pgbStamina.Enabled = false;
            this.pgbStamina.Location = new System.Drawing.Point(14, 72);
            this.pgbStamina.Name = "pgbStamina";
            this.pgbStamina.Size = new System.Drawing.Size(100, 23);
            this.pgbStamina.TabIndex = 3;
            this.pgbStamina.Visible = false;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.BackColor = System.Drawing.Color.Black;
            this.lblScoreTitle.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.ForeColor = System.Drawing.Color.White;
            this.lblScoreTitle.Location = new System.Drawing.Point(331, 13);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(79, 30);
            this.lblScoreTitle.TabIndex = 0;
            this.lblScoreTitle.Text = "Score";
            this.lblScoreTitle.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(416, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(27, 30);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            this.lblScore.Visible = false;
            // 
            // pgbHealth
            // 
            this.pgbHealth.Location = new System.Drawing.Point(12, 13);
            this.pgbHealth.Name = "pgbHealth";
            this.pgbHealth.Size = new System.Drawing.Size(150, 24);
            this.pgbHealth.TabIndex = 6;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // tmrStamina
            // 
            this.tmrStamina.Enabled = true;
            this.tmrStamina.Interval = 10;
            this.tmrStamina.Tick += new System.EventHandler(this.tmrStamina_Tick);
            // 
            // pgbEnemyHealth
            // 
            this.pgbEnemyHealth.Location = new System.Drawing.Point(662, 13);
            this.pgbEnemyHealth.Name = "pgbEnemyHealth";
            this.pgbEnemyHealth.Size = new System.Drawing.Size(112, 24);
            this.pgbEnemyHealth.TabIndex = 7;
            this.pgbEnemyHealth.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(323, 97);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 80);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            this.lblTitle.Visible = false;
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.BackColor = System.Drawing.Color.Black;
            this.lblTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTutorial.Enabled = false;
            this.lblTutorial.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.ForeColor = System.Drawing.Color.White;
            this.lblTutorial.Location = new System.Drawing.Point(240, 215);
            this.lblTutorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(341, 80);
            this.lblTutorial.TabIndex = 11;
            this.lblTutorial.Text = "How to Play";
            this.lblTutorial.Visible = false;
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Black;
            this.lblPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlay.Enabled = false;
            this.lblPlay.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(323, 97);
            this.lblPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(148, 80);
            this.lblPlay.TabIndex = 12;
            this.lblPlay.Text = "Play";
            this.lblPlay.Visible = false;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // pbMouse
            // 
            this.pbMouse.BackColor = System.Drawing.Color.Black;
            this.pbMouse.BackgroundImage = global::Culminating.Properties.Resources.Mouse;
            this.pbMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMouse.Location = new System.Drawing.Point(450, 321);
            this.pbMouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMouse.Name = "pbMouse";
            this.pbMouse.Size = new System.Drawing.Size(189, 220);
            this.pbMouse.TabIndex = 17;
            this.pbMouse.TabStop = false;
            // 
            // pbD
            // 
            this.pbD.BackColor = System.Drawing.Color.Black;
            this.pbD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbD.BackgroundImage")));
            this.pbD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbD.Location = new System.Drawing.Point(281, 437);
            this.pbD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbD.Name = "pbD";
            this.pbD.Size = new System.Drawing.Size(96, 104);
            this.pbD.TabIndex = 16;
            this.pbD.TabStop = false;
            // 
            // pbS
            // 
            this.pbS.BackColor = System.Drawing.Color.Black;
            this.pbS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbS.BackgroundImage")));
            this.pbS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbS.Location = new System.Drawing.Point(177, 437);
            this.pbS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbS.Name = "pbS";
            this.pbS.Size = new System.Drawing.Size(96, 104);
            this.pbS.TabIndex = 15;
            this.pbS.TabStop = false;
            // 
            // pbA
            // 
            this.pbA.BackColor = System.Drawing.Color.Black;
            this.pbA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbA.BackgroundImage")));
            this.pbA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbA.Location = new System.Drawing.Point(69, 437);
            this.pbA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(96, 104);
            this.pbA.TabIndex = 14;
            this.pbA.TabStop = false;
            // 
            // pbW
            // 
            this.pbW.BackColor = System.Drawing.Color.Black;
            this.pbW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbW.BackgroundImage")));
            this.pbW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbW.Location = new System.Drawing.Point(177, 321);
            this.pbW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbW.Name = "pbW";
            this.pbW.Size = new System.Drawing.Size(96, 104);
            this.pbW.TabIndex = 13;
            this.pbW.TabStop = false;
            // 
            // pbStamina
            // 
            this.pbStamina.BackColor = System.Drawing.Color.OrangeRed;
            this.pbStamina.Location = new System.Drawing.Point(12, 42);
            this.pbStamina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbStamina.Name = "pbStamina";
            this.pbStamina.Size = new System.Drawing.Size(150, 8);
            this.pbStamina.TabIndex = 9;
            this.pbStamina.TabStop = false;
            // 
            // pbStaminaBack
            // 
            this.pbStaminaBack.Location = new System.Drawing.Point(12, 42);
            this.pbStaminaBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbStaminaBack.Name = "pbStaminaBack";
            this.pbStaminaBack.Size = new System.Drawing.Size(150, 8);
            this.pbStaminaBack.TabIndex = 8;
            this.pbStaminaBack.TabStop = false;
            // 
            // pbKyubey
            // 
            this.pbKyubey.BackColor = System.Drawing.Color.Transparent;
            this.pbKyubey.Image = global::Culminating.Properties.Resources.Kyubey6;
            this.pbKyubey.Location = new System.Drawing.Point(330, 215);
            this.pbKyubey.Name = "pbKyubey";
            this.pbKyubey.Size = new System.Drawing.Size(68, 41);
            this.pbKyubey.TabIndex = 0;
            this.pbKyubey.TabStop = false;
            this.pbKyubey.Visible = false;
            // 
            // pbArena
            // 
            this.pbArena.BackColor = System.Drawing.Color.Black;
            this.pbArena.Location = new System.Drawing.Point(0, 0);
            this.pbArena.Name = "pbArena";
            this.pbArena.Size = new System.Drawing.Size(784, 562);
            this.pbArena.TabIndex = 1;
            this.pbArena.TabStop = false;
            this.pbArena.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArena_Paint);
            this.pbArena.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbArena_MouseClick);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Black;
            this.lblWin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWin.Enabled = false;
            this.lblWin.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(268, 215);
            this.lblWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(268, 80);
            this.lblWin.TabIndex = 18;
            this.lblWin.Text = "You Win!";
            this.lblWin.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.pbMouse);
            this.Controls.Add(this.pbD);
            this.Controls.Add(this.pbS);
            this.Controls.Add(this.pbA);
            this.Controls.Add(this.pbW);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbStamina);
            this.Controls.Add(this.pbStaminaBack);
            this.Controls.Add(this.pgbEnemyHealth);
            this.Controls.Add(this.pgbHealth);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.pgbStamina);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.pbKyubey);
            this.Controls.Add(this.pbArena);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStamina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaminaBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKyubey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKyubey;
        private System.Windows.Forms.Timer tmrSprite;
        private System.Windows.Forms.Timer tmrMovement;
        private System.Windows.Forms.PictureBox pbArena;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ProgressBar pgbStamina;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar pgbHealth;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Timer tmrStamina;
        private System.Windows.Forms.ProgressBar pgbEnemyHealth;
        private System.Windows.Forms.PictureBox pbStaminaBack;
        private System.Windows.Forms.PictureBox pbStamina;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.PictureBox pbW;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.PictureBox pbS;
        private System.Windows.Forms.PictureBox pbD;
        private System.Windows.Forms.PictureBox pbMouse;
        private System.Windows.Forms.Label lblWin;
    }
}

