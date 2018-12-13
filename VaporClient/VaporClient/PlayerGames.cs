using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace VaporClient
{
    public partial class PlayerGames : Form
    {
        public PlayerGames()
        {
            InitializeComponent();
        }

        private void PlayerGames_Load(object sender, EventArgs e)
        {
            // For some reason if you add a game to ownership then open
            //     the ownership window too soon then it won't return any
            //     games
            GameList.Text = "";

            // Run method to query games of user.
            Queue<string> games = Queries.GetPlayerGames(UserInfo.CurrentUsername);

            foreach (string game in games)
            {
                string justNameAndDate = game.Remove(game.Length - 12);
                GameList.Items.Add(justNameAndDate);
            }
            
        }

        private void RemoveGameButton_Click(object sender, EventArgs e)
        {
            object gameToRemove = GameList.SelectedItem;
            Queries.RemoveGameFromOwnership(UserInfo.CurrentUsername, gameToRemove.ToString());

            GameList.Items.Remove(gameToRemove);
        }
    }
}
