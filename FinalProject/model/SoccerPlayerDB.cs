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

        public SoccerPlayer getById(int id)
        {
            SoccerPlayer player = new SoccerPlayer();

            return player;
        }

        public int updatePlayer(String field, String value)
        {
            return 0;
        }

        public DataTable getAll()
        {
            return db.executeReader("SELECT * FROM " + table);
        }

        public DataTable getPlayersFromTeam(String team)
        {
            return db.executeReader("SELECT * FROM " + table + " WHERE team = '" + team + "'");
        }

        public DataTable getPlayersByFilter(String filter, String value)
        {
            return db.executeReader("SELECT * FROM " + table + " WHERE " + filter + " = '" + value + "'");
        }

        public DataTable getTableSchema()
        {
            return db.getTableSchema(table);
        }
    }
}
