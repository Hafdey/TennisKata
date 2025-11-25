using System;

namespace TennisSolution.Tests;

public class TennisTests
{
    [Fact]
    public void PlayerOneScores()
    {
        TennisGame tennisGame = new TennisGame(0, 0);
        string value = tennisGame.playerScores(1);
        Assert.Equal("Player one scored! 15 - Love", value);
    }

    [Fact]
    public void PlayerTwoScores()
    {
        TennisGame tennisGame = new TennisGame(0, 0);
        string value = tennisGame.playerScores(2);
        Assert.Equal("Player two scored! Love - 15", value);
    }

    [Fact]
    public void PlayerOneScoresDeuce()
    {
        TennisGame tennisGame = new TennisGame(2, 3);
        string value = tennisGame.playerScores(1);
        Assert.Equal("Player one scored! Deuce", value);
    }

    [Fact]
    public void PlayerTwoScoresDeuce()
    {
        TennisGame tennisGame = new TennisGame(3, 2);
        string value = tennisGame.playerScores(2);
        Assert.Equal("Player two scored! Deuce", value);
    }

    [Fact]
    public void PlayerOneScoresAdvantage()
    {
        TennisGame tennisGame = new TennisGame(3, 3);
        string value = tennisGame.playerScores(1);
        Assert.Equal("Player one scored! Player one has advantage", value);
    }

    [Fact]
    public void PlayerTwoScoresAdvantage()
    {
        TennisGame tennisGame = new TennisGame(3, 3);
        string value = tennisGame.playerScores(2);
        Assert.Equal("Player two scored! Player two has advantage", value);
    }

    [Fact]
    public void PlayerOneWins()
    {
        TennisGame tennisGame = new TennisGame(3, 2);
        string value = tennisGame.playerScores(1);
        Assert.Equal("Player one scored! Player one wins", value);
    }

    [Fact]
    public void PlayerTwoWins()
    {
        TennisGame tennisGame = new TennisGame(2, 3);
        string value = tennisGame.playerScores(2);
        Assert.Equal("Player two scored! Player two wins", value);
    }
}
