using System;
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
        int wood = SharedVars.wood;
        int stone = SharedVars.stone;
        int iron = SharedVars.iron;
        int gold = SharedVars.gold;
        int diamond = SharedVars.diamond;
        int emerald = SharedVars.emerald;
        static bool initialFormLoad = false;
        private void Form2_Load(object sender, EventArgs e)
        {
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
            if (wood >= 5)
            {
                wood -= 5;
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
            if (stone >= 5) { 
            stone -= 5;
            SharedVars.stonePickaxeUnlock = true;
            pbStonePickaxeUpgrade.Enabled = false;
            pbStonePickaxeUpgrade.Visible = false;
            lblStonePickaxeUpgrade.Visible = false;
            lblStonePickaxeCost.Visible = false; }
        }

        private void pbIronPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (iron >= 5)
            {
                iron -= 5;
                SharedVars.ironPickaxeUnlock = true;
                pbIronPickaxeUpgrade.Enabled = false;
                pbIronPickaxeUpgrade.Visible = false;
                lblIronPickaxeUpgrade.Visible = false;
                lblIronPickaxeCost.Visible = false;
            }
        }

        private void pbGoldPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (gold >= 5)
            {
                gold -= 5;
                SharedVars.goldPickaxeUnlock = true;
                pbGoldPickaxeUpgrade.Enabled = false;
                pbGoldPickaxeUpgrade.Visible = false;
                lblGoldPickaxeUpgrade.Visible = false;
                lblGoldPickaxeCost.Visible = false;
            }
        }

        private void pbDiamondPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            if (diamond >= 5)
            {
                diamond -= 5;
                SharedVars.diamondPickaxeUnlock = true;
                pbDiamondPickaxeUpgrade.Enabled = false;
                pbDiamondPickaxeUpgrade.Visible = false;
                lblDiamondPickaxeUpgrade.Visible = false;
                lblDiamondPickaxeCost.Visible = false;
            }
        }
    }
}
