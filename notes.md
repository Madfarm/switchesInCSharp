## Switches
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

Switches are essentially if/else control flow statements that can also be given a default

You can also check multiple values at once
switch (num, num2)
{
     case (> 10, < 5):
                    System.Console.WriteLine("First num is larger than 10! but the 2nd is less than 5");
                    break;

                case (> 10, > 10):
                    System.Console.WriteLine("Both are greater than 10!");
                    break;

                default:
                    System.Console.WriteLine($"The first num is {num}, and the second is {num2}");
                    break;
}