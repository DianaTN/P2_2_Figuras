using System.Drawing;

namespace P2_2_Figuras;

public class Circulo : Figura
{
    private double _radio;

    public Circulo(double radio, Color color)
    {
        this._radio = radio;
        this._color = color;

    }
    public double GetRadio => this._radio;

    public void SetRadio(double radio)
    {
        // De esta manera evitamos darle una capacidad negativa
        if (radio < 0)
        {
            this._radio = 0;
        }
        else
        {
            this._radio = radio;
        }
    }
    public override double GetArea()
    {
        return Math.PI * (this._radio * this._radio);
    }

    public override string ToString()
    {
        return $"Radio: {this._radio}" + " Area: " + GetArea() + " " + GetColor();
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