using DotaMatchMaster;
using DotaMatchMaster.Observer;
using System;
using System.Windows.Forms;

namespace DotaMatchMaster
{
    public partial class DotaMatchMasterForm : Form
    {
        private Observer.BountyRuneSpawn _bountyRuneSpawn = new Observer.BountyRuneSpawn();
        private Observer.BuybackCooldown _buybackCooldown = new Observer.BuybackCooldown();
        private Observer.CampPull _campPull = new Observer.CampPull();
        private Observer.CampStack _campStack = new Observer.CampStack();
        private Observer.DoomDevourCooldown _doomDevourCooldown = new Observer.DoomDevourCooldown();
        private Observer.HealingLotusSpawn _healingLotusSpawn = new Observer.HealingLotusSpawn();
        private Observer.MidasCooldown _midasCooldown = new Observer.MidasCooldown();
        private Observer.PirateHatCooldown _pirateHatCooldown = new Observer.PirateHatCooldown();
        private Observer.RuneSpawn _runeSpawn = new Observer.RuneSpawn();
        private Observer.TokenAvailability _tokenAvailability = new Observer.TokenAvailability();
        private Observer.TormentorSpawn _tormentorSpawn = new Observer.TormentorSpawn();
        private Observer.TrustyShovelCooldown _trustyShovelCooldown = new Observer.TrustyShovelCooldown();
        private Observer.WardPurchaseCooldown _wardPurchaseCooldown = new Observer.WardPurchaseCooldown();
        private Observer.WaterRuneSpawn _waterRuneSpawn = new Observer.WaterRuneSpawn();
        private Observer.WisdomRuneSpawn _wisdomRuneSpawn = new Observer.WisdomRuneSpawn();

        public DotaMatchMasterForm()
        {
            InitializeComponent();

            this.bountyRuneSpawnChk.Checked = Properties.Settings.Default.BountyRuneSpawnChecked;
            this.buybackCooldownChk.Checked = Properties.Settings.Default.BuybackCooldownChecked;
            this.campPullChk.Checked = Properties.Settings.Default.CampPullChecked;
            this.campStackChk.Checked = Properties.Settings.Default.CampStackChecked;
            this.doomDevourCooldownChk.Checked = Properties.Settings.Default.DoomDevourCooldownChecked;
            this.healingLotusSpawnChk.Checked = Properties.Settings.Default.HealingLotusSpawnChecked;
            this.midasCooldownChk.Checked = Properties.Settings.Default.MidasCooldownChecked;
            this.pirateHatCooldownChk.Checked = Properties.Settings.Default.PirateHatCooldownChecked;
            this.runeSpawnChk.Checked = Properties.Settings.Default.RuneSpawnChecked;
            this.tokenAvailabilityChk.Checked = Properties.Settings.Default.TokenAvailabilityChecked;
            this.tormentorSpawnChk.Checked = Properties.Settings.Default.TormentorSpawnChecked;
            this.trustyShovelCooldownChk.Checked = Properties.Settings.Default.TrustyShovelCooldownChecked;
            this.wardPurchaseCooldownChk.Checked = Properties.Settings.Default.WardPurchaseCooldownChecked;
            this.waterRuneSpawnChk.Checked = Properties.Settings.Default.WaterRuneSpawnChecked;
            this.wisdomRuneSpawnChk.Checked = Properties.Settings.Default.WisdomRuneSpawnChecked;
        }

        private void CheckedChanged(object sender, Observer.IObserver observer, string setting)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                GameManager.GetInstance().RegisterObserver(observer);
            }
            else
            {
                GameManager.GetInstance().UnregisterObserver(observer);
            }

            Properties.Settings.Default.GetType().GetProperty(setting).SetValue(Properties.Settings.Default, checkBox.Checked);
            Properties.Settings.Default.Save();
        }
        private void bountyRuneSpawnChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _bountyRuneSpawn, "BountyRuneSpawnChecked");
        }

        private void campPullChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _campPull, "CampPullChecked");
        }

        private void campStackChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _campStack, "CampStackChecked");
        }

        private void doomDevourCooldownChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _doomDevourCooldown, "DoomDevourCooldownChecked");
        }

        private void healingLotusSpawnChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _healingLotusSpawn, "HealingLotusSpawnChecked");
        }

        private void midasCooldownChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _midasCooldown, "MidasCooldownChecked");
        }

        private void runeSpawnChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _runeSpawn, "RuneSpawnChecked");
        }

        private void tokenAvailabilityChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _tokenAvailability, "TokenAvailabilityChecked");
        }

        private void tormentorSpawnChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _tormentorSpawn, "TormentorSpawnChecked");
        }

        private void wardPurchaseCooldownChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _wardPurchaseCooldown, "WardPurchaseCooldownChecked");
        }

        private void waterRuneSpawnChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _waterRuneSpawn, "WaterRuneSpawnChecked");
        }

        private void wisdomRuneSpawnChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _wisdomRuneSpawn, "WisdomRuneSpawnChecked");
        }

        private void buybackCooldownChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _buybackCooldown, "BuybackCooldownChecked");
        }

        private void trustyShovelCooldownChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _trustyShovelCooldown, "TrustyShovelCooldownChecked");
        }

        private void pirateHatCooldownChk_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckedChanged(sender, _pirateHatCooldown, "PirateHatCooldownChecked");
        }

        private void clearLogBtn_Click(object sender, System.EventArgs e)
        {
            this.logTxt.Clear();
        }
    }
}
