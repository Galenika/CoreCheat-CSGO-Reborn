﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreCheat_Reborn.Versions.Panorama
{
    public partial class Main : Form
    {
        Pages.Visuals VisualsPage = new Pages.Visuals();
        Pages.Assists AssistsPage = new Pages.Assists();
        Pages.Aimbot AimbotPage = new Pages.Aimbot();
        Pages.Miscs MiscsPage = new Pages.Miscs();
        Pages.Settings SettingsPage = new Pages.Settings();

        private bool mouseDown;
        private Point lastLocation;
        Timer fadeInTimer = new Timer();
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }
        private void Drag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Main()
        {
            InitializeComponent();
            Opacity = 0;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(VisualsPage);
            VisualsPage.Dock = DockStyle.Fill;
            SideBarPanel.Width = 0;
            VisualsPage.Location = new Point(ClientSize.Width / 2 - MainPanel.Size.Width / 2, ClientSize.Height / 2 - MainPanel.Size.Height / 2);
        }
        private void LoadTheme()
        {
            TopPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            SideBarPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MainPanel.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            topGlow.BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            logoTXT.ForeColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            selectIndicator.BackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            VisualsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            AssistsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            AimbotButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            MiscsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            SettingsButton.FlatAppearance.MouseDownBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            VisualsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AssistsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AimbotButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            MiscsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            SettingsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            CloseButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MinimizeButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
            MinimizeButton.FlatAppearance.MouseOverBackColor = ProgramSettings.CheatTheme.SecondaryThemeColor;
            //MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(MinimizeButton.BackColor.R - 10, MinimizeButton.BackColor.G - 10, MinimizeButton.BackColor.B - 10);
            logoTXT.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            VisualsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            AssistsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            AimbotButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            MiscsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            SettingsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            CloseButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            MinimizeButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            ControlBoxPanel.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 4, ProgramSettings.CheatTheme.MainThemeColor.G - 4, ProgramSettings.CheatTheme.MainThemeColor.B - 4);
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                fadeInTimer.Stop();
                for (int i = 0; i <= 147; i++)
                    SideBarPanel.Width = i;
            }
            else
                Opacity += 0.05;
        }
        private void DarkBackAll()
        {
            VisualsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            AssistsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            AimbotButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            MiscsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            SettingsButton.BackColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.R - 7, ProgramSettings.CheatTheme.MainThemeColor.G - 7, ProgramSettings.CheatTheme.MainThemeColor.B - 7);
            VisualsButton.ForeColor = Color.DimGray;
            AssistsButton.ForeColor = Color.DimGray;
            AimbotButton.ForeColor = Color.DimGray;
            MiscsButton.ForeColor = Color.DimGray;
            SettingsButton.ForeColor = Color.DimGray;
        }
        private void InitCheat()
        {
            fadeInTimer.Interval = 30;
            fadeInTimer.Tick += new EventHandler(fadeIn);
            fadeInTimer.Start();
            LoadTheme();
            DarkBackAll();
            Classes.Functions.InitializeProject();
            VisualsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            VisualsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
            selectIndicator.Location = new Point(12, 71);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void VisualsButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(12, 71);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(VisualsPage);
            DarkBackAll();
            VisualsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            VisualsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void AssistsButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(12, 112);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(AssistsPage);
            DarkBackAll();
            AssistsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AssistsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void AimbotButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(12, 154);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(AimbotPage);
            DarkBackAll();
            AimbotButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            AimbotButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void MiscsButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(12, 196);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(MiscsPage);
            DarkBackAll();
            MiscsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            MiscsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            selectIndicator.Location = new Point(12, 238);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(SettingsPage);
            DarkBackAll();
            SettingsButton.BackColor = ProgramSettings.CheatTheme.MainThemeColor;
            SettingsButton.ForeColor = Color.FromArgb(ProgramSettings.CheatTheme.MainThemeColor.ToArgb() ^ 0xffffff);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitCheat();
        }
    }
}
