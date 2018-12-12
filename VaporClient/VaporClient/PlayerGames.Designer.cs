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
            this.GetPlayerGames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersNameTextField = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GameList = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetPlayerGames
            // 
            this.GetPlayerGames.Location = new System.Drawing.Point(454, 2);
            this.GetPlayerGames.Margin = new System.Windows.Forms.Padding(2);
            this.GetPlayerGames.Name = "GetPlayerGames";
            this.GetPlayerGames.Size = new System.Drawing.Size(97, 28);
            this.GetPlayerGames.TabIndex = 2;
            this.GetPlayerGames.Text = "Load Games";
            this.GetPlayerGames.UseVisualStyleBackColor = true;
            this.GetPlayerGames.Click += new System.EventHandler(this.GetPlayerGames_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // UsersNameTextField
            // 
            this.UsersNameTextField.Location = new System.Drawing.Point(69, 3);
            this.UsersNameTextField.Name = "UsersNameTextField";
            this.UsersNameTextField.Size = new System.Drawing.Size(380, 20);
            this.UsersNameTextField.TabIndex = 5;
            this.UsersNameTextField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.UsersNameTextField);
            this.flowLayoutPanel1.Controls.Add(this.GetPlayerGames);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(558, 38);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // GameList
            // 
            this.GameList.Location = new System.Drawing.Point(9, 61);
            this.GameList.Multiline = true;
            this.GameList.Name = "GameList";
            this.GameList.Size = new System.Drawing.Size(543, 219);
            this.GameList.TabIndex = 7;
            // 
            // PlayerGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 292);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerGames";
            this.Text = "Player Games";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetPlayerGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsersNameTextField;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox GameList;
    }
}

