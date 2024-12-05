namespace Minecraft_Shopping_Rebirth
{
    partial class Form3
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
            this.btnMainGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainGame
            // 
            this.btnMainGame.Location = new System.Drawing.Point(701, 401);
            this.btnMainGame.Name = "btnMainGame";
            this.btnMainGame.Size = new System.Drawing.Size(75, 23);
            this.btnMainGame.TabIndex = 0;
            this.btnMainGame.Text = "Main Game";
            this.btnMainGame.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainGame);
            this.Name = "Form3";
            this.Text = "Buildings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainGame;
    }
}