using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace DotaMatchMaster
{
    partial class DotaMatchMasterForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pirateHatCooldownChk = new System.Windows.Forms.CheckBox();
            this.trustyShovelCooldownChk = new System.Windows.Forms.CheckBox();
            this.buybackCooldownChk = new System.Windows.Forms.CheckBox();
            this.wardPurchaseCooldownChk = new System.Windows.Forms.CheckBox();
            this.tormentorSpawnChk = new System.Windows.Forms.CheckBox();
            this.tokenAvailabilityChk = new System.Windows.Forms.CheckBox();
            this.wisdomRuneSpawnChk = new System.Windows.Forms.CheckBox();
            this.bountyRuneSpawnChk = new System.Windows.Forms.CheckBox();
            this.runeSpawnChk = new System.Windows.Forms.CheckBox();
            this.waterRuneSpawnChk = new System.Windows.Forms.CheckBox();
            this.midasCooldownChk = new System.Windows.Forms.CheckBox();
            this.doomDevourCooldownChk = new System.Windows.Forms.CheckBox();
            this.healingLotusSpawnChk = new System.Windows.Forms.CheckBox();
            this.campStackChk = new System.Windows.Forms.CheckBox();
            this.campPullChk = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.clearLogBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pirateHatCooldownChk);
            this.groupBox1.Controls.Add(this.trustyShovelCooldownChk);
            this.groupBox1.Controls.Add(this.buybackCooldownChk);
            this.groupBox1.Controls.Add(this.wardPurchaseCooldownChk);
            this.groupBox1.Controls.Add(this.tormentorSpawnChk);
            this.groupBox1.Controls.Add(this.tokenAvailabilityChk);
            this.groupBox1.Controls.Add(this.wisdomRuneSpawnChk);
            this.groupBox1.Controls.Add(this.bountyRuneSpawnChk);
            this.groupBox1.Controls.Add(this.runeSpawnChk);
            this.groupBox1.Controls.Add(this.waterRuneSpawnChk);
            this.groupBox1.Controls.Add(this.midasCooldownChk);
            this.groupBox1.Controls.Add(this.doomDevourCooldownChk);
            this.groupBox1.Controls.Add(this.healingLotusSpawnChk);
            this.groupBox1.Controls.Add(this.campStackChk);
            this.groupBox1.Controls.Add(this.campPullChk);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notifications";
            // 
            // pirateHatCooldownChk
            // 
            this.pirateHatCooldownChk.AutoSize = true;
            this.pirateHatCooldownChk.Location = new System.Drawing.Point(7, 348);
            this.pirateHatCooldownChk.Name = "pirateHatCooldownChk";
            this.pirateHatCooldownChk.Size = new System.Drawing.Size(123, 17);
            this.pirateHatCooldownChk.TabIndex = 14;
            this.pirateHatCooldownChk.Text = "Pirate Hat Cooldown";
            this.pirateHatCooldownChk.UseVisualStyleBackColor = true;
            this.pirateHatCooldownChk.CheckedChanged += new System.EventHandler(this.pirateHatCooldownChk_CheckedChanged);
            // 
            // trustyShovelCooldownChk
            // 
            this.trustyShovelCooldownChk.AutoSize = true;
            this.trustyShovelCooldownChk.Location = new System.Drawing.Point(6, 325);
            this.trustyShovelCooldownChk.Name = "trustyShovelCooldownChk";
            this.trustyShovelCooldownChk.Size = new System.Drawing.Size(141, 17);
            this.trustyShovelCooldownChk.TabIndex = 13;
            this.trustyShovelCooldownChk.Text = "Trusty Shovel Cooldown";
            this.trustyShovelCooldownChk.UseVisualStyleBackColor = true;
            this.trustyShovelCooldownChk.CheckedChanged += new System.EventHandler(this.trustyShovelCooldownChk_CheckedChanged);
            // 
            // buybackCooldownChk
            // 
            this.buybackCooldownChk.AutoSize = true;
            this.buybackCooldownChk.Location = new System.Drawing.Point(6, 302);
            this.buybackCooldownChk.Name = "buybackCooldownChk";
            this.buybackCooldownChk.Size = new System.Drawing.Size(118, 17);
            this.buybackCooldownChk.TabIndex = 12;
            this.buybackCooldownChk.Text = "Buyback Cooldown";
            this.buybackCooldownChk.UseVisualStyleBackColor = true;
            this.buybackCooldownChk.CheckedChanged += new System.EventHandler(this.buybackCooldownChk_CheckedChanged);
            // 
            // wardPurchaseCooldownChk
            // 
            this.wardPurchaseCooldownChk.AutoSize = true;
            this.wardPurchaseCooldownChk.Location = new System.Drawing.Point(6, 279);
            this.wardPurchaseCooldownChk.Name = "wardPurchaseCooldownChk";
            this.wardPurchaseCooldownChk.Size = new System.Drawing.Size(150, 17);
            this.wardPurchaseCooldownChk.TabIndex = 11;
            this.wardPurchaseCooldownChk.Text = "Ward Purchase Cooldown";
            this.wardPurchaseCooldownChk.UseVisualStyleBackColor = true;
            this.wardPurchaseCooldownChk.CheckedChanged += new System.EventHandler(this.wardPurchaseCooldownChk_CheckedChanged);
            // 
            // tormentorSpawnChk
            // 
            this.tormentorSpawnChk.AutoSize = true;
            this.tormentorSpawnChk.Location = new System.Drawing.Point(7, 255);
            this.tormentorSpawnChk.Name = "tormentorSpawnChk";
            this.tormentorSpawnChk.Size = new System.Drawing.Size(110, 17);
            this.tormentorSpawnChk.TabIndex = 10;
            this.tormentorSpawnChk.Text = "Tormentor Spawn";
            this.tormentorSpawnChk.UseVisualStyleBackColor = true;
            this.tormentorSpawnChk.CheckedChanged += new System.EventHandler(this.tormentorSpawnChk_CheckedChanged);
            // 
            // tokenAvailabilityChk
            // 
            this.tokenAvailabilityChk.AutoSize = true;
            this.tokenAvailabilityChk.Location = new System.Drawing.Point(7, 231);
            this.tokenAvailabilityChk.Name = "tokenAvailabilityChk";
            this.tokenAvailabilityChk.Size = new System.Drawing.Size(109, 17);
            this.tokenAvailabilityChk.TabIndex = 9;
            this.tokenAvailabilityChk.Text = "Token Availability";
            this.tokenAvailabilityChk.UseVisualStyleBackColor = true;
            this.tokenAvailabilityChk.CheckedChanged += new System.EventHandler(this.tokenAvailabilityChk_CheckedChanged);
            // 
            // wisdomRuneSpawnChk
            // 
            this.wisdomRuneSpawnChk.AutoSize = true;
            this.wisdomRuneSpawnChk.Location = new System.Drawing.Point(7, 207);
            this.wisdomRuneSpawnChk.Name = "wisdomRuneSpawnChk";
            this.wisdomRuneSpawnChk.Size = new System.Drawing.Size(129, 17);
            this.wisdomRuneSpawnChk.TabIndex = 8;
            this.wisdomRuneSpawnChk.Text = "Wisdom Rune Spawn";
            this.wisdomRuneSpawnChk.UseVisualStyleBackColor = true;
            this.wisdomRuneSpawnChk.CheckedChanged += new System.EventHandler(this.wisdomRuneSpawnChk_CheckedChanged);
            // 
            // bountyRuneSpawnChk
            // 
            this.bountyRuneSpawnChk.AutoSize = true;
            this.bountyRuneSpawnChk.Location = new System.Drawing.Point(7, 183);
            this.bountyRuneSpawnChk.Name = "bountyRuneSpawnChk";
            this.bountyRuneSpawnChk.Size = new System.Drawing.Size(124, 17);
            this.bountyRuneSpawnChk.TabIndex = 7;
            this.bountyRuneSpawnChk.Text = "Bounty Rune Spawn";
            this.bountyRuneSpawnChk.UseVisualStyleBackColor = true;
            this.bountyRuneSpawnChk.CheckedChanged += new System.EventHandler(this.bountyRuneSpawnChk_CheckedChanged);
            // 
            // runeSpawnChk
            // 
            this.runeSpawnChk.AutoSize = true;
            this.runeSpawnChk.Location = new System.Drawing.Point(7, 159);
            this.runeSpawnChk.Name = "runeSpawnChk";
            this.runeSpawnChk.Size = new System.Drawing.Size(88, 17);
            this.runeSpawnChk.TabIndex = 6;
            this.runeSpawnChk.Text = "Rune Spawn";
            this.runeSpawnChk.UseVisualStyleBackColor = true;
            this.runeSpawnChk.CheckedChanged += new System.EventHandler(this.runeSpawnChk_CheckedChanged);
            // 
            // waterRuneSpawnChk
            // 
            this.waterRuneSpawnChk.AutoSize = true;
            this.waterRuneSpawnChk.Location = new System.Drawing.Point(7, 135);
            this.waterRuneSpawnChk.Name = "waterRuneSpawnChk";
            this.waterRuneSpawnChk.Size = new System.Drawing.Size(120, 17);
            this.waterRuneSpawnChk.TabIndex = 5;
            this.waterRuneSpawnChk.Text = "Water Rune Spawn";
            this.waterRuneSpawnChk.UseVisualStyleBackColor = true;
            this.waterRuneSpawnChk.CheckedChanged += new System.EventHandler(this.waterRuneSpawnChk_CheckedChanged);
            // 
            // midasCooldownChk
            // 
            this.midasCooldownChk.AutoSize = true;
            this.midasCooldownChk.Location = new System.Drawing.Point(6, 111);
            this.midasCooldownChk.Name = "midasCooldownChk";
            this.midasCooldownChk.Size = new System.Drawing.Size(104, 17);
            this.midasCooldownChk.TabIndex = 4;
            this.midasCooldownChk.Text = "Midas Cooldown";
            this.midasCooldownChk.UseVisualStyleBackColor = true;
            this.midasCooldownChk.CheckedChanged += new System.EventHandler(this.midasCooldownChk_CheckedChanged);
            // 
            // doomDevourCooldownChk
            // 
            this.doomDevourCooldownChk.AutoSize = true;
            this.doomDevourCooldownChk.Location = new System.Drawing.Point(7, 64);
            this.doomDevourCooldownChk.Name = "doomDevourCooldownChk";
            this.doomDevourCooldownChk.Size = new System.Drawing.Size(142, 17);
            this.doomDevourCooldownChk.TabIndex = 3;
            this.doomDevourCooldownChk.Text = "Doom Devour Cooldown";
            this.doomDevourCooldownChk.UseVisualStyleBackColor = true;
            this.doomDevourCooldownChk.CheckedChanged += new System.EventHandler(this.doomDevourCooldownChk_CheckedChanged);
            // 
            // healingLotusSpawnChk
            // 
            this.healingLotusSpawnChk.AutoSize = true;
            this.healingLotusSpawnChk.Location = new System.Drawing.Point(6, 87);
            this.healingLotusSpawnChk.Name = "healingLotusSpawnChk";
            this.healingLotusSpawnChk.Size = new System.Drawing.Size(127, 17);
            this.healingLotusSpawnChk.TabIndex = 2;
            this.healingLotusSpawnChk.Text = "Healing Lotus Spawn";
            this.healingLotusSpawnChk.UseVisualStyleBackColor = true;
            this.healingLotusSpawnChk.CheckedChanged += new System.EventHandler(this.healingLotusSpawnChk_CheckedChanged);
            // 
            // campStackChk
            // 
            this.campStackChk.AutoSize = true;
            this.campStackChk.Location = new System.Drawing.Point(7, 44);
            this.campStackChk.Name = "campStackChk";
            this.campStackChk.Size = new System.Drawing.Size(84, 17);
            this.campStackChk.TabIndex = 1;
            this.campStackChk.Text = "Camp Stack";
            this.campStackChk.UseVisualStyleBackColor = true;
            this.campStackChk.CheckedChanged += new System.EventHandler(this.campStackChk_CheckedChanged);
            // 
            // campPullChk
            // 
            this.campPullChk.AutoSize = true;
            this.campPullChk.Location = new System.Drawing.Point(7, 20);
            this.campPullChk.Name = "campPullChk";
            this.campPullChk.Size = new System.Drawing.Size(73, 17);
            this.campPullChk.TabIndex = 0;
            this.campPullChk.Text = "Camp Pull";
            this.campPullChk.UseVisualStyleBackColor = true;
            this.campPullChk.CheckedChanged += new System.EventHandler(this.campPullChk_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTxt);
            this.groupBox2.Location = new System.Drawing.Point(195, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 369);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // logTxt
            // 
            this.logTxt.BackColor = System.Drawing.SystemColors.Window;
            this.logTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTxt.Location = new System.Drawing.Point(6, 20);
            this.logTxt.Multiline = true;
            this.logTxt.Name = "logTxt";
            this.logTxt.ReadOnly = true;
            this.logTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTxt.Size = new System.Drawing.Size(463, 343);
            this.logTxt.TabIndex = 0;
            // 
            // clearLogBtn
            // 
            this.clearLogBtn.Location = new System.Drawing.Point(595, 388);
            this.clearLogBtn.Name = "clearLogBtn";
            this.clearLogBtn.Size = new System.Drawing.Size(75, 23);
            this.clearLogBtn.TabIndex = 14;
            this.clearLogBtn.Text = "Clear Log";
            this.clearLogBtn.UseVisualStyleBackColor = true;
            this.clearLogBtn.Click += new System.EventHandler(this.clearLogBtn_Click);
            // 
            // DotaMatchMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 416);
            this.Controls.Add(this.clearLogBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DotaMatchMasterForm";
            this.Text = "Dota Match Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void Log(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), new object[] { message });
                return;
            }
            this.logTxt.AppendText(message + Environment.NewLine);
        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox campStackChk;
        private System.Windows.Forms.CheckBox campPullChk;
        private System.Windows.Forms.CheckBox doomDevourCooldownChk;
        private System.Windows.Forms.CheckBox healingLotusSpawnChk;
        private System.Windows.Forms.CheckBox runeSpawnChk;
        private System.Windows.Forms.CheckBox waterRuneSpawnChk;
        private System.Windows.Forms.CheckBox midasCooldownChk;
        private System.Windows.Forms.CheckBox tokenAvailabilityChk;
        private System.Windows.Forms.CheckBox wisdomRuneSpawnChk;
        private System.Windows.Forms.CheckBox bountyRuneSpawnChk;
        private System.Windows.Forms.CheckBox wardPurchaseCooldownChk;
        private System.Windows.Forms.CheckBox tormentorSpawnChk;
        private System.Windows.Forms.CheckBox buybackCooldownChk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.CheckBox pirateHatCooldownChk;
        private System.Windows.Forms.CheckBox trustyShovelCooldownChk;
        private System.Windows.Forms.Button clearLogBtn;
    }
}

