namespace P2_2_Figuras;

public class Rectangulo : Figura
{
    private double _bases;
    private double _altura;

    public Rectangulo(double bases, double altura)
    {
        this._bases = bases;
        this._altura = altura;

    }
    public override double GetArea()
    {
        return (this._altura * this._bases);
    }

    public override string ToString()
    {
        return $"Alto: {this._altura} Ancho: {this._bases} " + base.ToString();
    }
}