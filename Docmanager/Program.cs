using Docmanager;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> test = docmanager.ReadKeys("inverse henry");

foreach (string key in test)
{
    Console.WriteLine(key);
}