namespace VaporClient
{
    partial class PlayerGames
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
            this.GameList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GameList
            // 
            this.GameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GameList.Location = new System.Drawing.Point(12, 12);
            this.GameList.Multiline = true;
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(543, 219);
            this.GameList.TabIndex = 7;
            this.GameList.TabStop = false;
            // 
            // PlayerGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 241);
            this.Controls.Add(this.GameList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerGames";
            this.Text = "Player Games";
            this.Load += new System.EventHandler(this.PlayerGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GameList;
    }
}

