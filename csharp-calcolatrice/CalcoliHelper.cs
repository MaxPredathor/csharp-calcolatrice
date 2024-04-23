using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public enum Azioni
        {
            SommaInteri,
            SommaDoublen,
            DifferenzaInteri,
            DifferenzaDouble,
            MoltiplicaInteri,
            MoltiplicaDouble,
            ValoreAssolutoInteri,
            ValoreAssolutoDouble,
            MinimoInteri,
            MinimoDouble,
            MassimoInteri,
            MassimoDouble,
            AllaPotenza
        }
        public static int Somma(int num, int num2)
        {
            return num + num2;
        }

        public static double Somma(double num, double num2)
        {
            return num + num2;
        }
        public static int Differenza(int num, int num2)
        {
            return num - num2;
        }

        public static double Differenza(double num, double num2)
        {
            return num - num2;
        }
        public static int Moltiplica(int num, int num2)
        {
            return num * num2;
        }

        public static double Moltiplica(double num, double num2)
        {
            return num * num2;
        }
        public static int ValoreAssoluto(int num)
        {
            return Math.Abs(num);
        }

        public static double ValoreAssoluto(double num)
        {
            return Math.Abs(num);
        }
        public static string Minimo(int num, int num2)
        {
            if (num < num2)
                return $"Il numero mineore e' {num}";
            else if (num > num)
                return $"Il numero mineore e' {num2}";
            else
                return "I Numeri sono uguali";
        }
        public static string Minimo(double num, double num2)
        {
            if (num < num2)
                return $"Il numero mineore e' {num}";
            else if (num > num)
                return $"Il numero mineore e' {num2}";
            else
                return "I Numeri sono uguali";
        }
       
        public static string Massimo(int num, int num2)
        {
            if (num > num2)
                return $"Il numero maggiore e' {num}";
            else if (num2 > num)
                return $"Il numero maggiore e' {num2}";
            else
                return "I Numeri sono uguali";
        }
        public static string Massimo(double num, double num2)
        {
            if (num > num2)
                return $"Il numero maggiore e' {num}";
            else if (num2 > num)
                return $"Il numero maggiore e' {num2}";
            else
                return "I Numeri sono uguali";
        }
        // Polimorfismo
        // SuperFunzione Minimo
        public static string SuperMinimo<T>(T num, T num2) where T : IComparable<T>
        {
            if (num.CompareTo(num2) < 0)
                return $"Il numero mineore e' {num}";
            else if (num.CompareTo(num2) > 0)
                return $"Il numero mineore e' {num2}";
            else
                return "I Numeri sono uguali";
        }
        // SuperFunzione Massimo
        public static string SuperMassimo<T>(T num, T num2) where T : IComparable<T>
        {
            if (num.CompareTo(num2) > 0)
                return $"Il numero maggiore e' {num}";
            else if (num.CompareTo(num2) < 0)
                return $"Il numero maggiore e' {num2}";
            else
                return "I Numeri sono uguali";
        }
        //Bonus
        public static double AllaPotenza(int num, int esponente)
        {
            return Math.Pow(num, esponente);
        }
    }
}
