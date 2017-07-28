using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.model
{
    class SoccerTeam
    {
        public string Name { get; set; }
        public int Ranking { get; set; }
        public string Division { get; set; }

        public SoccerTeam() { 
        
        }


        public SoccerTeam(string name, string division) {
            Name = name;
            Division = division;
        }
    }
}
