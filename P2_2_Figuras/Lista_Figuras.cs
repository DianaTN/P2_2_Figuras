namespace P2_2_Figuras;

public class Lista_Figuras
{
    public static void Main(string[] args)
    {
        List<Figura> lista_eventos = new List<Figura>();

        Evento ev1 = new Evento(new DateTime(2023, 10, 04, 14, 15, 00),
            new TimeSpan(1, 0, 0), "Festival de la Abeja", "Comemos miel de abeja");

        lista_eventos.Add(ev1);


        foreach (Evento ev in lista_eventos)
        {
            Console.WriteLine(ev);
        }

    }
}