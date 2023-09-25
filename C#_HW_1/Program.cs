System.Console.Write("Input three-digit nimber: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num < 1000)
{
    System.Console.WriteLine($"Second digit of {num} -> {num%100/10}");
}
else
{
    System.Console.WriteLine("You input not tree-digit number");
}