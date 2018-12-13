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
    public partial class GameStore : Form
    {
        public GameStore()
        {
            InitializeComponent();
        }

        private void GameStore_Load(object sender, EventArgs e)
        {
            // Get all games.
            Queue<string> gameNames = Queries.GetAllGames();
            // Display them in a selectable list.
            foreach(string name in gameNames)
            {
                string justNameAndDate = name.Remove(name.Length - 12);
                GameList.Items.Add(justNameAndDate);
            }
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            Queries.AddGameToOwnership(UserInfo.CurrentUsername, GameList.SelectedItem.ToString());
        }
    }
}
