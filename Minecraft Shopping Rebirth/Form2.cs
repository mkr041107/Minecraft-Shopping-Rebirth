﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Shopping_Rebirth
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        static bool initialFormLoad = false;
        static bool pickaxeTutoiralCompleted  = false;
        private void Form2_Load(object sender, EventArgs e)
        {
            if (pickaxeTutoiralCompleted == true)
            {

            }
            if (initialFormLoad == false||SharedVars.woodenPickaxeUnlock == false)
            {

                pbWoodenPickaxeUpgrade.Visible = true;
                lblWoodenPickaxeUpgrade.Visible = true;
                lblWoodenPickaxeUpgradeCost.Visible = true;
                initialFormLoad = true;

            }
            if (initialFormLoad == false || SharedVars.stonePickaxeUnlock == false)
            {
                pbStonePickaxeUpgrade.Visible = true;
                lblStonePickaxeUpgrade.Visible = true;
                lblStonePickaxeCost.Visible = true;
                initialFormLoad = true;
            }
            if (initialFormLoad == false || SharedVars.ironPickaxeUnlock == false)
            {
                pbIronPickaxeUpgrade.Visible = true;
                lblIronPickaxeUpgrade.Visible = true;
                lblIronPickaxeCost.Visible = true;
                initialFormLoad = true;
            }
            if (initialFormLoad == false || SharedVars.goldPickaxeUnlock == false)
            {
                pbGoldPickaxeUpgrade.Visible = true;
                lblGoldPickaxeUpgrade.Visible = true;
                lblGoldPickaxeCost.Visible = true;
                initialFormLoad = true;
            }
            if (initialFormLoad == false || SharedVars.diamondPickaxeUnlock == false)
            {
                pbDiamondPickaxeUpgrade.Visible = true;
                lblDiamondPickaxeUpgrade.Visible = true;
                lblDiamondPickaxeCost.Visible = true;
                initialFormLoad = true;
            }


        }

        private void pbWoodenPickaxeUpgrade_Click(object sender, EventArgs e)
        {
           
            if (SharedVars.wood >= 5)
            {
                lblTutorialStone.Visible = false;
                SharedVars.wood -= 5;
                SharedVars.woodenPickaxeUnlock = true;
                pbWoodenPickaxeUpgrade.Enabled = false;
                pbWoodenPickaxeUpgrade.Visible = false;
                lblWoodenPickaxeUpgrade.Visible = false;
                lblWoodenPickaxeUpgradeCost.Visible = false;
            }
        }

        private void btnMainGame_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            this.Hide();
            Main.ShowDialog();

            this.Close();
        }

        private void pbStonePickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (SharedVars.stone >= 5) { 
            SharedVars.stone -= 5;
            SharedVars.stonePickaxeUnlock = true;
            pbStonePickaxeUpgrade.Enabled = false;
            pbStonePickaxeUpgrade.Visible = false;
            lblStonePickaxeUpgrade.Visible = false;
            lblStonePickaxeCost.Visible = false; }
        }

        private void pbIronPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (SharedVars.iron >= 5)
            {
                SharedVars.iron -= 5;
                SharedVars.ironPickaxeUnlock = true;
                pbIronPickaxeUpgrade.Enabled = false;
                pbIronPickaxeUpgrade.Visible = false;
                lblIronPickaxeUpgrade.Visible = false;
                lblIronPickaxeCost.Visible = false;
            }
        }

        private void pbGoldPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (SharedVars.gold >= 5)
            {
                SharedVars.gold -= 5;
                SharedVars.goldPickaxeUnlock = true;
                pbGoldPickaxeUpgrade.Enabled = false;
                pbGoldPickaxeUpgrade.Visible = false;
                lblGoldPickaxeUpgrade.Visible = false;
                lblGoldPickaxeCost.Visible = false;
            }
        }

        private void pbDiamondPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (SharedVars.diamond >= 5)
            {
                SharedVars.diamond -= 5;
                SharedVars.diamondPickaxeUnlock = true;
                pbDiamondPickaxeUpgrade.Enabled = false;
                pbDiamondPickaxeUpgrade.Visible = false;
                lblDiamondPickaxeUpgrade.Visible = false;
                lblDiamondPickaxeCost.Visible = false;
            }
        }
    }
}
