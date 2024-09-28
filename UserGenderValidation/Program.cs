

Console.WriteLine("Please select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("What is your last name?");

string lastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {lastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {lastName}!");
}
else
{
    Console.WriteLine($"Welcome, {lastName}!");
}


