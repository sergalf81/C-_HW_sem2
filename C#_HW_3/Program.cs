System.Console.WriteLine("Need to find out the day off or is it not");
System.Console.Write("Enter the number of the day of the week from 1 to 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >=6 && num <= 7)
    {
        System.Console.WriteLine("Yes, it's a day off");
    }
else if (num >= 1 && num <= 5)
    {
        System.Console.WriteLine("No, it's not a day off");
    }
else 
{
    System.Console.WriteLine("Enter a valid day between 1 and 7");
}
    