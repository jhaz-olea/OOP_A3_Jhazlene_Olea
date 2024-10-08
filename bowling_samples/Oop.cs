﻿public class BowlingGameOOP
{
    private List<int> rolls = new List<int>();

    public void Roll(int pins)
    {
        rolls.Add(pins);
    }

    public int Score()
    {
        int score = 0;
        int rollIndex = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsStrike(rollIndex))
            {
                score += 10 + StrikeBonus(rollIndex);
                rollIndex++;
            }
            else if (IsSpare(rollIndex))
            {
                score += 10 + SpareBonus(rollIndex);
                rollIndex += 2;
            }
            else
            {
                score += SumOfPinsInFrame(rollIndex);
                rollIndex += 2;
            }
        }
        return score;
    }

    private bool IsStrike(int rollIndex)
    {
        return rolls[rollIndex] == 10;
    }

    private bool IsSpare(int rollIndex)
    {
        return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
    }

    private int StrikeBonus(int rollIndex)
    {
        return rolls[rollIndex + 1] + rolls[rollIndex + 2];
    }

    private int SpareBonus(int rollIndex)
    {
        return rolls[rollIndex + 2];
    }

    private int SumOfPinsInFrame(int rollIndex)
    {
        return rolls[rollIndex] + rolls[rollIndex + 1];
    }
}
