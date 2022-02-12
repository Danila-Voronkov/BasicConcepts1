using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      int Number = Convert.ToInt32(Console.ReadLine());
      int Degree = Convert.ToInt32(Console.ReadLine());
      int Answer = Number;

      for (int Сounter = 1; Сounter < Degree; ++Сounter)
      {
        Answer *= Number;
      }

      Console.WriteLine(Answer);
      Console.ReadKey();
    }
  }
}
