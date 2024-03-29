// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Aynur!");
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
Console.WriteLine(roll1+roll2+roll3);

if (roll1 > 3)
{
    Console.Write("It is bigger");
}
else{
    Console.Write("It is not bigger");
}