using Newtonsoft.Json;
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
    public partial class PlayersForm : Form
    {
        public static PlayersForm Instance;
        public List<PlayerClass> listplayer = new List<PlayerClass>();
        public PlayersForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerRGForm frm = new PlayerRGForm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) ;
            {
                listplayer.Add(frm.getPlayer());
                RefreshDataGrid();
            }
        }
        private void RefreshDataGrid() 
        { 
            dataGridView1.Rows.Clear();
            foreach (PlayerClass player_ in listplayer)
            { 
                dataGridView1.Rows.Add(player_.Name , player_.LastName , player_.ID , player_.Major , player_.GameName , player_.Email , player_.Phone , player_.Age);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Players";
            savefile.Filter = "Json|*.json";
            savefile.ShowDialog();
            if (savefile.FileName != "")
            {
                string json = JsonConvert.SerializeObject(listplayer, Formatting.Indented);
                File.WriteAllText(savefile.FileName, json);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Players";
            openfile.Filter = "Json|*.json";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                listplayer = JsonConvert.DeserializeObject<List<PlayerClass>>(File.ReadAllText(openfile.FileName));
                RefreshDataGrid();
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamsForm tm = new TeamsForm();
            tm.ShowDialog();
        }
    }
}
