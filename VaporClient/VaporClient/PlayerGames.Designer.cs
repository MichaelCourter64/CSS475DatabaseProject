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
            this.GameList = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveGameButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameList
            // 
            this.GameList.FormattingEnabled = true;
            this.GameList.Location = new System.Drawing.Point(12, 12);
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(486, 251);
            this.GameList.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RemoveGameButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(504, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(147, 251);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // RemoveGameButton
            // 
            this.RemoveGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveGameButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveGameButton.Name = "RemoveGameButton";
            this.RemoveGameButton.Size = new System.Drawing.Size(141, 35);
            this.RemoveGameButton.TabIndex = 0;
            this.RemoveGameButton.Text = "Remove Game";
            this.RemoveGameButton.UseVisualStyleBackColor = true;
            this.RemoveGameButton.Click += new System.EventHandler(this.RemoveGameButton_Click);
            // 
            // PlayerGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 274);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GameList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerGames";
            this.Text = "Player Games";
            this.Load += new System.EventHandler(this.PlayerGames_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GameList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button RemoveGameButton;
    }
}

