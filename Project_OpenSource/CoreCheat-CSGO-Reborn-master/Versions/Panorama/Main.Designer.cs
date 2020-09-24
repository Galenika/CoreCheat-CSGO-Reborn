﻿namespace CoreCheat_Reborn.Versions.Panorama
{
    partial class Main
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ControlBoxPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.logoTXT = new System.Windows.Forms.Label();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MiscsButton = new System.Windows.Forms.Button();
            this.selectIndicator = new System.Windows.Forms.Panel();
            this.AimbotButton = new System.Windows.Forms.Button();
            this.AssistsButton = new System.Windows.Forms.Button();
            this.VisualsButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.botGlow = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ColorTimer = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            this.ControlBoxPanel.SuspendLayout();
            this.SideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.ControlBoxPanel);
            this.TopPanel.Controls.Add(this.logoTXT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(270, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(6);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1162, 54);
            this.TopPanel.TabIndex = 7;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // ControlBoxPanel
            // 
            this.ControlBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ControlBoxPanel.Controls.Add(this.MinimizeButton);
            this.ControlBoxPanel.Controls.Add(this.CloseButton);
            this.ControlBoxPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBoxPanel.Location = new System.Drawing.Point(960, 0);
            this.ControlBoxPanel.Margin = new System.Windows.Forms.Padding(6);
            this.ControlBoxPanel.Name = "ControlBoxPanel";
            this.ControlBoxPanel.Size = new System.Drawing.Size(202, 54);
            this.ControlBoxPanel.TabIndex = 2;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(8, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(97, 54);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(105, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(97, 54);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // logoTXT
            // 
            this.logoTXT.AutoSize = true;
            this.logoTXT.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.logoTXT.ForeColor = System.Drawing.Color.White;
            this.logoTXT.Location = new System.Drawing.Point(6, 0);
            this.logoTXT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logoTXT.Name = "logoTXT";
            this.logoTXT.Size = new System.Drawing.Size(383, 42);
            this.logoTXT.TabIndex = 1;
            this.logoTXT.Text = "Core Cheat =|= Panorama";
            this.logoTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.logoTXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.logoTXT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.Black;
            this.SideBarPanel.Controls.Add(this.SettingsButton);
            this.SideBarPanel.Controls.Add(this.MiscsButton);
            this.SideBarPanel.Controls.Add(this.selectIndicator);
            this.SideBarPanel.Controls.Add(this.AimbotButton);
            this.SideBarPanel.Controls.Add(this.AssistsButton);
            this.SideBarPanel.Controls.Add(this.VisualsButton);
            this.SideBarPanel.Controls.Add(this.LogoPicture);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Margin = new System.Windows.Forms.Padding(6);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(270, 700);
            this.SideBarPanel.TabIndex = 9;
            this.SideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            this.SideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseMove);
            this.SideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseUp);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Black;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Location = new System.Drawing.Point(31, 439);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(244, 68);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = " Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MiscsButton
            // 
            this.MiscsButton.BackColor = System.Drawing.Color.Black;
            this.MiscsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MiscsButton.FlatAppearance.BorderSize = 0;
            this.MiscsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MiscsButton.ForeColor = System.Drawing.Color.White;
            this.MiscsButton.Location = new System.Drawing.Point(31, 362);
            this.MiscsButton.Margin = new System.Windows.Forms.Padding(6);
            this.MiscsButton.Name = "MiscsButton";
            this.MiscsButton.Size = new System.Drawing.Size(244, 68);
            this.MiscsButton.TabIndex = 7;
            this.MiscsButton.Text = " Miscs    ";
            this.MiscsButton.UseVisualStyleBackColor = false;
            this.MiscsButton.Click += new System.EventHandler(this.MiscsButton_Click);
            // 
            // selectIndicator
            // 
            this.selectIndicator.BackColor = System.Drawing.Color.White;
            this.selectIndicator.Location = new System.Drawing.Point(22, 131);
            this.selectIndicator.Margin = new System.Windows.Forms.Padding(6);
            this.selectIndicator.Name = "selectIndicator";
            this.selectIndicator.Size = new System.Drawing.Size(9, 68);
            this.selectIndicator.TabIndex = 6;
            // 
            // AimbotButton
            // 
            this.AimbotButton.BackColor = System.Drawing.Color.Black;
            this.AimbotButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AimbotButton.FlatAppearance.BorderSize = 0;
            this.AimbotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimbotButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AimbotButton.ForeColor = System.Drawing.Color.White;
            this.AimbotButton.Location = new System.Drawing.Point(31, 284);
            this.AimbotButton.Margin = new System.Windows.Forms.Padding(6);
            this.AimbotButton.Name = "AimbotButton";
            this.AimbotButton.Size = new System.Drawing.Size(248, 68);
            this.AimbotButton.TabIndex = 5;
            this.AimbotButton.Text = " Aimbot";
            this.AimbotButton.UseVisualStyleBackColor = false;
            this.AimbotButton.Click += new System.EventHandler(this.AimbotButton_Click);
            // 
            // AssistsButton
            // 
            this.AssistsButton.BackColor = System.Drawing.Color.Black;
            this.AssistsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AssistsButton.FlatAppearance.BorderSize = 0;
            this.AssistsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssistsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AssistsButton.ForeColor = System.Drawing.Color.White;
            this.AssistsButton.Location = new System.Drawing.Point(31, 207);
            this.AssistsButton.Margin = new System.Windows.Forms.Padding(6);
            this.AssistsButton.Name = "AssistsButton";
            this.AssistsButton.Size = new System.Drawing.Size(248, 68);
            this.AssistsButton.TabIndex = 4;
            this.AssistsButton.Text = "Assists";
            this.AssistsButton.UseVisualStyleBackColor = false;
            this.AssistsButton.Click += new System.EventHandler(this.AssistsButton_Click);
            // 
            // VisualsButton
            // 
            this.VisualsButton.BackColor = System.Drawing.Color.Black;
            this.VisualsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VisualsButton.FlatAppearance.BorderSize = 0;
            this.VisualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VisualsButton.ForeColor = System.Drawing.Color.White;
            this.VisualsButton.Location = new System.Drawing.Point(31, 131);
            this.VisualsButton.Margin = new System.Windows.Forms.Padding(6);
            this.VisualsButton.Name = "VisualsButton";
            this.VisualsButton.Size = new System.Drawing.Size(244, 68);
            this.VisualsButton.TabIndex = 3;
            this.VisualsButton.Text = "Visuals";
            this.VisualsButton.UseVisualStyleBackColor = false;
            this.VisualsButton.Click += new System.EventHandler(this.VisualsButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.Image = global::CoreCheat_Reborn.Properties.Resources.CoreCheatTransparent;
            this.LogoPicture.Location = new System.Drawing.Point(103, 11);
            this.LogoPicture.Margin = new System.Windows.Forms.Padding(6);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(68, 68);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicture.TabIndex = 0;
            this.LogoPicture.TabStop = false;
            // 
            // botGlow
            // 
            this.botGlow.BackColor = System.Drawing.Color.Black;
            this.botGlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.botGlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botGlow.Location = new System.Drawing.Point(0, 700);
            this.botGlow.Margin = new System.Windows.Forms.Padding(6);
            this.botGlow.Name = "botGlow";
            this.botGlow.Size = new System.Drawing.Size(1432, 2);
            this.botGlow.TabIndex = 8;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(270, 54);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(6);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1162, 646);
            this.MainPanel.TabIndex = 10;
            // 
            // ColorTimer
            // 
            this.ColorTimer.Enabled = true;
            this.ColorTimer.Tick += new System.EventHandler(this.ColorTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 702);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.botGlow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ControlBoxPanel.ResumeLayout(false);
            this.SideBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ControlBoxPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel selectIndicator;
        private System.Windows.Forms.Button AimbotButton;
        private System.Windows.Forms.Button AssistsButton;
        private System.Windows.Forms.Button VisualsButton;
        private System.Windows.Forms.Label logoTXT;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel botGlow;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button MiscsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Timer ColorTimer;
    }
}