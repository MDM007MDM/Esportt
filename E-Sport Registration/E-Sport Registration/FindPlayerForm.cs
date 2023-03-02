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
    public partial class FindPlayerForm : Form
    {
        PlayerClass player;
        public FindPlayerForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            foreach (PlayerClass player_ in PlayersForm.Instance.listplayer)
            {
                dataGridView1.Rows.Add(player_.Name, player_.LastName, player_.ID, player_.Major, player_.GameName, player_.Email, player_.Phone, player_.Age);
            }
        }

        private void SM_Click(object sender, EventArgs e)
        {
            PlayerClass pp = PlayersForm.Instance.listplayer[dataGridView1.CurrentRow.Index];
            player = pp;
            this.DialogResult = DialogResult.OK;
        }

        public PlayerClass GetPlayer()
        {
            return player;
        }
    }
}
