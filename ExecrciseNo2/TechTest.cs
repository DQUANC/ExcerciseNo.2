using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("TechTest");
        Console.Write("Insert the Velocity: ");
        double v = Convert.ToDouble(Console.ReadLine()); 
        Console.Write("Insert the Time: ");
        double t = Convert.ToDouble(Console.ReadLine()); 

        double horDis = CalculateHorDis(v, t);
        double verDis = CalculateVerDis(v, t);

        Console.WriteLine("Horizontal Displacement: {0} m", horDis);
        Console.WriteLine("Vertical Displacement: {0} m", verDis);
    }

    static double CalculateHorDis(double v, double t)
    {
        double horv = v * Math.Cos(Math.PI / 4);
        double horDis = horv * t;
        return horDis;
    }

    static double CalculateVerDis(double v, double t)
    {
        double Verv = v * Math.Sin(Math.PI / 4);
        double VerDis = Verv * t - 0.5 * 9.8 * Math.Pow(t, 2);
        return VerDis;
    }
}

