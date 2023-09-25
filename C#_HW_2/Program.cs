System.Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    string str = num.ToString();
    System.Console.Write("The third number: ");
    System.Console.WriteLine(str[2]);
}
else
{
    System.Console.WriteLine("The third number is missing");
}