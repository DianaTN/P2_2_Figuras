namespace P2_2_Figuras;

public class TrianguloEquilatero : Figura
{
    protected double _lado;

    public TrianguloEquilatero(double lado)
    {
        this._lado = lado;

    }
    public override double GetArea()
    {
        return (Math.Sqrt(3) * (this._lado * this._lado) / 4);
    }
}