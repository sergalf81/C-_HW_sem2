void SecondDigit(int num)
{
    int SecondDigit = num%100/10;
    System.Console.WriteLine(($"{num} -> {num%100/10}"));
}
int num = new Random().Next(100, 1000);
SecondDigit(num);
