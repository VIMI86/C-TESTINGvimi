Console.WriteLine("What is ur name");
string username = Console.ReadLine();

if (username.ToLower() == "viet")
{
    Console.Write("Welcome to the Rift, ");
    Console.Write(username);
}
else
{
    Console.Write("We do not know you");
}