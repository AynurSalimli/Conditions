Random dice = new Random();
int num1 = dice.Next(1, 8);
int num2 = dice.Next(1, 8);
int num3 = dice.Next(1, 8);

int total = num1 + num2 + num3;

Console.WriteLine($"Dice roll: {num1}+{num2}+{num3}={total}");

if ((num1 == num2) || (num2 == num3) || (num1 == num3)) ;
{
    if ((num1 == num2) && (num2 == num3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}


if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry you lose");
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
Console.WriteLine(daysUntilExpiration);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day");
    discountPercentage = 20;
}
else if(daysUntilExpiration <=5){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if(daysUntilExpiration <=10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0){
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

string[] numbers = {"A123", "B456", "C789"};
Console.WriteLine(numbers[0]);

