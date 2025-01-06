//Logical Operators
// AND &&
// OR ||
// NOT !

// Variants of OR statements
// true || true -> true
// true || false -> true
// false || true -> true
// false || false -> false

// Variants of AND statements
// true && true -> true
// true && false -> false
// false && true -> false
// false && false -> false

// relational operator < <= > >=


byte age = 0;
bool isWithParent = false;

if(age >= 13 && age < 18)
{
    if (isWithParent)
    {
        Console.WriteLine("Go party in the club with your parents!");
    }
    else
    {
        Console.WriteLine("Go find a parent or go home!");
    }
}
else if (age >= 18)
{
    Console.WriteLine("Go party in the club!");
}
else
{
    Console.WriteLine("You are too young to party in the club!");
}

Console.ReadKey();



