// Random dice = new Random();
// int num1 = dice.Next(1, 8);
// int num2 = dice.Next(1, 8);
// int num3 = dice.Next(1, 8);

// int total = num1 + num2 + num3;

// Console.WriteLine($"Dice roll: {num1}+{num2}+{num3}={total}");

// if ((num1 == num2) || (num2 == num3) || (num1 == num3)) ;
// {
//     if ((num1 == num2) && (num2 == num3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }


// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }
// else
// {
//     Console.WriteLine("Sorry you lose");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// Console.WriteLine(daysUntilExpiration);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%");
// }

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

// string[] numbers = { "A123", "B456", "C789" };
// Console.WriteLine(numbers[0]);

// int[] reqemler = { 12, 45, 67, 89 };
// int sum = 0;
// int bin = 0;
// foreach (int item in reqemler)
// {
//     sum += item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
// }
// Console.WriteLine(sum);

// string name = "Jane";
// if (name.StartsWith("J"))
// {
//     Console.WriteLine("The name starts with J");
// }

// string sentence = "Man is over there";

// if (sentence.Contains("Man"))
// {
//     Console.WriteLine("true");
// }

// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string orderID in orderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         Console.WriteLine(orderID);
//     }
// }

// //Conditions with boolean

// Console.WriteLine("a" == "A");//false
// Console.WriteLine("a" == "a");//true
// Console.WriteLine(1 == 2);//false

// string myvalue = "a";
// Console.WriteLine(myvalue == "a"); //true
// Console.WriteLine("a" == "a "); //false
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); //true
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("The"));

// //compare

// Console.WriteLine(1 > 2);//false
// Console.WriteLine(2 >= 2);//true

// string text1 = "The quick brown fox";
// Console.WriteLine(text1.Contains("fox"));//true

// int salesAmount = 1001;
// // int discount = salesAmount > 100 ? 200 : 50;
// // Console.WriteLine($"Discount:\t {discount}");
// Console.WriteLine($"Discount:\t{(salesAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tail");

// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin User!");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if(permission.Contains("Manager")){
//     if(level>=20){
//         Console.WriteLine("Contact and Admin for access.");
//     }
//     else{
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else{
//     Console.WriteLine("You do not have sufficient priveleges");
// }

// bool flag = true;
// int value = 0;
// if(flag){
//     Console.WriteLine($"Inside the code block: {value}");
// }
// value = 10;
// Console.WriteLine($"Inside the code block: {value}");

// string name1 = "steve";
// if (name1 == "bob") Console.WriteLine("Found Bob");
// else if (name1 == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");




using System.ComponentModel.DataAnnotations;

int[] numbers1 = { 4, 8, 10, 12, 32, 89 };
int total1 = 0;
bool found = false;

foreach (int number1 in numbers1)
{
    total1 += number1;
    if (number1 == 32)
    {
        found = true;
    }
}
if (found)
{
    Console.WriteLine("Set Contains 32");
}

Console.WriteLine($"Total: {total1}");

//Switch case statements

int employeeLevel = 100;
string employeeName = "John Smith";
string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");



string sku = "01-MN-L";
string[] product = sku.Split('-');


string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");


//for loop
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;

}

for (int a = 10; a > 0; a--)
{
    Console.WriteLine(a);
}

string[] employees = { "Alex", "David", "Michael" };

for (int i = employees.Length - 1; i >= 0; i--)
{
    Console.WriteLine(employees[i]);
}

for (int i = 0; i < employees.Length; i++)
{
    Console.WriteLine(employees[i]);
}

//Fizz Buzz challange

for (int c = 1; c < 101; c++)
{
    if ((c % 3 == 0) && (c % 5 == 0)) //if it divides to 3 and 5 
        Console.WriteLine($"{c} - FizzBuzz");
    else if (c % 3 == 0)
        Console.WriteLine($"{c} - Fizz"); //if it just divides to 3
    else if (c % 5 == 0)
        Console.WriteLine($"{c} - Buzz"); // if it is just divides to 5
    else
        Console.WriteLine($"{c}");
}

//do while statements


Random num = new Random();
int current = 0;

// do
// {
//     current = num.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

while(current > 5){
    Console.WriteLine(current);
    current = num.Next(1,11);
}

Console.WriteLine($"Last number : {current}");

//Roll and dice

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");