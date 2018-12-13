namespace VaporClient
{
    partial class MainMenu
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
            this.ViewFriendsListButton = new System.Windows.Forms.Button();
            this.ViewGamesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewFriendsListButton
            // 
            this.ViewFriendsListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewFriendsListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewFriendsListButton.Location = new System.Drawing.Point(12, 125);
            this.ViewFriendsListButton.Name = "ViewFriendsListButton";
            this.ViewFriendsListButton.Size = new System.Drawing.Size(193, 45);
            this.ViewFriendsListButton.TabIndex = 1;
            this.ViewFriendsListButton.Text = "View Friends List";
            this.ViewFriendsListButton.UseVisualStyleBackColor = true;
            this.ViewFriendsListButton.Click += new System.EventHandler(this.ViewFriendsListButton_Click);
            // 
            // ViewGamesButton
            // 
            this.ViewGamesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ViewGamesButton.Location = new System.Drawing.Point(12, 26);
            this.ViewGamesButton.Name = "ViewGamesButton";
            this.ViewGamesButton.Size = new System.Drawing.Size(193, 45);
            this.ViewGamesButton.TabIndex = 0;
            this.ViewGamesButton.Text = "View Games";
            this.ViewGamesButton.UseVisualStyleBackColor = true;
            this.ViewGamesButton.Click += new System.EventHandler(this.ViewGamesButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ViewGamesButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewFriendsListButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 197);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewFriendsListButton;
        private System.Windows.Forms.Button ViewGamesButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}