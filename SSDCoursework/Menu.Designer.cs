namespace SSDCoursework
{
    partial class Menu
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
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.Transparent;
            this.imgTitle.Image = global::SSDCoursework.Properties.Resources.title;
            this.imgTitle.Location = new System.Drawing.Point(12, 12);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(507, 90);
            this.imgTitle.TabIndex = 0;
            this.imgTitle.TabStop = false;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(71, 128);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(298, 65);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Easy Mode";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Green;
            this.btnHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.ForeColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(71, 216);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(298, 65);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Hard Mode";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(71, 308);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(298, 65);
            this.btnLeaderboard.TabIndex = 3;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Lime;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(71, 397);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(298, 65);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(662, 431);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(109, 111);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvatar.TabIndex = 5;
            this.imgAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(792, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(777, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "High Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(642, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Player Details: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(874, 448);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "label5";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.White;
            this.lblHighScore.Location = new System.Drawing.Point(874, 501);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(51, 20);
            this.lblHighScore.TabIndex = 12;
            this.lblHighScore.Text = "label7";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Chartreuse;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(71, 487);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(298, 65);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::SSDCoursework.Properties.Resources.first_aid_logo;
            this.imgLogo.Location = new System.Drawing.Point(697, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(238, 192);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 14;
            this.imgLogo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SSDCoursework.Properties.Resources.pulse;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(947, 564);
            this.ControlBox = false;
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.imgTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}