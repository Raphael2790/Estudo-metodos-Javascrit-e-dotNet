using System.Collections.Generic;
using System.Linq;

namespace Aprendendo_metodos
{
  public partial class Program
  {
    public static List<int> CompareValues(List<int> values1, List<int> values2)
    {
      int resultsPalyer1 = 0;
      int resultsPalyer2 = 0;
      List<int> finalBoard = new List<int>();
      for (int i = 0; i < values1.Count; i++)
      {
        if (values1[i].CompareTo(values2[i]) > 0)
          resultsPalyer1++;
        else if (values1[i].CompareTo(values2[i]) < 0)
          resultsPalyer2++;
      }
      finalBoard.Add(resultsPalyer1);
      finalBoard.Add(resultsPalyer2);

      return finalBoard;
    }
  }
}