int firstTest = 0;
int secondTest = 0;
double prozent = 0;
int maxPoints = 80;
int homework = 0;
int oralTest = 0;
string answer;

Console.WriteLine("hast du bei der ersten prüfung mitgemacht yes or no");
answer = Console.ReadLine()!;

if (answer == "yes")
{
    Console.WriteLine("wie viele punkte hast du erreicht 0-20");
    firstTest = int.Parse(Console.ReadLine()!);
}
else { maxPoints -= 20; }


if (answer == "yes")
{
    Console.WriteLine("wie viele punkte hast du erreicht 0-20");
    secondTest = int.Parse(Console.ReadLine()!);
}
else { maxPoints -= 20; }

Console.WriteLine("How many points did u got on the homework");
homework = int.Parse(Console.ReadLine()!);


Console.WriteLine("hast du bei einer mündlichen prüfung mitgemacht yes or no");
answer = Console.ReadLine()!;

if (answer == "yes")
{
    Console.WriteLine("wie viele punkte hast du erreicht 0-20");
    oralTest = int.Parse(Console.ReadLine()!);
}
else { maxPoints -= 20; }




prozent = 100d * (firstTest + oralTest + homework + secondTest) / maxPoints;
double prozentPossible = 100d * (firstTest + oralTest + 20 + secondTest) / maxPoints;
System.Console.WriteLine($" you got {prozent}% right");

if (prozent >= 89)
{
    Console.WriteLine("Your grade is 1");
}
else if (prozent >= 76)
{
    Console.WriteLine("your grade is 2");
}

else if (prozent >= 63)
{
    Console.WriteLine("your grade is 3");
}
else if (prozent >= 50)
{
    Console.WriteLine("Your grade is 4");
}
else if (prozent < 50)
{
    Console.WriteLine("Your grade is a 5");
}
if (prozentPossible >= 89)
{
    Console.WriteLine("Your possible grade is 1");
}
else if (prozentPossible >= 76)
{
    Console.WriteLine("your possible grade is 2");
}

else if (prozentPossible >= 63)
{
    Console.WriteLine("your possible grade is 3");
}
else if (prozentPossible >= 50)
{
    Console.WriteLine("Your possible grade is 4");
}
else if (prozentPossible < 50)
{
    Console.WriteLine("Your possible grade is a 5");
}




