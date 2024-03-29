﻿using System;
using System.Globalization;

namespace lista7_1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString() //override é uma sobreposicao
        {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"PERÍMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
