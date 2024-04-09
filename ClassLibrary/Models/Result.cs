using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string GolfTournament { get; set; }
        public int PlayerId { get; set;}
        public int Round1 { get; set;  }
        public int Round2 { get; set;  }
        public int Round3 { get; set;  }
        public int Round4 { get; set;  }
        public int TotalRounds { get; set;  }

        public Result()
        {
        }

        public Result(string sor)
        {
            string[] adat= sor.Split(';');
            GolfTournament = adat[0];
            PlayerId = Convert.ToInt32(adat[1]);
            Round1 = Convert.ToInt32(adat[2]);
            Round2 = Convert.ToInt32(adat[3]);
            Round3 = Convert.ToInt32(adat[4]);
            Round4 = Convert.ToInt32(adat[5]);
            TotalRounds= Round1+Round2+Round3+Round4;
        }
    }
}
