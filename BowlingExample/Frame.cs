namespace BowlingExample
{
    internal class Frame
    {
        private int attempt1 = 0, attempt2 = 0, attempt3 =0, bonus =0;
        private bool Strike, Spare;


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
        public int getAttempt3()
        {
            return attempt3;
        }

        public void setAttempt1(int attempt1)
        {
            this.attempt1 = attempt1;
        }

        public void setAttempt2(int attempt2)
        {
            this.attempt2 = attempt2;
        }

        public void setAttempt3(int attempt3)
        {
            this.attempt3 = attempt3;
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

        public String toString(int frameNumber)
        {
            if(attempt1 == 10)
                return "Frame " + (frameNumber + 1).ToString() + ": [Attempt 1 -> Strike!, Bonus -> " + bonus.ToString() + "]";
            if((attempt1 + attempt2) == 10)
                return "Frame " + (frameNumber + 1).ToString() + ": [Attempt 1 -> " + attempt1.ToString() + ", Attempt 2 -> Spare!, Bonus -> " + bonus.ToString() + "]";
            return "Frame " + (frameNumber + 1).ToString() + ": [Attempt 1 -> " + attempt1.ToString() + ", Attempt 2 ->" + attempt2.ToString() + ", Bonus -> " + bonus.ToString() + "]";
        }

    }
}
