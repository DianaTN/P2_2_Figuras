namespace P2_2_Figuras;

public class Circulo : Figura
{
    protected double _radio;

    public Circulo(double radio)
    {
        this._radio = radio;

    }
    public override double GetArea()
    {
        return Math.PI * (this._radio * this._radio);
    }
}