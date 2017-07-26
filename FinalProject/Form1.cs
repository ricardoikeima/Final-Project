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
           
            SoccerPlayerDB playersDB = new SoccerPlayerDB();
            SoccerTeamDB teamsDB = new SoccerTeamDB();
            try {

                DataTable schema = playersDB.getTableSchema();
                
               //each row in the table schema gets inserted into the filetr combo box.
               foreach (DataRow rdrColumn in schema.Rows) {
                   cbFilter.Items.Add(rdrColumn[schema.Columns["ColumnName"]].ToString());
               }

               showAllPlayers();

                // queries players table and updates dataGridViewPlayers
                DataTable teams = teamsDB.getAll();
                dataGridViewTeams.DataSource = teams;

                ////// trade tab /////

                //populates  both comboboxs with teams from teams table
                foreach (DataRow row in teams.Rows)
                {
                    cbTeam1.Items.Add(row["tname"].ToString());
                    cbTeam2.Items.Add(row["tname"].ToString());
                }
                 

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

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeam form = new AddTeam();
            form.Show();
        }
    }
}
