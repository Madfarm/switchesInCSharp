using ChatGPTExcercises;

namespace SwitchTesting
{
    public class Program
    {
        public static void Main()
        {
            ExcercisesViaMethods.Exercise1();
            switchGo(11, 4);
        }

        static void switchGo(int num, int num2)
        {
            switch (num, num2)
            {
                case ( > 10, < 5):
                    System.Console.WriteLine("First num is larger than 10! but the 2nd is less than 5");
                    break;

                case ( > 10, > 10):
                    System.Console.WriteLine("Both are greater than 10!");
                    break;

                default:
                    System.Console.WriteLine($"The first num is {num}, and the second is {num2}");
                    break;
            }
        }
    }


}
