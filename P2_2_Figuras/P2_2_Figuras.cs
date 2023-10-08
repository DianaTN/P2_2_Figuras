namespace P2_2_Figuras;

public class P2_2_Figuras
{
    static void Main(string[] args)
    {
        List<Figura> lista_figuras = new List<Figura>();
        double suma = 0;


        Color co1 = new Color(255, 50, 20, 34);
        Rectangulo r1 = new Rectangulo(3.0, 3.9);
        Console.Write(r1);
        Console.WriteLine(" Color: " + co1);

        Color co2 = new Color(255, 0, 20, 35);
        Circulo c1 = new Circulo(1.6);
        Console.Write(c1);
        Console.WriteLine("Color: " + co2);

        Color co3 = new Color(255, 0, 20, 40);
        TrianguloEquilatero t1 = new TrianguloEquilatero(5.0);
        Console.Write(t1);
        Console.WriteLine("Color: " + co3);

        Color co4 = new Color(255, 47, 60, 150);
        Rectangulo r2 = new Rectangulo(4.0, 4.9);
        Console.Write(r2);
        Console.WriteLine("Color: " + co4);

        Color co5 = new Color(255, 230, 20, 30);
        Circulo c2 = new Circulo(2.0);
        Console.Write(c2);
        Console.WriteLine("Color: " + co5);

        Color co6 = new Color(0, 200, 40, 81);
        TrianguloEquilatero t2 = new TrianguloEquilatero(7.0);
        Console.Write(t2);
        Console.WriteLine("Color: " + co6);

        lista_figuras.Add(c1);
        lista_figuras.Add(t1);
        lista_figuras.Add(r1);
        lista_figuras.Add(c2);
        lista_figuras.Add(t2);
        lista_figuras.Add(r2);

        foreach (Figura fi in lista_figuras)
        {
            Color c = new Color(245, 40, 145, 200);
            Console.Write(fi);
            Console.WriteLine(c);

            suma = suma + fi.GetArea();
        }

        Console.WriteLine("La suma de todas las areas son: " + suma);


    }

}

public struct Color
{
    public int r, g, b, a;

    public Color(int R, int G, int B, int A)
    {
        this.a = A;
        this.r = R;
        this.g = G;
        this.b = B;

    }

    public override string ToString()
    {
        return string.Format("[A={0}, R={1}, G={2}, B={3}]", this.a, this.r, this.g, this.b);
    }
}
