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
            
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader reader;
            /*String server;
            String database;
            String uid;
            String password;
            
            //con.ConnectionString ="server=40.76.205.114;user id=cproject;password=PROG37721;persistsecurityinfo=True;database=cproject";
            //server=40.76.205.114;user id=cproject;persistsecurityinfo=True;database=cproject
            server = "40.76.205.114";
            database = "cproject";
            uid = "cproject";
            password = "PROG37721";
            String connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            */
            con = new MySqlConnection("server=40.76.205.114;user id=cproject;password=PROG37721;"
                    +"persistsecurityinfo=True;database=cproject");
            try {              
               con.Open();

               // queries players table and updates dataGridViewPlayers 
               cmd = new MySqlCommand("select * from players", con);
               reader = cmd.ExecuteReader();

               //uses player table query to get the table schema.
               DataTable schema = reader.GetSchemaTable();

               //each row in the table schema gets inserted into the filetr combo box.
               foreach (DataRow rdrColumn in schema.Rows) {
                   cbFilter.Items.Add(rdrColumn[schema.Columns["ColumnName"]].ToString());
               }
                
                BindingSource bsPlayers = new BindingSource();
                bsPlayers.DataSource = reader;
                dataGridViewPlayers.DataSource = bsPlayers;

                reader.Close();

                // queries players table and updates dataGridViewPlayers
                cmd = new MySqlCommand("select * from teams", con);
                reader = cmd.ExecuteReader();

                BindingSource bsTeams = new BindingSource();
                bsTeams.DataSource = reader;
                dataGridViewTeams.DataSource = bsTeams;
                reader.Close();

                ////// trade tab /////

                //populates  both comboboxs with teams from teams table
                cmd = new MySqlCommand("select * from teams", con);
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    cbTeam1.Items.Add(reader.GetString(0));
                    cbTeam2.Items.Add(reader.GetString(0));
                }
                reader.Close();
                  

            /////// standings tab /////////

            // queries players table and updates dataGridViewPlayers
            cmd = new MySqlCommand("select * from teams order by ranking", con);
            reader = cmd.ExecuteReader();

            BindingSource bsStandings = new BindingSource();
            bsStandings.DataSource = reader;
            dataGridViewStandings.DataSource = bsStandings;
            
            reader.Close();
            con.Close();

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

            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader reader;

            con = new MySqlConnection("server=40.76.205.114;user id=cproject;password=PROG37721;persistsecurityinfo=True;database=cproject");
            try {

                //populates players from the team selected from the combo box
                con.Open();

                String t1 = cbTeam1.Text;
                String t2 = cbTeam2.Text;

                //populates lb1 with players from the selected team in cb2
                cmd = new MySqlCommand("select * from players where team = '"+t1+"'", con);
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    lbTeam1.Items.Add(reader.GetString(1) + " " + reader.GetString(2)+"\n");
                }
                reader.Close();

                //populates listbox 2 with the players form the selected team in cb2
                cmd = new MySqlCommand("select * from players where team = '" + t2 + "'", con);
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    lbTeam2.Items.Add(reader.GetString(1) + " " + reader.GetString(2) + "\n");
                }
                reader.Close();
                con.Close();

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

            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader reader;
            String filterRow = cbFilter.Text;
            String filterText = tbFilter.Text;

            con = new MySqlConnection("server=40.76.205.114;user id=cproject;password=PROG37721;persistsecurityinfo=True;database=cproject");
            try {
                con.Open();

                //uses the filter combo box to show show only players who match the filter text 
                // ONLY EXACT MATCHES HAVE BEEN IMPLEMENTED
                cmd = new MySqlCommand("select * from players where "+filterRow+" = '" + filterText + "'", con);
                reader = cmd.ExecuteReader();

                // clears and refreshes the dgv to only show fltered results.
                dataGridViewPlayers.Rows.Clear();
                dataGridViewPlayers.Refresh();

                BindingSource bsPlayersFilter = new BindingSource();
                bsPlayersFilter.DataSource = reader;
                dataGridViewPlayers.DataSource = bsPlayersFilter;

                reader.Close();

                con.Close();

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

            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader reader;

            dataGridViewPlayers.Rows.Clear();
            dataGridViewPlayers.Refresh();

            con = new MySqlConnection("server=40.76.205.114;user id=cproject;password=PROG37721;persistsecurityinfo=True;database=cproject");
            try {
                con.Open();

                // queries players table and updates dataGridViewPlayers 
                cmd = new MySqlCommand("select * from players", con);
                reader = cmd.ExecuteReader();

                BindingSource bsPlayers = new BindingSource();
                bsPlayers.DataSource = reader;
                dataGridViewPlayers.DataSource = bsPlayers;

                reader.Close();
                con.Close();

            } catch (SqlException sql) {
                MessageBox.Show("issue connection to the db " + sql.Errors);
            } catch (Exception ex) {
                MessageBox.Show("some other error " + ex.Message);
            }

            //erases filter values for clarity.
            tbFilter.Clear();

        }
    }
}
