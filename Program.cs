﻿using System;

namespace Cat_Food_Store
{
  class Program
  {

    static string Ask(string question)
    {
      Console.Write(question);
      return Console.ReadLine();
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the cat food store!");
      string entry = Ask("How many cans are you ordering?");
      Console.WriteLine(entry);
    }
  }
}
