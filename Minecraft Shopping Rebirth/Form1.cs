﻿using System;
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
        int wood = 0;
        int stone = 0;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpgrades_Click(object sender, EventArgs e)
        {

            SharedVars.wood = wood;
            Form2 Upgrades = new Form2();
            this.Hide();
            Upgrades.ShowDialog();
            
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true; // Enable double buffering
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
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
                Player.Top -= 2;
            }
            if (down == true)
            {
                Player.Top += 2;
            }
            if (left == true)
            {
                Player.Left -= 2;
            }
            if (right == true)
            {
                Player.Left += 2;
            }
            if (Player.Bounds.IntersectsWith(pbWood.Bounds))
            {
                wood += 1;
                lblOakTotal.Text = "Total: " + wood;
                Player.Location = new Point(12, 258);
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
        }

        private void pbWood_Click(object sender, EventArgs e)
        {

        }
    }
}
