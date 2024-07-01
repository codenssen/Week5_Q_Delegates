namespace Week5_Q_Delegates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ShowMoney money = Euro;
            Console.WriteLine(money(10));
            money = Dollar;
            Console.WriteLine(money(10));
        }

        public delegate string ShowMoney(int money);

        public static string Euro(int money)
        {
            return $"{money} euros";
        }

        public static string Dollar(int money)
        {
            return $"{money} dollars";
        }
    }
}
