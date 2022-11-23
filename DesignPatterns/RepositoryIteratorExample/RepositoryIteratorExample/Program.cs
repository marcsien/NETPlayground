// See https://aka.ms/new-console-template for more information
using RepositoryIteratorExample;

Console.WriteLine("Hello, Iterator Pattern!");


NameRepository namesRepository = new NameRepository();

for (IIterator iter = namesRepository.getIterator(); iter.hasNext();)
{
    string name = (string)iter.next();
    Console.WriteLine("Name : " + name);
}