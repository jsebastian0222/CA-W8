using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionstring = "server = localhost; uid = root; pwd = ; database = premier_league";
        MySqlConnection sqlconnect;
        MySqlCommand sqlcommand;
        MySqlDataAdapter sqldataadapter;
        string sqlquery;
        DataTable dtpemain = new DataTable();
        DataTable dtmanager = new DataTable();
        DataTable dtmatc = new DataTable();
        DataTable dtfilter = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection(connectionstring);
            sqlquery = "SELECT t.team_name as `Team name` , t.team_id as `team` from team t ;";
            sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
            sqldataadapter = new MySqlDataAdapter(sqlcommand);
            sqldataadapter.Fill(dtfilter);
            comboBoxTeam.DataSource = dtfilter;
            comboBoxTeam.ValueMember = "team";
            comboBoxTeam.DisplayMember = "Team name";
            //dgvteam.DataSource = dtpemainnationality;
        }

        private void dgvplayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxnationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvmanager.Visible = true;
           

           
        }

        private void Buttonenter_Click(object sender, EventArgs e)
        {
            if (dgvmanager.Visible == true)
            {
                sqlconnect = new MySqlConnection(connectionstring);
                //connect.Open(); 
                dtpemain.Rows.Clear();
                dtpemain.Columns.Clear();
                sqlquery = "SELECT p.player_name as `Player Name` , t.team_name as `Team` ,p.playing_pos as `Pos`, p.weight as `Weight` , p.height as `Height` from player p, team t where p.team_id = t.team_id and t.team_name = '"+comboBoxTeam.Text+"'";
                sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(dtpemain);
                dgvteam.DataSource = dtpemain;
                dtpemain.Rows.Clear();

                dtmanager.Rows.Clear();
                dtmanager.Columns.Clear();
                sqlquery = "SELECT t.team_name as `Team Name` , m.manager_name as `Manager name`, m.birthdate as `Birthday`, n.nation as `nationally` from team t , manager m , nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_name = '"+comboBoxTeam.Text+"'";
                sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(dtmanager);
                dgvmanager.DataSource = dtmanager;
            }

            if (dgvmanager.Visible == false)
            {
                dtmatc.Rows.Clear();
                dtmatc.Columns.Clear();
                sqlconnect = new MySqlConnection(connectionstring);
                sqlquery = "SELECT t.team_name as `Team Home` , tt.team_name as `Away Team` , m.match_date as `Date` , m.goal_home as `home goal` , m.goal_away as `away goal` , r.referee_name as `referee` from `match` m , referee r, team t , team tt where r.referee_id = m.referee_id and t.team_id = m.team_home and tt.team_id = m.team_away and t.team_name = '"+comboBoxTeam.Text+"' ";
                sqlcommand = new MySqlCommand(sqlquery, sqlconnect);
                sqldataadapter = new MySqlDataAdapter(sqlcommand);
                sqldataadapter.Fill(dtmatc);
                dgvteam.DataSource = dtmatc;
            }
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            dgvmanager.Visible = false;

            


        }
    }
}
