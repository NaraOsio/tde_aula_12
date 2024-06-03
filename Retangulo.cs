class Retangulo
{
    public double Altura;
    public double Largura;
    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }
    public double Calcular()
    {
        return Altura * Largura;
    }
    public double CalcularArea(double largura, double altura)
    {
        return largura * altura;
    }
}
