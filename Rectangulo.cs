using System.Drawing;
using System.Dynamic;

namespace P2_2_Figuras;

public class Rectangulo : Figura
{
    private double _bases;
    private double _altura;


    public Rectangulo(double bases, double altura, Color color)
    {
        _bases = bases;
        _altura = altura;
        _color = color;
    }

    public double GetBase => this._bases;
    public double GetAltura => this._altura;


    public void SetBase(double bases)
    {
        // De esta manera evitamos darle una capacidad negativa
        if (bases < 0)
        {
            this._bases = 0;
        }
        else
        {
            this._bases = bases;
        }
    }
    public void SetAltura(double altura)
    {
        // De esta manera evitamos darle una capacidad negativa
        if (altura < 0)
        {
            this._altura = 0;
        }
        else
        {
            this._altura = altura;
        }
    }


    public override double GetArea()
    {
        return (this._altura * this._bases);
    }


    public override string ToString()
    {
        return $"Alto: {this._altura} Ancho: {this._bases}" + " Area: " + GetArea() + " " + GetColor();
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