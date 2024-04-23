using static csharp_calcolatrice.CalcoliHelper;
using System;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Inserisci il numero corrispondente all'azione desiderata");
                int counter = 1;
                foreach (Azioni azione in Enum.GetValues(typeof(Azioni))) 
                {
                    Console.WriteLine($"-{counter} {azione}");
                    counter++;
                }
                string inputUtente = Console.ReadLine();
                switch (inputUtente)
                {
                    case "1":
                        Console.WriteLine("Hai scelto SommaInteri:");
                        Console.WriteLine("Inserire il primo numero intero");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero intero");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int sommaInt = CalcoliHelper.Somma(num1, num2);
                        Console.WriteLine($"Il risultato e' {sommaInt}");
                        break;
                    case "2":
                        Console.WriteLine("Hai scelto SommaDouble:");
                        Console.WriteLine("Inserire il primo numero double");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero double");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        double sommaDouble = CalcoliHelper.Somma(n1, n2);
                        Console.WriteLine($"Il risultato e' {sommaDouble}");
                        break;
                    case "3":
                        Console.WriteLine("Hai scelto DifferenzaInteri:");
                        Console.WriteLine("Inserire il primo numero intero");
                        int diff1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero intero");
                        int diff2 = Convert.ToInt32(Console.ReadLine());
                        int diffInt = CalcoliHelper.Differenza(diff1, diff2);
                        Console.WriteLine($"Il risultato e' {diffInt}");
                        break;
                    case "4":
                        Console.WriteLine("Hai scelto DifferenzaDouble:");
                        Console.WriteLine("Inserire il primo numero double");
                        double diff3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero double");
                        double diff4 = Convert.ToDouble(Console.ReadLine());
                        double diffDouble = CalcoliHelper.Differenza(diff3, diff4);
                        Console.WriteLine($"Il risultato e' {diffDouble}");
                        break;
                    case "5":
                        Console.WriteLine("Hai scelto MoltiplicaInteri:");
                        Console.WriteLine("Inserire il primo numero intero");
                        int molt1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero intero");
                        int molt2 = Convert.ToInt32(Console.ReadLine());
                        int moltInt = CalcoliHelper.Moltiplica(molt1, molt2);
                        Console.WriteLine($"Il risultato e' {moltInt}");
                        break;
                    case "6":
                        Console.WriteLine("Hai scelto MoltiplicaDouble:");
                        Console.WriteLine("Inserire il primo numero double");
                        double molt3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero double");
                        double molt4 = Convert.ToDouble(Console.ReadLine());
                        double moltDouble = CalcoliHelper.Moltiplica(molt3, molt4);
                        Console.WriteLine($"Il risultato e' {moltDouble}");
                        break;
                    case "7":
                        Console.WriteLine("Hai scelto ValoreAssolutoInteri:");
                        Console.WriteLine("Inserire il numero intero di cui si vuole il valore assoluto");
                        int vass1 = Convert.ToInt32(Console.ReadLine());
                        int vassInt = CalcoliHelper.ValoreAssoluto(vass1);
                        Console.WriteLine($"Il risultato e' {vassInt}");
                        break;
                    case "8":
                        Console.WriteLine("Hai scelto ValoreAssolutoDouble:");
                        Console.WriteLine("Inserire il numero double di cui si vuole il valore assoluto");
                        double vass2 = Convert.ToDouble(Console.ReadLine());
                        double vassDouble = CalcoliHelper.ValoreAssoluto(vass2);
                        Console.WriteLine($"Il risultato e' {vassDouble}");
                        break;
                    case "9":
                        Console.WriteLine("Hai scelto MinimoInteri:");
                        Console.WriteLine("Inserire il primo numero intero");
                        int min1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero intero");
                        int min2 = Convert.ToInt32(Console.ReadLine());
                        string minInt = CalcoliHelper.Minimo(min1, min2);
                        Console.WriteLine(minInt);
                        break;
                    case "10":
                        Console.WriteLine("Hai scelto MinimoDouble:");
                        Console.WriteLine("Inserire il primo numero double");
                        double min3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero double");
                        double min4 = Convert.ToDouble(Console.ReadLine());
                        string minDouble = CalcoliHelper.Minimo(min3, min4);
                        Console.WriteLine(minDouble);
                        break;
                    case "11":
                        Console.WriteLine("Hai scelto MassimoInteri:");
                        Console.WriteLine("Inserire il primo numero intero");
                        int max1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero intero");
                        int max2 = Convert.ToInt32(Console.ReadLine());
                        string maxInt = CalcoliHelper.Massimo(max1, max2);
                        Console.WriteLine(maxInt);
                        break;
                    case "12":
                        Console.WriteLine("Hai scelto MassimoDouble:");
                        Console.WriteLine("Inserire il primo numero double");
                        double max3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserire il secondo numero double");
                        double max4 = Convert.ToDouble(Console.ReadLine());
                        string maxDouble = CalcoliHelper.Massimo(max3, max4);
                        Console.WriteLine(maxDouble);
                        break;
                    case "13":
                        Console.WriteLine("Hai scelto AllaPotenza:");
                        Console.WriteLine("Inserire il numero da esporre alla potenza");
                        int pow1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserire la potenza al quale esporre il numero precedente");
                        int pow2 = Convert.ToInt32(Console.ReadLine());
                        double powDouble = CalcoliHelper.AllaPotenza(pow1, pow2);
                        Console.WriteLine($"Il rusultato e' {powDouble}");
                        break;
                    default:
                        Console.WriteLine("Azione non supportata");
                        break;
                }
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }           
    }
}
