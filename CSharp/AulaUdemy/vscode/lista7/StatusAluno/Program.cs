﻿using System;
using System.Globalization;

namespace StatusAluno
{
    class Program
    {       
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write($"Nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notoas do aluno:");
            al.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            al.Result();
        }
    }
}