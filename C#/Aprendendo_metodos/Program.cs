using System;
using System.Collections.Generic;
using System.Linq;

namespace Aprendendo_metodos
{
  partial class Program
  {
    static void Main(string[] args)
    {

      List<int> listInt = new List<int>() { 5, 8, 9, 25, 0, 7 };
      List<int> listInt3 = new List<int>() { 5, 8, 9, 25, 0, 7 };

      List<int> listInt2 = new List<int>() { 4, 5, 10, 43, 0, 5 };

      var result = SumListResult(listInt);
      var finalBoard = CompareValues(listInt, listInt2);
      var randomList = RandomNumbers();
      var equalSequence = ThisListsAreSameSequence(listInt, listInt2);
      var equalSequence2 = ThisListsAreSameSequence(listInt, listInt3);
      System.Console.WriteLine($"O resultado é {result}");
      System.Console.WriteLine($"O placar final é {finalBoard[0]} a {finalBoard[1]}");
      foreach (var item in randomList)
      {
        System.Console.WriteLine(item);
      }
      System.Console.WriteLine($"A primeira comparação o resultado foi {equalSequence} e a segunda comparação o resultado foi {equalSequence2}");
      WritingAMatrix();
    }
  }
}
