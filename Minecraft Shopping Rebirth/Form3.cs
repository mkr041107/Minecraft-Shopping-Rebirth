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
        double woodChopperCalc = 0;
        double woodChopperPrice = 10;
        static bool initialFormLoad = false;

        private void pbWoodChopper_Click(object sender, EventArgs e)
        {
            if (woodChopperCalc >= SharedVars.wood)
            {
                SharedVars.wood -= woodChopperPrice;
                

                woodChopperCalc = SharedVars.wood += woodChopperCalc;
                woodChopperCalc *= 1.05;
                lblWoodChopperCost.Text = "Cost: " + woodChopperCalc;
                woodChopper += 1;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnMainGame_Click(object sender, EventArgs e)
        {
          
        }
    }
}
