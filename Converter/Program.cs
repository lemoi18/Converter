Console.WriteLine("What is your name?");


static int Main(string[] args)
{
    string kuk;
    kuk = Console.ReadLine();
    string[] arguments = Environment.GetCommandLineArgs();
    Console.WriteLine("GetCommandLineArgs: {0}", string.Join(", ", arguments));
    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();
    var currentDate = DateTime.Now;
    Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
    return 0;
}
