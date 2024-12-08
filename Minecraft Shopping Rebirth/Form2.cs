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
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pbWoodenPickaxeUpgrade_Click(object sender, EventArgs e)
        {
            wood -= 5;
            SharedVars.woodenPickaxeUnlock = true;
            pbWoodenPickaxeUpgrade.Enabled = false;
            pbWoodenPickaxeUpgrade.Visible = false;
            lblWoodenPickaxeUpgrade.Visible = false;
            lblWoodenPickaxeUpgradeCost.Visible = false;
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
