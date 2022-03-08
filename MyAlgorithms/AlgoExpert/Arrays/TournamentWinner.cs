using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Arrays
{
    public class TournamentWinner
    {
        public static string Method1(List<List<string>> competitions, List<int> results)
        {

            Hashtable board = new Hashtable();
            string finalWinner = "";

            for (int i = 0; i < results.Count; i++)
            {
                string winner = (results[i] == 0) ? competitions[i][1] : competitions[i][0];

                if (!board.ContainsKey(winner))
                    board.Add(winner, 3);
                else
                    board[winner] = (int)board[winner] + 3;

                if (i == 0)
                    finalWinner = winner;

                if ((int)board[winner] > (int)board[finalWinner])
                    finalWinner = winner;

            }

            return finalWinner;
        }


        public static string Method2(List<List<string>> competitions, List<int> results)
        {
            string currentBestTeam = "";
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores[currentBestTeam] = 0;

            for(int idx = 0; idx < competitions.Count; idx++)
            {
                List<string> competition = competitions[idx];
                int result = results[idx];

                string homeTeam = competition[0];
                string awayTeam = competition[1];

                //HOME_TEAM_WON = 1
                string winningTeam = (result == 1) ? homeTeam : awayTeam;

                updateScores(winningTeam, 3, scores);

                if (scores[winningTeam] > scores[currentBestTeam])
                    currentBestTeam = winningTeam;
            }

            return currentBestTeam;

        }


        public static void updateScores(string team, int points, Dictionary<string, int> scores)
        {
            if (!scores.ContainsKey(team))
                scores[team] = 0;

            scores[team] = scores[team] + points;
        }


    }
}
