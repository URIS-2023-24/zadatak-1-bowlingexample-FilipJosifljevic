namespace BowlingExample
{
    internal class Frame
    {
        private int attempt1 = 0, attempt2 = 0, bonus =0;
        private bool Strike, Spare;
        private static int total = 0;

        public Frame()
        {
        }

        public int getAttempt1()
        {
            return attempt1;
        }
        public int getAttempt2()
        {
            return attempt2;
        }

        public void setAttempt1(int attempt1)
        {
            this.attempt1 = attempt1;
        }

        public void setAttempt2(int attempt2)
        {
            this.attempt2 = attempt2;
        }

        public int getBonus()
        {
            return bonus;
        }

        public void setBonus(int bonus)
        {
            this.bonus = bonus;
        }

        public bool isStrike()
        {
            return Strike;
        }

        public void setStrike(bool isStrike)
        {
            this.Strike = isStrike;
        }

        public bool isSpare()
        {
            return Spare;
        }

        public void setSpare(bool isSpare)
        {
            this.Spare = isSpare;
        }

        public int getTotal(int total)
        {
            return total;
        }

        public void setTotal(int attempt1, int attempt2, int bonus)
        {
            total += attempt1 + attempt2 +bonus;
        }

        public String toString(int frameNumber)
        {
            return "Frame " + frameNumber.ToString() + ": [Attempt 1 -> " + attempt1.ToString() + ", Attempt 2 ->" + attempt2.ToString() + ", Bonus -> " + bonus.ToString() + ", Total -> " + total.ToString() +"]";
        }

    }
}
