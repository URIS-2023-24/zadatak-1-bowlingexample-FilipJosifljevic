using BowlingExample;

internal class Program
{
    private static void Main(string[] args)
    {
        int totalScore = 0;
        Frame[] frames = new Frame[10];
        for (int i = 0; i < frames.Length; i++)
        {
            frames[i] = new Frame();
            Console.WriteLine("Frame : " + (i + 1) + "\n");
            Console.WriteLine("Attempt 1 : ");
            frames[i].setAttempt1(Int32.Parse(Console.ReadLine()));
            if (frames[i].getAttempt1() == 10)
            {
                frames[i].setStrike(true);
                continue;
            }
            if (frames[i].getAttempt1() > 10)
            {
                Console.WriteLine("Invalid value : ");
                break;
            }
            Console.WriteLine("Attempt 2 : ");
            frames[i].setAttempt2(Int32.Parse(Console.ReadLine()));
            if (frames[i].getAttempt2() > 10)
            {
                Console.WriteLine("Invalid value : ");
                break;
            }
            if (frames[i].getAttempt1() + frames[i].getAttempt2() == 10)
            {
                frames[i].setSpare(true);
            }
            if (i > 0)
            {
                if (frames[i - 1].isSpare())
                {
                    frames[i - 1].setBonus(frames[i].getAttempt1());
                    totalScore += frames[i - 1].getAttempt1() + frames[i - 1].getAttempt2() + frames[i - 1].getBonus();
                }
                    
                if (frames[i - 1].isStrike())
                {
                    frames[i - 1].setBonus(frames[i].getAttempt1() + frames[i].getAttempt2());
                    totalScore += frames[i - 1].getAttempt1() + frames[i - 1].getAttempt2() + frames[i - 1].getBonus();
                }
            }
            if (i==9 && (frames[i].isSpare() || frames[i].isStrike()))
            {
                Console.WriteLine("Attempt 3 : ");
                frames[i].setAttempt3(Int32.Parse(Console.ReadLine()));
                if (frames[i].getAttempt3() > 10)
                {
                    Console.WriteLine("Invalid value : ");
                    break;
                }
            }
            totalScore += frames[i].getAttempt1() + frames[i].getAttempt2() + frames[i].getAttempt3() + frames[i].getBonus();
            Console.WriteLine(frames[i].toString(i) + "Total : " + totalScore.ToString());
            Console.WriteLine("\n\n");
        }
        
    }
}