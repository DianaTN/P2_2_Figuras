using System.Security.Cryptography.X509Certificates;

namespace P2_2_Figuras;

public class Rectangulo : Figura
{
    private double _bases;
    private double _altura;


    public Rectangulo(double bases, double altura)
    {
        _bases = bases;
        _altura = altura;
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
        return $"Alto: {this._altura} Ancho: {this._bases}" + " Area: " + GetArea() + "Color: ";
    }
}