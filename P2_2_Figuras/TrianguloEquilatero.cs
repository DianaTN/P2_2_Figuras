using System.Net.NetworkInformation;

namespace P2_2_Figuras;

public class TrianguloEquilatero : Figura
{
    protected double _lado;
    protected Color _color;

    public TrianguloEquilatero(double lado)
    {
        this._lado = lado;

    }
    public double GetLado => this._lado;

    public void SetLado(double lado)
    {
        // De esta manera evitamos darle una capacidad negativa
        if (lado < 0)
        {
            this._lado = 0;
        }
        else
        {
            this._lado = lado;
        }
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) * (this._lado * this._lado) / 4);
    }

    public override string ToString()
    {
        return $"Lado: {this._lado} " + " Area: " + GetArea();
    }
}

