using System.Drawing;

namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void Main(string[] args)
    {
        List<Figura> lista_figuras = new List<Figura>();
        double suma = 0;

        Rectangulo r1 = new Rectangulo(3.0, 3.9, Color.FromArgb(255, 50, 20, 34));
        Console.WriteLine(r1);

        Circulo c1 = new Circulo(1.6, Color.FromArgb(255, 0, 20, 35));
        Console.WriteLine(c1);

        TrianguloEquilatero t1 = new TrianguloEquilatero(5.0, Color.FromArgb(255, 0, 20, 40));
        Console.WriteLine(t1);

        Rectangulo r2 = new Rectangulo(4.0, 4.9, Color.FromArgb(255, 47, 60, 150));
        Console.WriteLine(r2);

        Circulo c2 = new Circulo(2.0, Color.FromArgb(255, 230, 20, 30));
        Console.WriteLine(c2);

        TrianguloEquilatero t2 = new TrianguloEquilatero(7.0, Color.FromArgb(0, 200, 40, 81));
        Console.WriteLine(t2);

        lista_figuras.Add(c1);
        lista_figuras.Add(t1);
        lista_figuras.Add(r1);
        lista_figuras.Add(c2);
        lista_figuras.Add(t2);
        lista_figuras.Add(r2);

        foreach (Figura fi in lista_figuras)
        {
            fi.SetColor(Color.FromArgb(245, 40, 145, 200));
            Console.WriteLine(fi);
            suma = suma + fi.GetArea();
        }

        Console.WriteLine("La suma de todas las areas son: " + suma);
    }

}
