using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a number")
    string userNumber = Console.ReadLine();
    int number = int.Parse(userNumber);

    for (int i = 0; i <= number; i++)
    {
      if(i % 5 == 0 && i % 3 == 0)
      {
        Console.WriteLine("Ping-Pong");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else 
      {
        Console.WriteLine(i);
      }
    }
  }
}

// num = input
// for(int i =0; i <= num; i++) 
// {
//   if (i % 5 == 0 && i % 3 == 0){
//     console log = ping -pong
//   }
//   else if (i % 5 == 0){
//     console log = pong
//   }else if (i % 3 == 0){
//     console log = ping -pong
//   }else 
//    {
//`    console.WriteLine(i)
//    }
// }
