namespace ChatGPTExcercises
{
    class ExcercisesViaMethods
    {
        public static void Exercise1()
        {
            System.Console.WriteLine("Enter two numbers to be summed");
            System.Console.WriteLine("Enter the first number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter second number");

            int input2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"Your sum is {input1 + input2}");
        }
    }
}