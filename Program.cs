using System;

namespace Cat_Food_Store
{
  class Program
  {

    static void Ask(string question)
    {
      Console.WriteLine(question);
      string answer = Console.ReadLine();
      Console.WriteLine(answer);
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the cat food store!");
      Ask("How many cans are you ordering?");
    }
  }
}
