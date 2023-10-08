namespace P2_2_Figuras;

public class Circulo : Figura
{
    protected double _radio;

    public Circulo(double radio)
    {
        this._radio = radio;

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
        return $"Radio: {this._radio}" + " Area: " + GetArea();
    }
}