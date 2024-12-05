namespace Minecraft_Shopping_Rebirth
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnMainGame = new System.Windows.Forms.Button();
            this.pbGoldOre = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoldOre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainGame
            // 
            this.btnMainGame.Location = new System.Drawing.Point(701, 415);
            this.btnMainGame.Name = "btnMainGame";
            this.btnMainGame.Size = new System.Drawing.Size(75, 23);
            this.btnMainGame.TabIndex = 0;
            this.btnMainGame.Text = "Main Game";
            this.btnMainGame.UseVisualStyleBackColor = true;
            // 
            // pbGoldOre
            // 
            this.pbGoldOre.Image = ((System.Drawing.Image)(resources.GetObject("pbGoldOre.Image")));
            this.pbGoldOre.Location = new System.Drawing.Point(12, 24);
            this.pbGoldOre.Name = "pbGoldOre";
            this.pbGoldOre.Size = new System.Drawing.Size(100, 50);
            this.pbGoldOre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGoldOre.TabIndex = 6;
            this.pbGoldOre.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Deep Slate Upgrade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cost: 100 Emeralds";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGoldOre);
            this.Controls.Add(this.btnMainGame);
            this.Name = "Form2";
            this.Text = "Upgrades";
            ((System.ComponentModel.ISupportInitialize)(this.pbGoldOre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainGame;
        private System.Windows.Forms.PictureBox pbGoldOre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}