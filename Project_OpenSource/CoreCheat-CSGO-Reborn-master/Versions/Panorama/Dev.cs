﻿using System;
using System.Windows.Forms;
using CoreCheat_Reborn.CheatClasses;
using CoreCheat_Reborn.SDK.Controllers;
using CoreCheat_Reborn.SDK.Entities;
using CoreCheat_Reborn.SDK.Managers;

namespace CoreCheat_Reborn.Versions.Panorama
{
    public partial class Dev : MetroFramework.Forms.MetroForm
    {
        public static string status = "-=[Dev Infos]=-" + Environment.NewLine;
        public Dev()
        {
            InitializeComponent();
        }
        private void Dev_Load(object sender, EventArgs e)
        {
            Modules.ClientDLLAdress = Modules.GetModule("csgo", Modules.ClientDLLName);
            Modules.EngineDLLAdress = Modules.GetModule("csgo", Modules.EngineDLLName);
            Modules.ShaderAPIAdress = Modules.GetModule("csgo", Modules.ShaderAPIName);
        }
        private void Infogetter_Tick(object sender, EventArgs e)
        {
            status = "-=[Dev Infos]=-" + Environment.NewLine;
            AddSeperator(status);
            AddInfo("Client.DLL", Modules.ClientDLLAdress);
            AddInfo("Engine.DLL", Modules.EngineDLLAdress);
            AddInfo("Shader API", Modules.ShaderAPIAdress);
            AddSeperator(status);
            AddInfo("LPBase", CLocalPlayer.LocalPlayerBase);
            if (CLocalPlayer.IsPlaying)
            {
                AddInfo("Name", CLocalPlayer.Name);
                AddInfo("Health", CLocalPlayer.Health);
                AddInfo("Flag", CLocalPlayer.Flag);
                AddInfo("Team", CLocalPlayer.Team);
                AddInfo("CrossID", CLocalPlayer.CrossID);
                AddInfo("ScopeLevel", CLocalPlayer.ScopeLevel);
                AddInfo("Weapon", CLocalPlayer.WeaponName);
                AddInfo("IsAlive", CLocalPlayer.isAlive);
                AddInfo("Armor", CLocalPlayer.ArmorValue);
                AddInfo("Location", CLocalPlayer.LastPlace);
                AddInfo("ShootedBullets", CLocalPlayer.ShootedBullets);
                AddInfo("VAng", CLocalPlayer.ViewAngles);
            }
            else
                AddInfo("NOT PLAYING", "");
            AddSeperator(status);
            AddInfo("CBase", EngineClient.ClientState);
            AddInfo("State", EngineClient.GameState);
            if (CLocalPlayer.IsPlaying)
            {
                AddInfo("Max Player", EngineClient.MaxPlayer);
                AddInfo("Entity Count", EngineClient.EntityCount);
                AddInfo("BombTraject", EngineClient.BombTraject);
            }
            statusTXT.Text = status;
        }
        public static void AddInfo(string name, object data)
        {
            status += "[" + name + "] => " + data.ToString() + Environment.NewLine;
        }
        public static void AddSeperator(string Target)
        {
            status += "-----------------" + Environment.NewLine;
        }
        private void JumpBtn_Click(object sender, EventArgs e)
        {
            //LocalPlayer.Jump();
        }
        private void ShootBtn_Click(object sender, EventArgs e)
        {
            CLocalPlayer.Shoot(10);
        }
        private void TestBtn_Click(object sender, EventArgs e)
        {
            //SDK.Overlay.CoreOverlay.Load("csgo", "Counter-Strike: Global Offensive");
            //SDK.Controllers.ClientCMD.Exec("say \"Full ClientCMD Achived!\"");
            ConvarManager NameCvar = new ConvarManager("name");
            MessageBox.Show("0x" + NameCvar.pThis.ToString("X"));
            Clipboard.SetText("0x" + NameCvar.pThis.ToString("X"));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
