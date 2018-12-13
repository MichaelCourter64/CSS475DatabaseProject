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
            GameList.Text = "";

            // Run method to query games of user.
            Queue<string> games = Queries.GetPlayerGames(UserInfo.CurrentUsername);

            foreach (string game in games)
            {
                GameList.Text += game + System.Environment.NewLine;
            }
        }
    }
}
