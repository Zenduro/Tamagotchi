using System.Diagnostics.CodeAnalysis;

Tamagotchi tama = new Tamagotchi();


Console.WriteLine("Välkommen till Tamagotchi"); 
Tamagotchi PlayersTama = new Tamagotchi(); 

Console.WriteLine("Var snäll och skriv din Tamagotchi namn"); 
PlayersTama.name = Console.ReadLine();  

Console.WriteLine($"Super. {PlayersTama.name} Är ett bra namn för din Tamagotchi!");

while (PlayersTama.GetAlive() ==true)
{
  Console.Clear();
  PlayersTama.PrintStats();
  Console.WriteLine("Tjooo, vad är de du vill göra?");
  
  Console.WriteLine($"1. Lär {PlayersTama.name} Ett nytt ord");
 
  Console.WriteLine($"2.  mata {PlayersTama.name}");
  
  Console.WriteLine($"3. Prata med {PlayersTama.name}");
  
  Console.WriteLine($"4. ingenting");
}
{
 string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("Vad för ord?");
    string word = Console.ReadLine();
    PlayersTama.Teach(word);
  }
  if (doWhat == "2")
  {
    PlayersTama.Feed();
  }
  if (doWhat == "3")
  {
    PlayersTama.Hi();
  }
  else
  {
    Console.WriteLine("Gör ingenting");
  }
  PlayersTama.Tick();
  
}

Console.WriteLine($"Oj Verkar som att din {PlayersTama.name} Är DÖD!");
Console.ReadLine();




