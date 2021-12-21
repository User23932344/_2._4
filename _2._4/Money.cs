using System;


namespace _2._4
{
    class Money
    {
        int rub;
        int cop;
        int Rub
        {
            get { return rub; }
            set
            {
                if (value >= 0)
                {
                    rub = value;
                }
                else
                {
                    Console.WriteLine("Negative value");
                }
            }
        }
        int Cop
        {
            get { return cop; }
            set
            {
                if (value >= 0)
                {
                    cop = value;
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
            }
        }
        public Money(int rub, int cop)
        {
            this.Rub = rub;
            this.Cop = cop;
        } 
        public Money() { }
        static public Money NumberDivision(int value)
        {
            return new Money { Rub = value / 100, Cop = value % 100 };
        }
        static public int RubToCop(Money money)
        {
            return money.Rub * 100 + money.Cop;
        }
        public new string ToString() 
        {
            double value = Rub + ((double)Cop / 100);
            return Convert.ToString(value);
        }
        static public Money operator +(Money money1, Money money2) 
        {
            int value1 = RubToCop(money1);
            int value2 = RubToCop(money2);

            return NumberDivision(value1 + value2);
        }
        static public bool operator >(Money money1, Money money2)
        {
            int value1 = RubToCop(money1);
            int value2 = RubToCop(money2);
            if (value1 > value2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool operator <(Money money1, Money money2)
        {
            int value1 = RubToCop(money1);
            int value2 = RubToCop(money2);
            if (value1 < value2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

