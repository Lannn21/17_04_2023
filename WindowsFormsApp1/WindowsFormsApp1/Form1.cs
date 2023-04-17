using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;
        DataTable data = new DataTable();
        DataTable manager = new DataTable();
        DataTable dtTim = new DataTable();

        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();

            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim);
            cmbTeam.DataSource = dtTim;
            cmbTeam.ValueMember = "Team ID";
            cmbTeam.DisplayMember = "Team Name";

            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim);
            cmbMatch.DataSource = dtTim;
            cmbMatch.ValueMember = "Team ID";
            cmbMatch.DisplayMember = "Team Name";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel2.SendToBack();
        }
        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel1.SendToBack();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            data.Clear();
            DGVData.DataSource = null;
            sqlQuery = $"SELECT player_name as 'Player Name',team_name as 'Team Name', weight as 'Player Weight',height as 'Player Height' FROM player  INNER JOIN team ON player.team_id = team.team_id WHERE player.team_id = '{cmbTeam.SelectedValue.ToString()}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(data);
            DGVData.DataSource = data;

            manager.Clear();
            DGV2Data.DataSource = null;
            sqlQuery = $"SELECT team_name as 'Team Name',manager_name as 'Manager Name',manager.birthdate as 'Manager Birthday',nation as 'Nationality' FROM manager INNER JOIN team ON manager.manager_id = team.manager_id INNER JOIN nationality ON manager.nationality_id = nationality.nationality_id WHERE team_id = '{cmbTeam.SelectedValue.ToString()}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(manager);
            DGV2Data.DataSource = manager;
        }
        string id = "";
        private void button2_Click(object sender, EventArgs e)
        {
            dtTim.Clear();
            DGV3Data.DataSource = null;
            sqlQuery = $"SELECT * FROM `match` m INNER JOIN team ON m.team_away = team.team_id WHERE team.team_id= '{id}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim);
            DGV3Data.DataSource = dtTim;
        }

        private void cmbMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = cmbMatch.SelectedValue.ToString();
        }
    }
}
