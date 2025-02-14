using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de salario de un dia");
        double salario = double.Parse(Console.ReadLine());

        Aguinaldo aguinaldo = new Aguinaldo(salario);

        Console.WriteLine("El aguinaldo es " + aguinaldo.CalcularAguinaldo());
    }

    public class Aguinaldo
    {
        public double Salario { get; set; }

        public Aguinaldo(double salario)
        {
            Salario = salario;
        }

        public double CalcularAguinaldo()
        {
            return Salario * 15;
        }
    }
}