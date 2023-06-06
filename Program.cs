namespace SwitchTesting
{
    class Program
    {
        static void switchGo(int num)
        {
            switch (num)
            {
                case > 10:
                    System.Console.WriteLine("This num is larger than 10!");
                    break;

                case > 5:
                    System.Console.WriteLine("This num is larger than 5!");
                    break;

                default:
                    System.Console.WriteLine($"The num is {num}");
                    break;
            }
        }

        static void Main(string[] args)
        {
            switchGo(6);
        }
    }
}