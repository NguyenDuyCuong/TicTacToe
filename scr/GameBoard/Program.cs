using System;

namespace GameBoard
{
  class Program
  {
    static void Main(string[] args)
    {
      var arbitrator = new Arbitrator();
      arbitrator.InitGame();

      arbitrator.Play();

      Console.Read();
    }
  }
}
