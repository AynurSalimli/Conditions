Random dice = new Random();
int num1 = dice.Next(1,8);
int num2 = dice.Next(1, 8);
int num3 = dice.Next(1, 8);

int total = num1 + num2 + num3;

Console.WriteLine($"Dice roll: {num1}+{num2}+{num3}={total}");

if((num1 == num2) || (num2 == num3) || (num1 == num3));{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total+=2;
}

if((num1 == num2)&& (num2 == num3)){
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total+=6;
}

if(total>=15){
    Console.WriteLine("You win!");
}
if(total<15){
    Console.WriteLine("Sorry you lose");
}