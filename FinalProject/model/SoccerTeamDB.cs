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
        String table;

        public SoccerTeamDB()
        {
            db = new ConnectDB();
            table = "teams";
        }

        public int addTeam(SoccerTeam temp)
        {
            String name = temp.Name;

            String command = "INSERT INTO {0} VALUES('{1}', {2}, '{3}')", table, temp;

            return db.executeNonQuery(command);
        }

        public SoccerTeam getById(String name)
        {
            SoccerTeam team = new SoccerTeam();

            DataTable result = db.executeReader("SELECT * FROM " + table + " WHERE tname = '" + name + "'");

            if (result.Rows.Count > 0)
            {
                team.Name = result.Rows[0]["tname"].ToString();
                team.Division = result.Rows[0]["division"].ToString();
                team.Ranking = Convert.ToInt32(result.Rows[0]["ranking"].ToString());
            }

            return team;
        }

        public DataTable getAll()
        {
            return db.executeReader("SELECT * FROM " + table);
        }

        public DataTable getTeamsOrderedByRank()
        {
            return db.executeReader("SELECT * FROM " + table + " ORDER BY ranking");
        }

        public DataTable getTableSchema()
        {
            return db.getTableSchema(table);
        }
    }
}
