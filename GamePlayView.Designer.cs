namespace GameShotOut
{
    partial class GamePlayView
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
            this.lbAmmo = new System.Windows.Forms.Label();
            this.lbKills = new System.Windows.Forms.Label();
            this.lbHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAmmo
            // 
            this.lbAmmo.AutoSize = true;
            this.lbAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lbAmmo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmmo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAmmo.Location = new System.Drawing.Point(111, 12);
            this.lbAmmo.Name = "lbAmmo";
            this.lbAmmo.Size = new System.Drawing.Size(93, 27);
            this.lbAmmo.TabIndex = 0;
            this.lbAmmo.Text = "Ammo: 1";
            // 
            // lbKills
            // 
            this.lbKills.AutoSize = true;
            this.lbKills.BackColor = System.Drawing.Color.Transparent;
            this.lbKills.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKills.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbKills.Location = new System.Drawing.Point(543, 12);
            this.lbKills.Name = "lbKills";
            this.lbKills.Size = new System.Drawing.Size(72, 27);
            this.lbKills.TabIndex = 1;
            this.lbKills.Text = "Kills: 1";
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.BackColor = System.Drawing.Color.Transparent;
            this.lbHealth.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHealth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbHealth.Location = new System.Drawing.Point(919, 12);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(75, 27);
            this.lbHealth.TabIndex = 2;
            this.lbHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.Firebrick;
            this.healthBar.Location = new System.Drawing.Point(1010, 12);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(241, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::GameShotOut.Properties.Resources.up;
            this.picPlayer.Location = new System.Drawing.Point(591, 331);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(71, 100);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // GamePlayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1282, 773);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.lbHealth);
            this.Controls.Add(this.lbKills);
            this.Controls.Add(this.lbAmmo);
            this.Name = "GamePlayView";
            this.Text = "Game Play";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAmmo;
        private System.Windows.Forms.Label lbKills;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer GameTimer;
    }
}

