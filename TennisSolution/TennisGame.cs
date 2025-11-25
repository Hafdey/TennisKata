using System;

namespace TennisSolution;

public class TennisGame
{
    private int playerOneScore { get; set; }
    private int playerTwoScore { get; set; }
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

        //Check for advantage

        //No checks return, return score
        return "";
    }

}
