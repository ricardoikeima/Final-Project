using FinalProject.model;
using MySql.Data.MySqlClient;
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

namespace FinalProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        /**
         *  TO IMPLEMENT
         *  1. Add, update, remove, players/teams
         *      - TextBox: fname, lname, 
         *      - number picker(with typing): number, age, height, weight
         *      - Combo Box: team (populate with current teams, so user cant enter invalid team.
         *  2. Arrows between trade tab to move players from one team to the other.
         *      then a trade button, which will have a confirmation box pop up.
         *      if accepted, run sql query to update traded players teams. if declined
         *      put players back to original teams?
         *  3. Schedule Tab?
         *      have a schedule table with games booked between teams. have ability to 
         *      update scores for past games. based on scores award winning teams points.
         *  4. Standings Tab?
         *      if implementing schedule and points, have standings?
         *      create a view, query teams tab, order by points? (should be easy)
         *  5. ANYTHING ELSE???
         * 
         **/





        /**
         * Loads all fields with apprpriate info
         **/
        private void Form1_Load(object sender, EventArgs e) {


            // TODO: This line of code loads data into the 'cprojectDataSet.players' table. You can move, or remove it, as needed.

            clearPlayerFields();
            clearTeamFields();


            SoccerPlayerDB playersDB = new SoccerPlayerDB();
            SoccerTeamDB teamsDB = new SoccerTeamDB();
            try {

                DataTable schema = playersDB.getTableSchema();
                
               //each row in the table schema gets inserted into the filetr combo box.
               foreach (DataRow rdrColumn in schema.Rows) {
                   cbFilter.Items.Add(rdrColumn[schema.Columns["ColumnName"]].ToString());
               }

               showAllPlayers();

               showAllTeams();                

            /////// standings tab /////////

            // queries players table and updates dataGridViewPlayers
            dataGridViewStandings.DataSource = teamsDB.getTeamsOrderedByRank();

            } catch (SqlException sql) {
                MessageBox.Show("issue connection to the db " + sql.Errors);
            } catch (Exception ex) {
                MessageBox.Show("some other error " + ex.Message);
            }

        }

        /**
         * loads teams into their respective list boxes based on the team selected for the trade
         * 
         * TODO: check that the same team isnt selected in both boxes
         **/
        private void btn_loadTrade_Click(object sender, EventArgs e) {

            // clear lists before loading new elements
            lbTeam1.Items.Clear();
            lbTeam2.Items.Clear();

            try {
                SoccerPlayerDB playersDB = new SoccerPlayerDB();

                //populates players from the team selected from the combo box
                String t1 = cbTeam1.Text;
                String t2 = cbTeam2.Text;

                //populates lb1 with players from the selected team in cb2
                DataTable team1 = playersDB.getPlayersFromTeam(t1);
                
                foreach (DataRow row in team1.Rows)
                {
                    lbTeam1.Items.Add(row["fname"].ToString() + " " + row["lname"].ToString());
                }

                //populates listbox 2 with the players form the selected team in cb2
                DataTable team2 = playersDB.getPlayersFromTeam(t2);

                foreach (DataRow row in team2.Rows)
                {
                    lbTeam2.Items.Add(row["fname"].ToString() + " " + row["lname"].ToString());
                }

            } catch (SqlException sql) {
                MessageBox.Show("issue connection to the db " + sql.Errors);
            } catch (Exception ex) {
                MessageBox.Show("some other error " + ex.Message);
            }

        }

        /**
         * filters the players dgv based on the filter paramaters selected.
         * 
         * TODO: if results come back null, or no value exists, pop up messagebox with error message 
         * and kill. refresh dgv with all values.
         **/
        private void btn_filter_Click(object sender, EventArgs e) {

            String filterRow = cbFilter.Text;
            String filterText = tbFilter.Text;

            try {
                SoccerPlayerDB playersDB = new SoccerPlayerDB();

                //uses the filter combo box to show show only players who match the filter text 
                // ONLY EXACT MATCHES HAVE BEEN IMPLEMENTED

                dataGridViewPlayers.DataSource = playersDB.getPlayersByFilter(filterRow, filterText);

            } catch (SqlException sql) {
                MessageBox.Show("issue connection to the db " + sql.Errors);
            } catch (Exception ex) {
                MessageBox.Show("some other error " + ex.Message);
            }

        }

        /**
         * loads in all players and removes text from the filter textbox for clarity.
         **/
        private void btn_showAll_Click(object sender, EventArgs e) {
            
            showAllPlayers();
            
            //erases filter values for clarity.
            tbFilter.Clear();

        }

        private void showAllPlayers()
        {
            try
            {
                SoccerPlayerDB playersDB = new SoccerPlayerDB();

                // queries players table and updates dataGridViewPlayers 
                dataGridViewPlayers.DataSource = playersDB.getAll();

            }
            catch (SqlException sql)
            {
                MessageBox.Show("issue connection to the db " + sql.Errors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("some other error " + ex.Message);
            }
        }

        private void showAllTeams()
        {
            SoccerTeamDB teamsDB = new SoccerTeamDB();
            DataTable teams = teamsDB.getAll();
           
            // Update Grid Views
            dataGridViewTeams.DataSource = teams;

            // Update ComboBox
            cbTeam1.Items.Clear();
            cbTeam2.Items.Clear();
            cbPlayerTeams.Items.Clear();
            foreach (DataRow row in teams.Rows)
            {
                cbTeam1.Items.Add(row["tname"].ToString());
                cbTeam2.Items.Add(row["tname"].ToString());
                cbPlayerTeams.Items.Add(row["tname"].ToString());
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            // Connect to database
            SoccerTeamDB db = new SoccerTeamDB();

            // Get team details
            String name = txtName.Text;

            // Verify if team already exist
            if (db.getById(name) == null)
            {
                String division = txtDivision.Text;
                SoccerTeam team = new SoccerTeam(name, division);

                try
                {
                    int result = db.addTeam(team); // Save team

                    if (result > 0)
                    {
                        MessageBox.Show(name + " was added successfully!", "Add Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearTeamFields();
                        showAllTeams();
                    }
                    else
                    {
                        MessageBox.Show(name + " cannot be added!", "Add Team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else // If team already exist
            {
                MessageBox.Show(name + " already exist in database!", "Add Team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearTeam_Click(object sender, EventArgs e)
        {
            clearTeamFields();
        }

        // Clear all Team fields
        private void clearTeamFields()
        {
            txtName.Text = "";
            txtDivision.Text = "";
        }

        // Clear all `Player fields
        private void clearPlayerFields()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtNumber.Text = "";
            txtAge.Text = "";
            txtPosition.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            cbPlayerTeams.SelectedIndex = -1;
            lblPlayerId.Text = "";
        }

        private void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            // Connect to database
            SoccerTeamDB db = new SoccerTeamDB();

            // Get team details
            String name = txtName.Text;

            // Verify if team exist
            if (db.getById(name) != null)
            {
                String division = txtDivision.Text;
                SoccerTeam team = new SoccerTeam(name, division);

                if (!cbDeleteTeam.Checked) // If user want to update the team
                {
                    try
                    {
                        int result = db.updateTeam(team); // Save team

                        if (result > 0)
                        {
                            MessageBox.Show(name + " was successfully updated!", "Update Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearTeamFields();
                            showAllTeams();
                        }
                        else
                        {
                            MessageBox.Show(name + " cannot be updated!", "Update Team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else // User wants to delete the team
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + name, "Delete Team", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No) // Do not delete!
                    {
                        cbDeleteTeam.Checked = false;
                    }
                    else
                    {
                        try
                        {
                            int result = db.deleteTeam(team); // Save team

                            if (result > 0)
                            {
                                MessageBox.Show(name + " successfully deleted!", "Delete Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbDeleteTeam.Checked = false;
                                clearTeamFields();
                                showAllTeams();
                            }
                            else
                            {
                                MessageBox.Show(name + " cannot be deleted!", "Delete Team Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            }
            else // If team doesn't exist
            {
                MessageBox.Show("Please, select team from Grid View", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the cell
            int rowIndex = e.RowIndex;

            // If user do not click on header
            if (rowIndex != -1)
            {
                DataGridViewRow row = dataGridViewTeams.Rows[rowIndex];

                // Update text box
                txtName.Text = row.Cells[0].Value.ToString();
                txtDivision.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorMsg = "Team name is required";
                errorTeamName.SetError(txtName, errorMsg);
                e.Cancel = true;
            }
            else // Remove error provider
            {
                errorTeamName.Clear();
            }
        }

        private void dataGridViewPlayers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the index of the cell
            int rowIndex = e.RowIndex;

            // If user do not click on header
            if (rowIndex != -1)
            {
                DataGridViewRow row = dataGridViewPlayers.Rows[rowIndex];

                // Update text box
                lblPlayerId.Text = row.Cells[0].Value.ToString();
                txtFName.Text = row.Cells[1].Value.ToString();
                txtLName.Text = row.Cells[2].Value.ToString();
                txtNumber.Text = row.Cells[3].Value.ToString();
                txtAge.Text = row.Cells[4].Value.ToString();
                txtPosition.Text = row.Cells[5].Value.ToString();
                txtHeight.Text = row.Cells[6].Value.ToString();
                txtWeight.Text = row.Cells[7].Value.ToString();
                cbPlayerTeams.Text = row.Cells[8].Value.ToString();
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // Connect to database
            SoccerPlayerDB db = new SoccerPlayerDB();

            // Create player
            SoccerPlayer player = new SoccerPlayer();

            player.FirstName = txtFName.Text;
            player.LastName = txtLName.Text;
            player.Number = Convert.ToInt32(txtNumber.Text);
            player.Age = Convert.ToInt32(txtAge.Text);
            player.Position = txtPosition.Text;
            player.Height = Convert.ToInt32(txtHeight.Text);
            player.Weight = Convert.ToInt32(txtWeight.Text);
            player.Team = cbPlayerTeams.Text;

            // Verify if team already exist
            if (db.getPlayerId(player) == 0)
            {
                try
                {
                    int result = db.addPlayer(player); // Save player

                    if (result > 0)
                    {
                        MessageBox.Show(player.FirstName + " " + player.LastName + " was added successfully!", "Add Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearPlayerFields();
                        showAllPlayers();
                    }
                    else
                    {
                        MessageBox.Show(player.FirstName + " " + player.LastName + " cannot be added!", "Add Player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else // If team player exist
            {
                MessageBox.Show(player.FirstName + " " + player.LastName + " already exist in database!", "Add Player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearPlayer_Click(object sender, EventArgs e)
        {
            clearPlayerFields();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            // Connect to database
            SoccerPlayerDB db = new SoccerPlayerDB();
            SoccerPlayer player = new SoccerPlayer();

            // Verify if player exist
            if (lblPlayerId.Text != "")
            {
                // Create player
                player.FirstName = txtFName.Text;
                player.LastName = txtLName.Text;
                player.Number = Convert.ToInt32(txtNumber.Text);
                player.Age = Convert.ToInt32(txtAge.Text);
                player.Position = txtPosition.Text;
                player.Height = Convert.ToInt32(txtHeight.Text);
                player.Weight = Convert.ToInt32(txtWeight.Text);
                player.Team = cbPlayerTeams.Text;

                player.Id = Convert.ToInt32(lblPlayerId.Text);

                if (!cbDeletePlayer.Checked) // If user want to update the Player
                {
                    try
                    {
                        int result = db.updatePlayer(player); // Save team

                        if (result > 0)
                        {
                            MessageBox.Show(player.FirstName + " " + player.LastName + "  was successfully updated!", "Update Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearPlayerFields();
                            showAllPlayers();
                        }
                        else
                        {
                            MessageBox.Show(player.FirstName + " " + player.LastName + " cannot be updated!", "Update Player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else // User wants to delete the team
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + player.FirstName + " " + player.LastName, "Delete Player", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.No) // Do not delete!
                    {
                        cbDeletePlayer.Checked = false;
                    }
                    else
                    {
                        try
                        {
                            int result = db.deletePlayer(player); // Save team

                            if (result > 0)
                            {
                                MessageBox.Show(player.FirstName + " " + player.LastName + " was successfully deleted!", "Delete Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbDeletePlayer.Checked = false;
                                clearPlayerFields();
                                showAllPlayers();
                            }
                            else
                            {
                                MessageBox.Show(player.FirstName + " " + player.LastName + " cannot be deleted!", "Delete Player Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            } 
            else
            {
                MessageBox.Show("Please, select player from Grid View", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
