namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void Main(string[] args)
    {
        Rectangulo r1 = new Rectangulo(2.1, 2.1);
        Console.WriteLine(r1);
        Circulo c1 = new Circulo(2.1);
        Console.WriteLine(c1);
        TrianguloEquilatero t1 = new TrianguloEquilatero(2.1);
        Console.WriteLine(t1);
    }
}