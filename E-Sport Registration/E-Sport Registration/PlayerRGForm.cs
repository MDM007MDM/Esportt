using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Sport_Registration
{
    public partial class PlayerRGForm : Form
    {
        PlayerClass player;
        public PlayerRGForm()
        {
            InitializeComponent();
        }

        private void SP_Click(object sender, EventArgs e)
        {
            string Name = TBNP.Text;
            string LastName = TBLNP.Text;
            string StudentID = TBIDP.Text;
            string Major = TBMP.Text;
            string GameName = TBGNP.Text;
            string Email = TBEP.Text;
            string Phone = TBPP.Text;
            int Age = int.Parse(TBAP.Text);

            player = new PlayerClass()
            {
                Name = Name,
                LastName = LastName,
                ID = StudentID,
                Major = Major,
                GameName = GameName,
                Email = Email,
                Phone = Phone,
                Age = Age
            };
            this.DialogResult = DialogResult.OK;
        }
        public PlayerClass getPlayer()
        {
            return player;
        }
    }
}
