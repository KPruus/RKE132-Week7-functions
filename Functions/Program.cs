Console.WriteLine("Are you coming or leaving? (in/out):");
string userchoice = Console.ReadLine();

if (userchoice == "in")
{
    PrintHello();
}
else if (userchoice == "out")
{
    PrintGoodbye();
}


//PrintHello();
//PrintGoodbye();


static void PrintHello()
{
    Console.WriteLine("Wello, Horld");
}

static void PrintGoodbye()
{
    Console.WriteLine("In a while, crocodile");
}