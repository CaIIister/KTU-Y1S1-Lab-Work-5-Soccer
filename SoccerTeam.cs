using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_2_Soccer_
{
    /// <summary>
    /// Class about single soccer team
    /// </summary>
    class SoccerTeam
    {
        private string title;
        private string city;
        private string coachName;

        private int score;
        private int victories;
        private int goals;
        private int zeroGoalsMissed;
        public string Title 
        {
            get { return title; } 
            set { title = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string CoachName 
        {
            get { return coachName; } 
            set { coachName = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int Victories
        {
            get { return victories; }
            set { victories=value; }
        }
        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }
        public int ZeroGoalsMissed
        {
            get { return zeroGoalsMissed; }
            set { zeroGoalsMissed = value; }
        }
        public SoccerTeam(string title, string city, string coachName)
        {
            this.title = title;
            this.city = city;
            this.coachName = coachName;
        }
        public SoccerTeam()
        {
            title = "TBT";
            city = "Lviv";
            coachName = "Demchyna Taras";
        }
        public static bool operator>(SoccerTeam var1,SoccerTeam var2)
        {
            bool check=false;
            if(var1.score>var2.score)
            {
                check = true;
            }
            else if(var1.score==var2.score)
            {
                if(var1.victories>var2.victories)
                {
                    check = true;
                }
            }
            return check;
        }
        public static bool operator <(SoccerTeam var1, SoccerTeam var2)
        {
            bool check = false;
            if (var1.score < var2.score)
            {
                check = true;
            }
            else if (var1.score == var2.score)
            {
                if (var1.victories < var2.victories)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
