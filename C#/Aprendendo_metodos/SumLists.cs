using System.Linq;
using System.Collections.Generic;

namespace Aprendendo_metodos
{
  public partial class Program
  {
    public static int SumListResult(List<int> integerList)
    {
      //Método Sum do Linq que retorna a soma de todos os itens dentro de uma lista
      return integerList.Sum();
    }
  }
}