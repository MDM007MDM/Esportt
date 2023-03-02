using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Sport_Registration
{
    public partial class TeamRGForm : Form
    {
        TeamClass team;
        List<PlayerClass> listplayer = new List<PlayerClass>();
        public TeamRGForm()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                PlayerClass player = new PlayerClass();
                player.Name = "";
                player.LastName = "";
                player.ID = "";
                player.Major = "";
                player.GameName = "";
                player.Email = "";
                player.Phone = "";
                player.Age = 0;
                listplayer.Add(player);
            }
        }

        private void ST_Click(object sender, EventArgs e)
        {
            string TeamName = TBTNT.Text;
            team = new TeamClass();
            team.TeamName = TeamName;
            team.Members = this.listplayer;
            this.team = team;
            this.DialogResult = DialogResult.OK;
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "B1")
            {
                FindPlayer(0, TBM1T);
            }
            else if (btn.Name == "B2")
            {
                FindPlayer(1, TBM2T);
            }
            else if (btn.Name == "B3")
            {
                FindPlayer(2, TBM3T);
            }
            else if (btn.Name == "B4")
            {
                FindPlayer(3, TBM4T);
            }
            else if (btn.Name == "B5")
            {
                FindPlayer(4, TBM5T);
            }
        }
        private void FindPlayer(int index, TextBox textbox)
        {
            FindPlayerForm fp = new FindPlayerForm();
            fp.ShowDialog();
            if (fp.DialogResult == DialogResult.OK)
            {
                listplayer[index] = fp.GetPlayer();
                textbox.Text = listplayer[index].Name;
            }
        }
        public TeamClass getTeam()
        {
            return this.team;
        }
    }
}
