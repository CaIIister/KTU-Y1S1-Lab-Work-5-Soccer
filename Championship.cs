using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_2_Soccer_
{
    /// <summary>
    /// Class-container that contains array of soccer teams and championship mesh of goals
    /// </summary>
    class Championship
    {
        public readonly int max = 50;
        private Matrix scoreTable;
        private SoccerTeam[] teams;
        public int Count { get; set; }
        public Championship()
        {
            Count = 0;
            teams = new SoccerTeam[max];
            scoreTable = new Matrix();
        }
        public SoccerTeam this[int i]
        {
            get
            {
                return teams[i];
            }
            set
            {
                teams[i] = value;
            }
        }
        public int this[int i,int j]
        {
            get
            {
                return scoreTable[i,j];
            }
            set
            {
                scoreTable[i,j] = value;
            }
        }
        /// <summary>
        /// Calculates the score of a single team: If team wins, it scores 3 points, if draw - it's 1 point only
        /// </summary>
        public void Evaluating()
        {
            for(int i=0;i<Count;i++)
            {
                for(int j=0;j<Count;j++)
                {
                    if ((scoreTable[i,j] > scoreTable[j, i]) && (scoreTable[i,j]!=-1))
                    {
                        teams[i].Score += 3;
                        teams[i].Victories++;
                    }
                    else if ((scoreTable[i, j] == scoreTable[j, i]) && (scoreTable[i, j] != -1))
                    {
                        teams[i].Score++;
                    }
                }
            }
        }
        /// <summary>
        /// Calculates all goals of one team for entire championship
        /// </summary>
        public void CalcGoals()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    if(scoreTable[i, j]!=-1)
                    {
                        teams[i].Goals += scoreTable[i, j];
                    }
                }
            }
        }
        /// <summary>
        /// Calculates how many mathes the single team did not miss any goal
        /// </summary>
        public void HowManyMatchesTeamsDidNotMissGoals()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    if (scoreTable[j,i]==0)
                    {
                        teams[i].ZeroGoalsMissed++;
                    }
                }
            }
        }
    }
}
