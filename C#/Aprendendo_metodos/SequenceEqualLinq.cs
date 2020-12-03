using System.Collections.Generic;
using System.Linq;

namespace Aprendendo_metodos
{
  public partial class Program
  {
    public static bool ThisListsAreSameSequence(List<int> list1, List<int> list2)
    {
      return list1.SequenceEqual(list2);
    }
  }
}