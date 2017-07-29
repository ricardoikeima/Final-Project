using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.model
{
    class SoccerTeamDB
    {
        ConnectDB db;
        string table;

        public SoccerTeamDB()
        {
            db = new ConnectDB();
            table = "teams";
        }

        // Add a team
        public int addTeam(SoccerTeam team)
        {
            // Create command
            string command = string.Format("INSERT INTO {0} VALUES('{1}', {2}, '{3}')", table, team.Name, team.Ranking, team.Division);

            // Return int
            return db.executeNonQuery(command);
        }

        // Update a team
        public int updateTeam(SoccerTeam team, string id)
        {
            // Create command
            string command = string.Format("UPDATE {0} SET tname = '{1}', ranking = {2}, division = '{3}' WHERE tname = '{4}'", table, team.Name, team.Ranking, team.Division, team.Name, id);

            // Return int
            return db.executeNonQuery(command);
        }

        // Delete team
        public int deleteTeam(SoccerTeam team)
        {
            // Create command
            string command = string.Format("DELETE FROM {0} WHERE tname = '{1}'", table, team.Name);

            // Return int
            return db.executeNonQuery(command);
        }

        // Get team by ID
        public SoccerTeam getById(string name)
        {
            SoccerTeam team = new SoccerTeam();

            // Create command
            string command = string.Format("SELECT * FROM {0} WHERE tname = '{1}'", table, name);

            DataTable result = db.executeReader(command);

            if (result.Rows.Count > 0)
            {
                team.Name = result.Rows[0]["tname"].ToString();
                team.Division = result.Rows[0]["division"].ToString();
                team.Ranking = Convert.ToInt32(result.Rows[0]["ranking"].ToString());
            }
            else
            {
                team = null;
            }

            return team;
        }

        // Get All teams in database
        public DataTable getAll()
        {
            return db.executeReader("SELECT * FROM " + table);
        }

        // Get All teams in database, ordered by rank
        public DataTable getTeamsOrderedByRank()
        {
            return db.executeReader("SELECT * FROM " + table + " ORDER BY ranking");
        }

        // Get table schema
        public DataTable getTableSchema()
        {
            return db.getTableSchema(table);
        }
    }
}
