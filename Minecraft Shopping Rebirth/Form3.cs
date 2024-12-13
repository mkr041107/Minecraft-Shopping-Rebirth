using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Shopping_Rebirth
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static bool initialFormLoad = true;
        int woodChopper = SharedVars.woodChoppers;
        int stoneMine = SharedVars.stoneMine;
        int ironMine = SharedVars.ironMine;
        int goldMine = SharedVars.goldMine;
        int diamondMine = SharedVars.diamondMine;
        int emeraldMine = SharedVars.emeraldMine;
        static double woodChopperCalc = 10;
        static double woodChopperPrice = 10;
        static double woodChopperCalcRound = 0;
        static double woodRounded = 0;
        int cooldownWood = 0;
        int cooldownStone = 0;
        int cooldownIron = 0;
        int cooldownGold = 0;
        int cooldownDiamond = 0;
        int cooldownEmerald = 0;
        static double stoneMineCalc = 10;
        static double stoneMinePrice = 10;
        static double stoneMineCalcRound = 0;
        static double stoneRounded = 0;
        static double ironMineCalc = 10;
        static double ironMinePrice = 10;
        static double ironMineCalcRound = 0;
        static double ironRounded = 0;
        static double goldMineCalc = 10;
        static double goldMinePrice = 10;
        static double goldMineCalcRound = 0;
        static double goldRounded = 0;
        static double diamondMineCalc = 10;
        static double diamondMinePrice = 10;
        static double diamondMineCalcRound = 0;
        static double diamondRounded = 0;
        static double emeraldMineCalc = 10;
        static double emeraldMinePrice = 10;
        static double emeraldMineCalcRound = 0;
        static double emeraldRounded = 0;



        private void pbWoodChopper_Click(object sender, EventArgs e)
        {
           
            if (woodChopperCalcRound <= SharedVars.wood && cooldownWood <= 0)
            {
               
                SharedVars.wood -= woodChopperCalcRound;
               
                woodChopperCalc *= 1.1;
                woodChopperCalc = woodChopperPrice+ woodChopperCalc;
                woodChopperCalcRound = Math.Round(woodChopperCalc, 0);
                woodRounded = Math.Round(SharedVars.wood, 0);
                lblWoodChopperCost.Text = "Cost: " + woodChopperCalcRound;

                SharedVars.woodChoppers += 1;

                SharedVars.wood = woodRounded;
                cooldownWood = 2;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (initialFormLoad == true)
            {
                lblWoodChopperCost.Text = "Cost: " + woodChopperPrice;
                initialFormLoad = false;
            }else
            {

                lblWoodChopperCost.Text = "Cost: " + woodChopperCalcRound;
            }
        }

        private void btnMainGame_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            this.Hide();
            Main.ShowDialog();

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cooldownWood -= 1;
            cooldownStone -= 1;
            cooldownIron -= 1;
            cooldownGold  -= 1;
            cooldownDiamond -= 1;
            cooldownEmerald -= 1;
            lblWoodChopperCost.Text = "Cost: " + woodChopperCalcRound;
        }

        private void pbStoneMine_Click(object sender, EventArgs e)
        {
            if (stoneMineCalcRound <= SharedVars.stone && cooldownStone <= 0)
            {

                SharedVars.stone -= stoneMineCalcRound;

                stoneMineCalc *= 1.1;
                stoneMineCalc = stoneMinePrice + stoneMineCalc;
               stoneMineCalcRound = Math.Round(stoneMineCalc, 0);
                stoneRounded = Math.Round(SharedVars.stone, 0);

                SharedVars.stoneMine += 1;

                SharedVars.stone = stoneRounded;
                cooldownStone = 2;
            }
        }

        private void pbIronMine_Click(object sender, EventArgs e)
        {
            if (ironMineCalcRound <= SharedVars.iron && cooldownIron <= 0)
            {

                SharedVars.iron -= ironMineCalcRound;

                ironMineCalc *= 1.1;
                ironMineCalc = ironMinePrice + ironMineCalc;
                ironMineCalcRound = Math.Round(ironMineCalc, 0);
                ironRounded = Math.Round(SharedVars.iron, 0);

                SharedVars.ironMine += 1;

                SharedVars.iron = ironRounded;
                cooldownIron = 2;
            }
        }

        private void pbGoldMine_Click(object sender, EventArgs e)
        {
            if (goldMineCalcRound <= SharedVars.gold && cooldownGold <= 0)
            {

                SharedVars.gold -= goldMineCalcRound;

                goldMineCalc *= 1.1;
                goldMineCalc = goldMinePrice + goldMineCalc;
                goldMineCalcRound = Math.Round(goldMineCalc, 0);
                goldRounded = Math.Round(SharedVars.gold, 0);

                SharedVars.goldMine += 1;

                SharedVars.gold = goldRounded;
                cooldownGold = 2;
            }
        }

        private void pbDiamondMine_Click(object sender, EventArgs e)
        {
            if (diamondMineCalcRound <= SharedVars.diamond && cooldownDiamond <= 0)
            {

                SharedVars.diamond -= diamondMineCalcRound;

                diamondMineCalc *= 1.1;
                diamondMineCalc = diamondMinePrice + diamondMineCalc;
                diamondMineCalcRound = Math.Round(diamondMineCalc, 0);
                diamondRounded = Math.Round(SharedVars.diamond, 0);

                SharedVars.diamondMine += 1;

                SharedVars.diamond = diamondRounded;
                cooldownDiamond = 2;
            }
        }

        private void pbEmeraldMine_Click(object sender, EventArgs e)
        {
            if (emeraldMineCalcRound <= SharedVars.emerald && cooldownEmerald <= 0)
            {

                SharedVars.emerald -= emeraldMineCalcRound;

                emeraldMineCalc *= 1.1;
                emeraldMineCalc = emeraldMinePrice + emeraldMineCalc;
                emeraldMineCalcRound = Math.Round(emeraldMineCalc, 0);
                emeraldRounded = Math.Round(SharedVars.emerald, 0);

                SharedVars.emeraldMine += 1;

                SharedVars.emerald = emeraldRounded;
                cooldownEmerald = 2;
            }
        }
    }
}
