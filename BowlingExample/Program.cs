using BowlingExample;

internal class Program
{
    private static void Main(string[] args)
    {
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
            Console.WriteLine("Attempt 2 : ");
            frames[i].setAttempt2(Int32.Parse(Console.ReadLine()));
            if (frames[i].getAttempt1() + frames[i].getAttempt2() == 10)
            {
                frames[i].setSpare(true);
            }
            if (i > 0)
            {
                if (frames[i - 1].isSpare())
                    frames[i - 1].setBonus(frames[i].getAttempt1());
                if (frames[i - 1].isStrike())
                    frames[i - 1].setBonus(frames[i].getAttempt1() + frames[i].getAttempt2());
            }
            
            for(int j = 0; j < frames.Length;++j)
            {
                Console.WriteLine(frames[j].toString);
            }
            Console.WriteLine("\n\n");
        }
    }
}