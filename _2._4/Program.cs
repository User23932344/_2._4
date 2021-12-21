using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(3, 5);
            Console.WriteLine(Money.RubToCop(money1));
            Console.WriteLine(money1.ToString());
            Money money2 = new Money(5, 70);
            Money money3 = money1 + money2;
            Console.WriteLine(money3.ToString());
            Console.WriteLine(money1 > money2);
            Console.WriteLine(money1 < money2);
        }
    }
}
