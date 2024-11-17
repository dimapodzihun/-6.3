using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
                int[,] matrix = InitializeMatrix(6, 4);
                PrintMatrix(matrix);                    
                (int maxColumnIndex, int maxSum) = FindMaxColumnIndex(matrix);
                Console.WriteLine($"\nНомер стовпця з максимальною сумою: {maxColumnIndex + 1}");
                Console.WriteLine($"Максимальна сума елементів: {maxSum}");
            }
            static int[,] InitializeMatrix(int rows, int columns)
            {
                int[,] matrix = new int[rows, columns];
                Random rand = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = rand.Next(1, 100); 
                    }
                }
                return matrix;
            }
            static void PrintMatrix(int[,] matrix)
            {
                Console.WriteLine("Матриця:");
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j],4}");
                    }
                    Console.WriteLine();
                }
            }
            static (int maxColumnIndex, int maxSum) FindMaxColumnIndex(int[,] matrix)
            {
                int maxColumnIndex = 0;
                int maxSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int columnSum = 0;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        columnSum += matrix[i, j];
                    }

                    if (columnSum > maxSum)
                    {
                        maxSum = columnSum;
                        maxColumnIndex = j;
                    }
                }

                return (maxColumnIndex, maxSum); 
            }

            
            
        }

    }



    



    

