using System.Drawing;
using System.Net.NetworkInformation;

namespace P2_2_Figuras;

public class TrianguloEquilatero : Figura
{
    protected double _lado;

    public TrianguloEquilatero(double lado, Color color)
    {
        this._lado = lado;
        this._color = color;
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
        return $"Lado: {this._lado} " + " Area: " + GetArea() + " " + GetColor();
    }


    public override Color GetColor()
    {
        return _color;
    }

    public override void SetColor(Color color)
    {
        _color = color;
    }
}

