
using System;

namespace lab7
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
            this.drawTreeButton = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.drawStar = new System.Windows.Forms.Button();
            this.drawPresents = new System.Windows.Forms.Button();
            this.drawBalls = new System.Windows.Forms.Button();
            this.drawLights = new System.Windows.Forms.Button();
            this.drawGarland = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.musicButton = new System.Windows.Forms.Button();
            this.lightTimer = new System.Windows.Forms.Timer(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawTreeButton
            // 
            this.drawTreeButton.BackColor = System.Drawing.Color.Turquoise;
            this.drawTreeButton.Location = new System.Drawing.Point(79, 12);
            this.drawTreeButton.Name = "drawTreeButton";
            this.drawTreeButton.Size = new System.Drawing.Size(82, 37);
            this.drawTreeButton.TabIndex = 0;
            this.drawTreeButton.Text = "Draw christmas tree";
            this.drawTreeButton.UseVisualStyleBackColor = false;
            this.drawTreeButton.Click += new System.EventHandler(this.drawTree_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel.Controls.Add(this.axWindowsMediaPlayer1);
            this.Panel.Location = new System.Drawing.Point(79, 55);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(360, 300);
            this.Panel.TabIndex = 1;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // drawStar
            // 
            this.drawStar.BackColor = System.Drawing.Color.LightCoral;
            this.drawStar.Location = new System.Drawing.Point(488, 55);
            this.drawStar.Name = "drawStar";
            this.drawStar.Size = new System.Drawing.Size(95, 23);
            this.drawStar.TabIndex = 2;
            this.drawStar.Text = "Draw star";
            this.drawStar.UseVisualStyleBackColor = false;
            this.drawStar.Click += new System.EventHandler(this.drawStar_Click);
            // 
            // drawPresents
            // 
            this.drawPresents.BackColor = System.Drawing.Color.Plum;
            this.drawPresents.Location = new System.Drawing.Point(488, 93);
            this.drawPresents.Name = "drawPresents";
            this.drawPresents.Size = new System.Drawing.Size(95, 23);
            this.drawPresents.TabIndex = 3;
            this.drawPresents.Text = "Draw presents";
            this.drawPresents.UseVisualStyleBackColor = false;
            this.drawPresents.Click += new System.EventHandler(this.drawPresents_Click);
            // 
            // drawBalls
            // 
            this.drawBalls.BackColor = System.Drawing.Color.CornflowerBlue;
            this.drawBalls.Location = new System.Drawing.Point(488, 134);
            this.drawBalls.Name = "drawBalls";
            this.drawBalls.Size = new System.Drawing.Size(95, 23);
            this.drawBalls.TabIndex = 4;
            this.drawBalls.Text = "Draw balls";
            this.drawBalls.UseVisualStyleBackColor = false;
            this.drawBalls.Click += new System.EventHandler(this.drawBalls_Click);
            // 
            // drawLights
            // 
            this.drawLights.BackColor = System.Drawing.Color.SkyBlue;
            this.drawLights.Location = new System.Drawing.Point(488, 175);
            this.drawLights.Name = "drawLights";
            this.drawLights.Size = new System.Drawing.Size(95, 23);
            this.drawLights.TabIndex = 5;
            this.drawLights.Text = "Draw lights";
            this.drawLights.UseVisualStyleBackColor = false;
            this.drawLights.Click += new System.EventHandler(this.drawLights_Click);
            // 
            // drawGarland
            // 
            this.drawGarland.BackColor = System.Drawing.Color.LimeGreen;
            this.drawGarland.Location = new System.Drawing.Point(488, 216);
            this.drawGarland.Name = "drawGarland";
            this.drawGarland.Size = new System.Drawing.Size(95, 23);
            this.drawGarland.TabIndex = 6;
            this.drawGarland.Text = "Draw garland";
            this.drawGarland.UseVisualStyleBackColor = false;
            this.drawGarland.Click += new System.EventHandler(this.drawGarland_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Goldenrod;
            this.refreshButton.Location = new System.Drawing.Point(488, 324);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(95, 31);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(350, 290);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // musicButton
            // 
            this.musicButton.BackColor = System.Drawing.Color.Yellow;
            this.musicButton.Location = new System.Drawing.Point(488, 290);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(95, 28);
            this.musicButton.TabIndex = 8;
            this.musicButton.Text = "Play music";
            this.musicButton.UseVisualStyleBackColor = false;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // lightTimer
            // 
            this.lightTimer.Enabled = true;
            this.lightTimer.Interval = 1000;
            this.lightTimer.Tick += new System.EventHandler(this.lightTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.drawGarland);
            this.Controls.Add(this.drawLights);
            this.Controls.Add(this.drawBalls);
            this.Controls.Add(this.drawPresents);
            this.Controls.Add(this.drawStar);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.drawTreeButton);
            this.Name = "Form1";
            this.Text = "Christmas tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button drawTreeButton;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button drawStar;
        private System.Windows.Forms.Button drawPresents;
        private System.Windows.Forms.Button drawBalls;
        private System.Windows.Forms.Button drawLights;
        private System.Windows.Forms.Button drawGarland;
        private System.Windows.Forms.Button refreshButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button musicButton;
        private System.Windows.Forms.Timer lightTimer;
    }
}

