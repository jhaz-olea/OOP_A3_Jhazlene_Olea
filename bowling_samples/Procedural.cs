public class BowlingGameProcedural
{
    public int CalculateScore(int[] rolls)
    {
        int score = 0;
        int rollIndex = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsStrike(rolls, rollIndex))
            {
                score += 10 + StrikeBonus(rolls, rollIndex);
                rollIndex++;
            }
            else if (IsSpare(rolls, rollIndex))
            {
                score += 10 + SpareBonus(rolls, rollIndex);
                rollIndex += 2;
            }
            else
            {
                score += SumOfPinsInFrame(rolls, rollIndex);
                rollIndex += 2;
            }
        }
        return score;
    }

    private bool IsStrike(int[] rolls, int rollIndex)
    {
        return rolls[rollIndex] == 10;
    }

    private bool IsSpare(int[] rolls, int rollIndex)
    {
        return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
    }

    private int StrikeBonus(int[] rolls, int rollIndex)
    {
        return rolls[rollIndex + 1] + rolls[rollIndex + 2];
    }

    private int SpareBonus(int[] rolls, int rollIndex)
    {
        return rolls[rollIndex + 2];
    }

    private int SumOfPinsInFrame(int[] rolls, int rollIndex)
    {
        return rolls[rollIndex] + rolls[rollIndex + 1];
    }
}
