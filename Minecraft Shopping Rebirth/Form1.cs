using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Shopping_Rebirth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool up = false;
        bool left = false;
        bool right = false;
        bool down = false;
        double wood = 0;
        double stone = 0;
        double iron = 0;
        double gold = 0;
        double diamond = 0;
        double emerald = 0;
        int speed = 2;
        int woodChopper = SharedVars.woodChoppers;
        int stoneMine = SharedVars.stoneMine;
        int ironMine = SharedVars.ironMine;
        int goldMine = SharedVars.goldMine;
        int diamondMine = SharedVars.diamondMine;
        int emeraldMine = SharedVars.emeraldMine;
        static bool Tutorial1Completed = false;
        static bool Tutorial2Completed = false;
        static bool onlyTutorial1Completed = false;
        static bool onlyTutorial2Completed = false;
        static bool tutorial3Completed= false;
        static bool onlyTutorial3Completed = false;
        static bool TutorialBuildings = false;
        static bool onlyTutorial4Completed = false;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpgrades_Click(object sender, EventArgs e)
        {
            lblTutorialGetStone.Visible = false;
            
            SharedVars.wood = wood;
            SharedVars.stone = stone;
            SharedVars.iron = iron;
            SharedVars.gold = gold;
            SharedVars.diamond = diamond;
            SharedVars.emerald = emerald;
            Form2 Upgrades = new Form2();
            this.Hide();
            onlyTutorial3Completed = true;
            Upgrades.ShowDialog();
            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Tutorial1Completed == true)
            {
                lblTutorialWASD.Visible = false;

            }
            if (Tutorial2Completed == true)
            {

        lblTutorialGather.Visible = false;
            }
            if (onlyTutorial3Completed == true&&onlyTutorial4Completed == false)
            {
                lblTutorialBuildings.Visible = true;
            }
            


            this.DoubleBuffered = true;
             wood= SharedVars.wood ;
             stone = SharedVars.stone;
             iron= SharedVars.iron;
            gold= SharedVars.gold;
            diamond= SharedVars.diamond;
            lblOakTotal.Text = "Total: " + wood;
            lblTotalStone.Text = "Total: " + stone;
            lblIronTotal.Text = "Total: " + iron;
            lblGoldTotal.Text = "Total: " + gold;
            lblDiamondTotal.Text = "Total: " + diamond;
            lblEmeraldTotal.Text = "Total: " + emerald;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
                lblTutorialWASD.Visible = false;
                Tutorial1Completed = true;
                if (Tutorial1Completed == true && onlyTutorial1Completed == false)
                {
                    lblTutorialGather.Visible = true;
                    onlyTutorial1Completed = true;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
               
            }
           
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            if (up == true)
            {
                Player.Top -= speed;
            }
            if (down == true)
            {
                Player.Top += speed;
            }
            if (left == true)
            {
                Player.Left -= speed;
            }
            if (right == true)
            {
                Player.Left += speed;
            }
            if (Player.Bounds.IntersectsWith(pbWood.Bounds))
            {
                wood += 1;
                lblOakTotal.Text = "Total: " + wood;
                Player.Location = new Point(12, 258);
                lblTutorialGather.Visible = false;
             
                Tutorial2Completed = true;
                if(Tutorial2Completed==true && onlyTutorial2Completed == false)
                {
                    lblTutorialGetStone.Visible = true;
                    onlyTutorial2Completed = true;
                }
            }
            if (SharedVars.woodenPickaxeUnlock == true)
            {
                lblStone.Visible = true;
                lblTotalStone.Visible = true;
                pbStone.Visible = true;
                if (Player.Bounds.IntersectsWith(pbStone.Bounds))
                {
                    stone += 1;
                    lblTotalStone.Text = "Total: " + stone;
                    Player.Location = new Point(12, 258);
                }
            }
           
            
            if (SharedVars.stonePickaxeUnlock == true)
            {
                lblIron.Visible = true;
                lblIronTotal.Visible = true;
                pbIronOre.Visible = true;
                if (Player.Bounds.IntersectsWith(pbIronOre.Bounds))
                {
                    iron += 1;
                    lblIronTotal.Text = "Total: " + iron;
                    Player.Location = new Point(12, 258);
                }
            }

            if (SharedVars.ironPickaxeUnlock == true)
            {
                lblGold.Visible = true;
                lblGoldTotal.Visible = true;
                pbGoldOre.Visible = true;
                if (Player.Bounds.IntersectsWith(pbGoldOre.Bounds))
                {
                    gold += 1;
                    lblGoldTotal.Text = "Total: " + gold;
                    Player.Location = new Point(12, 258);
                }
            }
            if (SharedVars.goldPickaxeUnlock == true)
            {
                lblDiamond.Visible = true;
                lblDiamondTotal.Visible = true;
                pbDiamondOre.Visible = true;
                if (Player.Bounds.IntersectsWith(pbDiamondOre.Bounds))
                {
                    diamond += 1;
                    lblDiamondTotal.Text = "Total: " + diamond;
                    Player.Location = new Point(12, 258);
                }
            }
            if (SharedVars.diamondPickaxeUnlock == true)
            {
                lblEmerald.Visible = true;
                lblEmeraldTotal.Visible = true;
                pbEmeraldOre.Visible = true;
                if (Player.Bounds.IntersectsWith(pbEmeraldOre.Bounds))
                {
                    emerald += 1;
                    lblEmeraldTotal.Text = "Total: " + emerald;
                    Player.Location = new Point(12, 258);
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.A)
            {
                 left= false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if(e.KeyCode == Keys.NumPad8)
            {

                speed += 2;
            }
            if (e.KeyCode == Keys.NumPad5)

            {
                speed -= 2;

            }
        }

        private void pbWood_Click(object sender, EventArgs e)
        {

        }

        private void tmrBuildings_Tick(object sender, EventArgs e)
        {
            wood += SharedVars.woodChoppers;
            lblOakTotal.Text = "Total: "+wood;
            stone += SharedVars.stoneMine;
            lblTotalStone.Text = "Total: " + stone;
            iron += SharedVars.ironMine;
            lblIronTotal.Text = "Total: " + iron;
            gold += SharedVars.goldMine ;
            lblGoldTotal.Text = "Total: " + gold;
            diamond += SharedVars.diamondMine;
            lblDiamondTotal.Text = "Total: " + diamond;
            emerald += SharedVars.emeraldMine;
            lblEmeraldTotal.Text = "Total: " + emerald;
        }

        private void btnBuildings_Click(object sender, EventArgs e)
        {
            SharedVars.wood = wood;
            SharedVars.stone = stone;
            SharedVars.iron = iron;
            SharedVars.gold = gold;
            SharedVars.diamond = diamond;
            SharedVars.emerald = emerald;
            Form3 Buildings = new Form3();
            this.Hide();
            onlyTutorial4Completed = true;
            Buildings.ShowDialog();

            this.Close();
        }
    }
}
