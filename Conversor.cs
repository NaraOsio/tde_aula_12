public class Conversor 
{
    public double ConverterParaDouble(int valor)
    {
        return Convert.ToDouble(valor);
    }

    public int ConverterParaInt(double valor)
    {
        return Convert.ToInt32(valor);
    }

    public int ConverterStringParaInt(string valor)
    {
        return Convert.ToInt32(valor);
    }

    public double ConverterParaDouble(string valor)
    {
        return Convert.ToDouble(valor);
    }
}