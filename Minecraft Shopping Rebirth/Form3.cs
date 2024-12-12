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
       
        int woodChopper = SharedVars.woodChoppers;
        int stoneMine = SharedVars.stoneMine;
        int ironMine = SharedVars.ironMine;
        int goldMine = SharedVars.goldMine;
        int diamondMine = SharedVars.diamondMine;
        int emeraldMine = SharedVars.emeraldMine;
        static double woodChopperCalc = 10;
        double woodChopperPrice = 10;
        static bool initialFormLoad = false;
        static double woodChopperCalcRound = 0;
        static double woodRounded = 0;
     

        private void pbWoodChopper_Click(object sender, EventArgs e)
        {
           
            if (woodChopperCalcRound <= SharedVars.wood)
            {
                woodChopperPrice = woodChopperCalcRound;
                SharedVars.wood -= woodChopperPrice;
                woodChopperCalcRound = Math.Round(woodChopperCalc, 0);
                woodRounded = Math.Round(SharedVars.wood, 0);

                woodChopperCalc = SharedVars.wood += woodChopperCalc;
                woodChopperCalc *= 1.1;
                lblWoodChopperCost.Text = "Cost: " + woodChopperCalcRound;
                SharedVars.woodChoppers += 1;

                SharedVars.wood = woodRounded;
               
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblWoodChopperCost.Text = "Cost: " + woodChopperCalcRound;
        }

        private void btnMainGame_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            this.Hide();
            Main.ShowDialog();

            this.Close();
        }
    }
}
