using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.model
{
    class SoccerTeam
    {
        public String Name { get; set; }
        public int Ranking { get; set; }
        public String Division { get; set; }

        public SoccerTeam() { 
        
        }


        public SoccerTeam(String name, String division) {
            Name = name;
            Division = division;
        }
    }
}
