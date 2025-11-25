using System;

namespace TennisSolution;

public class TennisGame
{
    private int playerOneScore { get; set; }
    private int playerTwoScore { get; set; }
    private List<string> values = new List<string> { "Love", "15", "30", "40" };
    public TennisGame(int player1, int player2)
    {
        playerOneScore = player1;
        playerTwoScore = player2;
    }

    public string playerScores(int player)
    {
        if (player == 1)
        {
            playerOneScore++;
            return $"Player one scored! {getScore()}";
        }
        playerTwoScore++;
        return $"Player two scored! {getScore()}";
    }

    public string getScore()
    {
        int difference = playerOneScore - playerTwoScore;

        //Check for a winner
        if (playerOneScore >= 4 && difference >= 2)
        {
            return "Player one wins";
        }
        else if (playerTwoScore >= 4 && difference <= -2)
        {
            return "Player two wins";
        }

        //Check for a deuce
        else if (difference == 0 && playerOneScore >= 3)
        {
            return "Deuce";
        }

        //Check for advantage
        //Player one advantage
        else if (playerOneScore >= 3 && playerTwoScore >= 3 && difference == 1)
        {
            return "Player one has advantage";
        }
        //Player two advantage
        else if (playerTwoScore >= 3 && playerOneScore >= 3 && difference == -1)
        {
            return "Player two has advantage";
        }
        //No checks return, return score
        return $"{values[playerOneScore]} - {values[playerTwoScore]}";
    }

}
