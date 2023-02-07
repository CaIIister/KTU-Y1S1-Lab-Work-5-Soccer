using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L5_2_Soccer_
{
    internal class Program
    {
        /// <summary>
        /// The reading method that reads information about teams and championship table
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        static void Read(string filename, Championship cont)
        {
            using(StreamReader reader=new StreamReader(filename))
            {
                cont.Count = int.Parse(reader.ReadLine());
                string line;
                char[] delimiters = { ';' };
                for(int i=0;i<cont.Count;i++)
                {
                    cont[i] = new SoccerTeam();
                    line = reader.ReadLine();
                    string[] parts=line.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                    cont[i].Title = parts[0];
                    cont[i].City = parts[1];
                    cont[i].CoachName = parts[2];
                }
                int number;
                for(int i=0;i<cont.Count;i++)
                {
                    line=reader.ReadLine();
                    string[] numbers=line.Split(' ');
                    for(int j=0;j<cont.Count;j++)
                    {
                        number = int.Parse(numbers[j]);
                        cont[i, j] = number;
                    }
                }
            }
        }
        /// <summary>
        /// Method for printing the initial data of the championship
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        /// <param name="note"></param>
        static void PrintTable(string filename, Championship cont,string note)
        {
            using(StreamWriter writer=new StreamWriter(filename,true))
            {
                int q = 92;
                writer.WriteLine(note);
                writer.WriteLine(new string('-', q));
                writer.Write("|");
                writer.Write(new string(' ', 12));
                writer.Write("|");
                for (int i=0;i<cont.Count;i++)
                {
                    writer.Write("{0,12}|", cont[i].Title);
                }
                writer.WriteLine();
                writer.Write(new string('-', q));
                for (int i=0;i<cont.Count;i++)
                {
                    writer.Write("\n|{0,12}|", cont[i].Title);
                    for(int j=0;j<cont.Count;j++)
                    {
                        writer.Write("{0,12}|", cont[i, j]);
                    }
                }
                writer.WriteLine();
                writer.WriteLine(new string('-', q));
                writer.WriteLine("\n");
            }
        }
        /// <summary>
        /// Method for printing the initial data of all teams
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        /// <param name="note"></param>
        static void PrintTeams(string filename, Championship cont, string note)
        {
            using(StreamWriter writer=new StreamWriter(filename,true))
            {
                int q = 44;
                writer.WriteLine(note);
                writer.WriteLine(new string('-', q));
                writer.WriteLine("|   Title    |   City  |     Coach Name    |");
                writer.WriteLine(new string('-', q));
                for(int i=0;i<cont.Count;i++)
                {
                    writer.WriteLine("|{0,12}|{1,9}|{2,19}|", 
                        cont[i].Title, cont[i].City, cont[i].CoachName);
                }
                writer.WriteLine(new string('-', q));
                writer.WriteLine("\n");
            }
        }
        /// <summary>
        /// The same method as "PrintTeams", but with the additional information, such as score of each team
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        /// <param name="note"></param>
        static void PrintTeamsScore(string filename, Championship cont, string note)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                int q = 50;
                writer.WriteLine(note);
                writer.WriteLine(new string('-', q));
                writer.WriteLine("|   Title    |   City  |     Coach Name    |Score|");
                writer.WriteLine(new string('-', q));
                for (int i = 0; i < cont.Count; i++)
                {
                    writer.WriteLine("|{0,12}|{1,9}|{2,19}|{3,5}|", 
                        cont[i].Title, cont[i].City, cont[i].CoachName, cont[i].Score);
                }
                writer.WriteLine(new string('-', q));
                writer.WriteLine("\n");
            }
        }
        /// <summary>
        /// The same method as "PrintTeamsScore", but with the additional information, such as number of victories of each team
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        /// <param name="note"></param>
        static void PrintTeamsVictories(string filename,Championship cont, string note)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                int q = 60;
                writer.WriteLine(note);
                writer.WriteLine(new string('-', q));
                writer.WriteLine("|   Title    |   City  |     Coach Name    |Score|Victories|");
                writer.WriteLine(new string('-', q));
                for (int i = 0; i < cont.Count; i++)
                {
                    writer.WriteLine("|{0,12}|{1,9}|{2,19}|{3,5}|{4,9}|", 
                        cont[i].Title, cont[i].City, cont[i].CoachName, cont[i].Score, cont[i].Victories);
                }
                writer.WriteLine(new string('-', q));
                writer.WriteLine("\n");
            }
        }
        /// <summary>
        /// The same method as "PrintTeamsVictories", but with the additional information, 
        /// such as number of goals of each team
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        /// <param name="note"></param>
        static void PrintTeamsGoals(string filename, Championship cont, string note)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                int q = 66;
                writer.WriteLine(note);
                writer.WriteLine(new string('-', q));
                writer.WriteLine("|   Title    |   City  |     Coach Name    |Score|Victories|Goals|");
                writer.WriteLine(new string('-', q));
                for (int i = 0; i < cont.Count; i++)
                {
                    writer.WriteLine("|{0,12}|{1,9}|{2,19}|{3,5}|{4,9}|{5,5}|", 
                        cont[i].Title, cont[i].City, cont[i].CoachName, cont[i].Score, cont[i].Victories, cont[i].Goals);
                }
                writer.WriteLine(new string('-', q));
                writer.WriteLine("\n");
            }
        }
        /// <summary>
        /// Method for printing ALL information about each soccer team in the championship
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="cont"></param>
        /// <param name="note"></param>
        static void PrintTeamsAll(string filename, Championship cont, string note)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                int q = 90;
                writer.WriteLine(note);
                writer.WriteLine(new string('-', q));
                writer.WriteLine("|   Title    |   City  |     Coach Name    |Score|Victories|Goals|matches with zero goals|");
                writer.WriteLine(new string('-', q));
                for (int i = 0; i < cont.Count; i++)
                {
                    writer.WriteLine("|{0,12}|{1,9}|{2,19}|{3,5}|{4,9}|{5,5}|{6,23}|",
                        cont[i].Title, cont[i].City, cont[i].CoachName, cont[i].Score, cont[i].Victories, cont[i].Goals, cont[i].ZeroGoalsMissed);
                }
                writer.WriteLine(new string('-', q));
                writer.WriteLine("\n");
            }
        }
        /// <summary>
        /// Method for sorting teams by points in descending order. If there are several teams with
        /// the same points number than a team with more victories stands higher.
        /// </summary>
        /// <param name="cont"></param>
        static void SortTeams(Championship cont)
        {
            int smallest;
            SoccerTeam temp = new SoccerTeam();
            for (int i = 0; i < cont.Count - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < cont.Count; j++)
                {
                    if (cont[j] > cont[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = cont[smallest];
                cont[smallest] = cont[i];
                cont[i] = temp;
            }
        }
        /// <summary>
        /// Method for finding team that scored the most goals
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        static int MaxGoals(Championship cont)
        {
            int max = -1;
            for (int i = 0; i < cont.Count; i++)
            {
                if(cont[i].Goals > max)
                {
                    max = cont[i].Goals;
                }
            }
            return max;
        }
        /// <summary>
        /// finds all teams that scored the most goals
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        static Championship TheMostGoals(Championship cont)
        {
            int max=MaxGoals(cont);
            Championship result = new Championship();
            for(int i=0;i<cont.Count;i++)
            {
                if (cont[i].Goals==max)
                {
                    result[result.Count++] = cont[i];
                }
            }
            return result;
        }
        /// <summary>
        /// Method for finding team that did not missed the ball int the most matches
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        static int MaxZeroGoals(Championship cont)
        {
            int max = -1;
            for (int i = 0; i < cont.Count; i++)
            {
                if (cont[i].ZeroGoalsMissed > max)
                {
                    max = cont[i].ZeroGoalsMissed;
                }
            }
            return max;
        }
        /// <summary>
        /// Finds all teams that did not missed the ball int the most matches
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        static Championship ZeroMostGoals(Championship cont)
        {
            int max = MaxZeroGoals(cont);
            Championship result = new Championship();
            for (int i = 0; i < cont.Count; i++)
            {
                if (cont[i].ZeroGoalsMissed == max)
                {
                    result[result.Count++] = cont[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            const string readFile = "L5_2.txt";
            const string printFile = "results.txt";
            if(File.Exists(printFile))
            {
                File.Delete(printFile);
            }


            Championship championship = new Championship();
            Read(readFile, championship);
            PrintTeams(printFile, championship,"Teams Table");
            PrintTable(printFile, championship,"Score Table");


            championship.Evaluating();
            PrintTeamsScore(printFile, championship,"Teams Table with score");


            championship.CalcGoals();
            PrintTeamsGoals(printFile, championship, "Teams Table with Goals");


            Championship theBestTeams = TheMostGoals(championship);
            PrintTeamsGoals(printFile, theBestTeams, "Teams who have the most goals");


            championship.HowManyMatchesTeamsDidNotMissGoals();
            PrintTeamsAll(printFile, championship, "Table with all information about teams");


            SortTeams(championship);
            PrintTeamsVictories(printFile, championship, "Teams Table sorted with Victories");


            Championship theBestZeroTeams= ZeroMostGoals(championship);
            PrintTeamsAll(printFile, theBestZeroTeams, "Teams which did not missed goals in most of the matches");
        }
    }
}
