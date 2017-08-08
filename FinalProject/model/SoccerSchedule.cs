using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.model
{
    class SoccerSchedule
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string HomeTeam { get; set; }
        public int HomeScore { get; set; }
        public string VisitorTeam { get; set; }
        public int VisitorScore { get; set; }
        public int Points { get; set; }

        public SoccerSchedule()
        {

        }
        public SoccerSchedule(int id,string date, string hometeam, int homescore, string visitorteam, int visitorscore,int points)
        {
            Id = id;
            Date = date;
            HomeTeam = hometeam;
            HomeScore = homescore;
            VisitorTeam = visitorteam;
            VisitorScore = visitorscore;
            Points = points;
        }
    }
}
