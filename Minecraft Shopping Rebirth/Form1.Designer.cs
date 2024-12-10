namespace Minecraft_Shopping_Rebirth
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbWood = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pbStone = new System.Windows.Forms.PictureBox();
            this.pbIronOre = new System.Windows.Forms.PictureBox();
            this.pbGoldOre = new System.Windows.Forms.PictureBox();
            this.pbDiamondOre = new System.Windows.Forms.PictureBox();
            this.pbEmeraldOre = new System.Windows.Forms.PictureBox();
            this.btnUpgrades = new System.Windows.Forms.Button();
            this.btnBuildings = new System.Windows.Forms.Button();
            this.lblStone = new System.Windows.Forms.Label();
            this.lblTotalStone = new System.Windows.Forms.Label();
            this.lblIronTotal = new System.Windows.Forms.Label();
            this.lblIron = new System.Windows.Forms.Label();
            this.lblGoldTotal = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblDiamondTotal = new System.Windows.Forms.Label();
            this.lblDiamond = new System.Windows.Forms.Label();
            this.lblEmeraldTotal = new System.Windows.Forms.Label();
            this.lblEmerald = new System.Windows.Forms.Label();
            this.lblOakTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIronOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoldOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamondOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmeraldOre)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWood
            // 
            this.pbWood.Image = ((System.Drawing.Image)(resources.GetObject("pbWood.Image")));
            this.pbWood.Location = new System.Drawing.Point(34, 66);
            this.pbWood.Name = "pbWood";
            this.pbWood.Size = new System.Drawing.Size(44, 50);
            this.pbWood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWood.TabIndex = 0;
            this.pbWood.TabStop = false;
            this.pbWood.Click += new System.EventHandler(this.pbWood_Click);
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(12, 258);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 127);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbStone
            // 
            this.pbStone.Image = ((System.Drawing.Image)(resources.GetObject("pbStone.Image")));
            this.pbStone.Location = new System.Drawing.Point(169, 66);
            this.pbStone.Name = "pbStone";
            this.pbStone.Size = new System.Drawing.Size(45, 50);
            this.pbStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStone.TabIndex = 2;
            this.pbStone.TabStop = false;
            this.pbStone.Visible = false;
            // 
            // pbIronOre
            // 
            this.pbIronOre.Image = ((System.Drawing.Image)(resources.GetObject("pbIronOre.Image")));
            this.pbIronOre.Location = new System.Drawing.Point(288, 66);
            this.pbIronOre.Name = "pbIronOre";
            this.pbIronOre.Size = new System.Drawing.Size(48, 50);
            this.pbIronOre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIronOre.TabIndex = 3;
            this.pbIronOre.TabStop = false;
            this.pbIronOre.Visible = false;
            // 
            // pbGoldOre
            // 
            this.pbGoldOre.Image = ((System.Drawing.Image)(resources.GetObject("pbGoldOre.Image")));
            this.pbGoldOre.Location = new System.Drawing.Point(404, 66);
            this.pbGoldOre.Name = "pbGoldOre";
            this.pbGoldOre.Size = new System.Drawing.Size(50, 50);
            this.pbGoldOre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGoldOre.TabIndex = 5;
            this.pbGoldOre.TabStop = false;
            this.pbGoldOre.Visible = false;
            // 
            // pbDiamondOre
            // 
            this.pbDiamondOre.Image = ((System.Drawing.Image)(resources.GetObject("pbDiamondOre.Image")));
            this.pbDiamondOre.Location = new System.Drawing.Point(535, 66);
            this.pbDiamondOre.Name = "pbDiamondOre";
            this.pbDiamondOre.Size = new System.Drawing.Size(50, 50);
            this.pbDiamondOre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiamondOre.TabIndex = 6;
            this.pbDiamondOre.TabStop = false;
            this.pbDiamondOre.Visible = false;
            // 
            // pbEmeraldOre
            // 
            this.pbEmeraldOre.Image = ((System.Drawing.Image)(resources.GetObject("pbEmeraldOre.Image")));
            this.pbEmeraldOre.Location = new System.Drawing.Point(673, 66);
            this.pbEmeraldOre.Name = "pbEmeraldOre";
            this.pbEmeraldOre.Size = new System.Drawing.Size(50, 50);
            this.pbEmeraldOre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmeraldOre.TabIndex = 7;
            this.pbEmeraldOre.TabStop = false;
            this.pbEmeraldOre.Visible = false;
            // 
            // btnUpgrades
            // 
            this.btnUpgrades.Location = new System.Drawing.Point(1022, 407);
            this.btnUpgrades.Name = "btnUpgrades";
            this.btnUpgrades.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrades.TabIndex = 8;
            this.btnUpgrades.Text = "Upgrades";
            this.btnUpgrades.UseVisualStyleBackColor = true;
            this.btnUpgrades.Click += new System.EventHandler(this.btnUpgrades_Click);
            // 
            // btnBuildings
            // 
            this.btnBuildings.Location = new System.Drawing.Point(1121, 407);
            this.btnBuildings.Name = "btnBuildings";
            this.btnBuildings.Size = new System.Drawing.Size(75, 23);
            this.btnBuildings.TabIndex = 9;
            this.btnBuildings.Text = "Buildings";
            this.btnBuildings.UseVisualStyleBackColor = true;
            // 
            // lblStone
            // 
            this.lblStone.AutoSize = true;
            this.lblStone.Location = new System.Drawing.Point(177, 9);
            this.lblStone.Name = "lblStone";
            this.lblStone.Size = new System.Drawing.Size(35, 13);
            this.lblStone.TabIndex = 10;
            this.lblStone.Text = "Stone";
            this.lblStone.Visible = false;
            // 
            // lblTotalStone
            // 
            this.lblTotalStone.AutoSize = true;
            this.lblTotalStone.Location = new System.Drawing.Point(177, 35);
            this.lblTotalStone.Name = "lblTotalStone";
            this.lblTotalStone.Size = new System.Drawing.Size(37, 13);
            this.lblTotalStone.TabIndex = 11;
            this.lblTotalStone.Text = "Total: ";
            this.lblTotalStone.Visible = false;
            // 
            // lblIronTotal
            // 
            this.lblIronTotal.AutoSize = true;
            this.lblIronTotal.Location = new System.Drawing.Point(299, 35);
            this.lblIronTotal.Name = "lblIronTotal";
            this.lblIronTotal.Size = new System.Drawing.Size(37, 13);
            this.lblIronTotal.TabIndex = 15;
            this.lblIronTotal.Text = "Total: ";
            this.lblIronTotal.Visible = false;
            // 
            // lblIron
            // 
            this.lblIron.AutoSize = true;
            this.lblIron.Location = new System.Drawing.Point(299, 9);
            this.lblIron.Name = "lblIron";
            this.lblIron.Size = new System.Drawing.Size(25, 13);
            this.lblIron.TabIndex = 14;
            this.lblIron.Text = "Iron";
            this.lblIron.Visible = false;
            // 
            // lblGoldTotal
            // 
            this.lblGoldTotal.AutoSize = true;
            this.lblGoldTotal.Location = new System.Drawing.Point(417, 38);
            this.lblGoldTotal.Name = "lblGoldTotal";
            this.lblGoldTotal.Size = new System.Drawing.Size(37, 13);
            this.lblGoldTotal.TabIndex = 17;
            this.lblGoldTotal.Text = "Total: ";
            this.lblGoldTotal.Visible = false;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(417, 12);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(29, 13);
            this.lblGold.TabIndex = 16;
            this.lblGold.Text = "Gold";
            this.lblGold.Visible = false;
            // 
            // lblDiamondTotal
            // 
            this.lblDiamondTotal.AutoSize = true;
            this.lblDiamondTotal.Location = new System.Drawing.Point(548, 38);
            this.lblDiamondTotal.Name = "lblDiamondTotal";
            this.lblDiamondTotal.Size = new System.Drawing.Size(37, 13);
            this.lblDiamondTotal.TabIndex = 19;
            this.lblDiamondTotal.Text = "Total: ";
            this.lblDiamondTotal.Visible = false;
            // 
            // lblDiamond
            // 
            this.lblDiamond.AutoSize = true;
            this.lblDiamond.Location = new System.Drawing.Point(548, 12);
            this.lblDiamond.Name = "lblDiamond";
            this.lblDiamond.Size = new System.Drawing.Size(49, 13);
            this.lblDiamond.TabIndex = 18;
            this.lblDiamond.Text = "Diamond";
            this.lblDiamond.Visible = false;
            // 
            // lblEmeraldTotal
            // 
            this.lblEmeraldTotal.AutoSize = true;
            this.lblEmeraldTotal.Location = new System.Drawing.Point(686, 35);
            this.lblEmeraldTotal.Name = "lblEmeraldTotal";
            this.lblEmeraldTotal.Size = new System.Drawing.Size(37, 13);
            this.lblEmeraldTotal.TabIndex = 21;
            this.lblEmeraldTotal.Text = "Total: ";
            this.lblEmeraldTotal.Visible = false;
            // 
            // lblEmerald
            // 
            this.lblEmerald.AutoSize = true;
            this.lblEmerald.Location = new System.Drawing.Point(678, 9);
            this.lblEmerald.Name = "lblEmerald";
            this.lblEmerald.Size = new System.Drawing.Size(45, 13);
            this.lblEmerald.TabIndex = 20;
            this.lblEmerald.Text = "Emerald";
            this.lblEmerald.Visible = false;
            // 
            // lblOakTotal
            // 
            this.lblOakTotal.AutoSize = true;
            this.lblOakTotal.Location = new System.Drawing.Point(41, 38);
            this.lblOakTotal.Name = "lblOakTotal";
            this.lblOakTotal.Size = new System.Drawing.Size(37, 13);
            this.lblOakTotal.TabIndex = 23;
            this.lblOakTotal.Text = "Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Oak";
            // 
            // tmrMove
            // 
            this.tmrMove.Enabled = true;
            this.tmrMove.Interval = 16;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 483);
            this.Controls.Add(this.lblOakTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmeraldTotal);
            this.Controls.Add(this.lblEmerald);
            this.Controls.Add(this.lblDiamondTotal);
            this.Controls.Add(this.lblDiamond);
            this.Controls.Add(this.lblGoldTotal);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblIronTotal);
            this.Controls.Add(this.lblIron);
            this.Controls.Add(this.lblTotalStone);
            this.Controls.Add(this.lblStone);
            this.Controls.Add(this.btnBuildings);
            this.Controls.Add(this.btnUpgrades);
            this.Controls.Add(this.pbEmeraldOre);
            this.Controls.Add(this.pbDiamondOre);
            this.Controls.Add(this.pbGoldOre);
            this.Controls.Add(this.pbIronOre);
            this.Controls.Add(this.pbStone);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pbWood);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Main Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIronOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoldOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiamondOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmeraldOre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWood;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox pbStone;
        private System.Windows.Forms.PictureBox pbIronOre;
        private System.Windows.Forms.PictureBox pbGoldOre;
        private System.Windows.Forms.PictureBox pbDiamondOre;
        private System.Windows.Forms.PictureBox pbEmeraldOre;
        private System.Windows.Forms.Button btnUpgrades;
        private System.Windows.Forms.Button btnBuildings;
        private System.Windows.Forms.Label lblStone;
        private System.Windows.Forms.Label lblTotalStone;
        private System.Windows.Forms.Label lblIronTotal;
        private System.Windows.Forms.Label lblIron;
        private System.Windows.Forms.Label lblGoldTotal;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblDiamondTotal;
        private System.Windows.Forms.Label lblDiamond;
        private System.Windows.Forms.Label lblEmeraldTotal;
        private System.Windows.Forms.Label lblEmerald;
        private System.Windows.Forms.Label lblOakTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrMove;
    }
}

