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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ViewGamesButton_Click(object sender, EventArgs e)
        {
            new PlayerGames().Show();
        }

        private void ViewFriendsListButton_Click(object sender, EventArgs e)
        {
            new FriendsList().Show();
        }

        private void GameStoreButton_Click(object sender, EventArgs e)
        {
            new GameStore().Show();
        }
    }
}
