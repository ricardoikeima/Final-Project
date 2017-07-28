using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.model
{
    class SoccerPlayerDB
    {
        ConnectDB db;
        String table;

        public SoccerPlayerDB()
        {
            db = new ConnectDB();
            table = "players";
        }

        // Add player
        public int addPlayer(SoccerPlayer player)
        {
            // Create command
            string command = string.Format("INSERT INTO {0}(fname, lname, `number`, age, `position`, height, weight, team) VALUES('{1}', '{2}', {3}, {4}, '{5}', {6}, {7}, '{8}')", table, player.FirstName, player.LastName, player.Number, player.Age, player.Position, player.Height, player.Weight, player.Team);

            return db.executeNonQuery(command);
        }

        // Update a team
        public int updatePlayer(SoccerPlayer player)
        {
            // Create command
            string command = string.Format("UPDATE {0} SET fname = '{1}', lname = '{2}', number = {3}, age = {4}, position = '{5}', height = {6}, weight = {7}, team = '{8}' WHERE id = {9}", table, player.FirstName, player.LastName, player.Number, player.Age, player.Position, player.Height, player.Weight, player.Team, player.Id);

            // Return int
            return db.executeNonQuery(command);
        }

        // Delete team
        public int deletePlayer(SoccerPlayer player)
        {
            // Create command
            string command = string.Format("DELETE FROM {0} WHERE id = '{1}'", table, player.Id);

            // Return int
            return db.executeNonQuery(command);
        }

        public SoccerPlayer getById(int id)
        {
            SoccerPlayer player = new SoccerPlayer();
            
            // Create command
            string command = string.Format("SELECT * FROM {0} WHERE id = {1}", table, id);

            DataTable result = db.executeReader(command);

            // If ID exist, create player
            if (result.Rows.Count > 0)
            {
                player.Id = Convert.ToInt32(result.Rows[0]["id"].ToString());
                player.FirstName = result.Rows[0]["fname"].ToString();
                player.LastName = result.Rows[0]["lname"].ToString();
                player.Age = Convert.ToInt32(result.Rows[0]["age"].ToString());
                player.Weight = Convert.ToInt32(result.Rows[0]["weight"].ToString());
                player.Height = Convert.ToInt32(result.Rows[0]["height"].ToString());
                player.Number = Convert.ToInt32(result.Rows[0]["number"].ToString());
                player.Position = result.Rows[0]["position"].ToString();
            }
            else // Else, return null
            {
                player = null;
            }

            return player;
        }

        // Return player ID
        public int getPlayerId(SoccerPlayer player)
        {
            int id = 0;

            // Create command
            string command = string.Format("SELECT * FROM {0} WHERE fname = '{1}' AND lname = '{2}' AND number = {3} AND age = {4} AND position = '{5}' AND height = {6} AND weight = {7} AND team = '{8}'", table, player.FirstName, player.LastName, player.Number, player.Age, player.Position, player.Height, player.Weight, player.Team);

            DataTable result = db.executeReader(command);

            // If player exist
            if (result.Rows.Count > 0)
            {
                id = Convert.ToInt32(result.Rows[0]["id"].ToString());
            }

            return id;
        }

        public DataTable getAll()
        {
            return db.executeReader("SELECT * FROM " + table);
        }

        public DataTable getPlayersFromTeam(string team)
        {
            return db.executeReader("SELECT * FROM " + table + " WHERE team = '" + team + "'");
        }

        public DataTable getPlayersByFilter(string filter, string value)
        {
            return db.executeReader("SELECT * FROM " + table + " WHERE " + filter + " = '" + value + "'");
        }

        public DataTable getTableSchema()
        {
            return db.getTableSchema(table);
        }
    }
}
