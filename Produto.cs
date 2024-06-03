public class Produto
{
    public string Nome;
    public decimal Valor;

    public void Carro()
    {
        Console.WriteLine("$ {Nome} Carro vendido a preço de fábrica");
    }
    public void Vender()
    {
        Console.WriteLine($"{Nome} Vendido");
    }
    
    
    public Produto()
    {
        Nome = "Desconhecido";
        Valor = 0;
    }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Valor = preco;
    }

  
   public void ExibirInfo()
    {
        Console.WriteLine($"Nome do produto: {Nome}");
    }
    public void Acelerar() 
    {
        Console.WriteLine($"{Carro} {Valor}");
    }
    public void ExibirInfo(bool exibirPreco)
    {
        ExibirInfo(); 

        if (exibirPreco)
        {
            Console.WriteLine($"Preço do produto: R${Valor}");
        }
    }


}



