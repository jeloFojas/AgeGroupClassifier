using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("=====     AGE GROUP CLASSIFIER     =====");
    Console.WriteLine ("========================================");
    Console.WriteLine ("");

    Console.Write("Enter your name: ");
    string nameInput = Console.ReadLine();

    Console.Write("Enter your age: ");
    int ageInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("========================================");
    Console.WriteLine ("");

    Console.WriteLine($"User's Name: {nameInput}");
    Console.WriteLine($"User's Age: {ageInput} years old");

    if (ageInput > 0 && ageInput < 100){
      if (ageInput > 59) {
        Console.WriteLine("You are a Senior Citizen"); 
      } else if (ageInput > 19){
        Console.WriteLine("You are an adult"); 
      } else if (ageInput > 12) {
        Console.WriteLine( "You are a teenager");
      } else {
        Console.WriteLine("You are a child");
      }
    } else{
      Console.WriteLine("Invalid age input.");
    }
    
  }
}