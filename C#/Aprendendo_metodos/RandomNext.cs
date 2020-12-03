using System;

namespace Aprendendo_metodos
{
  public partial class Program
  {

    public static int[] RandomNumbers()
    {
      var random = new Random();
      int[] randomArray = new int[10];
      for (int i = 0; i < 10; i++)
      {
        int randomNumber = random.Next();
        randomArray[i] = randomNumber;
      }

      return randomArray;
    }
  }
}