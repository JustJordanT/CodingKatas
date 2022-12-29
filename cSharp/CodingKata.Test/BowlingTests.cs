using CodingKata.Bowling.Core;
using Xunit;

namespace CodingKata.Test;

public class BowlingTestCases
{
    [Fact]
    public void RollIsANumberLessThanOr10()
    {
        // Arrage 
        var game = new Game();
        Game.Roll();
        var num = Game.CurrentRollScore;
        
        var expect = num <= 10;
        
        Assert.True(expect, "Expected roll score to be 10 or less");
    }
}