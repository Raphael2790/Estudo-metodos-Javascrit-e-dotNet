using System;
using System.Collections.Generic;

namespace Aprendendo_metodos
{
  public partial class Program
  {
    public static void WritingAMatrix()
    {
      int[,] matrix = new int[5, 5];
      int row_index, column_index, x = 0, rows = 5, columns = 5;
      List<int> secundaryDiagonal = new List<int>();
      List<int> primaryDiagonal = new List<int>();

      for (row_index = 0; row_index < rows; row_index++)
      {
        for (column_index = 0; column_index < columns; column_index++)
        {
          matrix[row_index, column_index] = ++x * 2;
        }
      }

      // Escreve no console a matrix completa
      for (row_index = 0; row_index < rows; row_index++)
      {
        for (column_index = 0; column_index < columns; column_index++)
        {
          Console.Write(matrix[row_index, column_index] + "\t");
        }
        Console.WriteLine();
      }

      //Escreve no console os itens que pertencem a diagonal primaria
      for (row_index = 0; row_index < rows; row_index++)
      {
        for (column_index = 0; column_index < columns; column_index++)
        {
          if (row_index == column_index)
          {
            primaryDiagonal.Add(matrix[row_index, column_index]);
          }
        }
      }

      //Escreve no console os itens que pertencem a diagonal secundária
      for (row_index = 0; row_index < rows; row_index++)
      {
        for (column_index = 0; column_index < columns; column_index++)
        {
          if (row_index + column_index == rows - 1)
          {
            secundaryDiagonal.Add(matrix[row_index, column_index]);
          }
        }
      }
      System.Console.WriteLine("Está é a diagonal primária:");
      primaryDiagonal.ForEach((p) => Console.Write(p.ToString() + ','));
      System.Console.WriteLine();
      System.Console.WriteLine("Está é a diagonal secundária:");
      secundaryDiagonal.ForEach((p) => Console.Write(p.ToString() + ','));
    }
  }
}