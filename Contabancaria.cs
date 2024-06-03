class ContaBancaria
{
    public string NumeroConta;
    public string Titular;
    public double Saldo;

    public ContaBancaria()
    {
        NumeroConta = "Desconhecido";
        Titular = "Desconhecido";
        Saldo = 0.0;
    }

    public ContaBancaria(string numeroConta, string titular, double saldo)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = saldo;
    }
}
