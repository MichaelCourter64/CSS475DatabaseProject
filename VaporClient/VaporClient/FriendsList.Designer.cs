namespace VaporClient
{
    partial class FriendsList
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
            this.FriendsListTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FriendsListTextBox
            // 
            this.FriendsListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FriendsListTextBox.Location = new System.Drawing.Point(12, 12);
            this.FriendsListTextBox.Multiline = true;
            this.FriendsListTextBox.Name = "FriendsListTextBox";
            this.FriendsListTextBox.ReadOnly = true;
            this.FriendsListTextBox.Size = new System.Drawing.Size(485, 212);
            this.FriendsListTextBox.TabIndex = 0;
            this.FriendsListTextBox.TabStop = false;
            // 
            // FriendsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 236);
            this.Controls.Add(this.FriendsListTextBox);
            this.Name = "FriendsList";
            this.Text = "FriendsList";
            this.Load += new System.EventHandler(this.FriendsList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FriendsListTextBox;
    }
}