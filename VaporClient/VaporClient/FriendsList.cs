using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaporClient
{
    public partial class FriendsList : Form
    {
        public FriendsList()
        {
            InitializeComponent();
        }

        private void FriendsList_Load(object sender, EventArgs e)
        {
            FriendsListTextBox.Text = "";

            // Run method to query games of user.
            Queue<string> friendsUsernames = Queries.GetFriends(UserInfo.CurrentUsername);

            foreach (string friend in friendsUsernames)
            {
                FriendsListTextBox.Text += friend + System.Environment.NewLine;
            }
        }
    }
}
