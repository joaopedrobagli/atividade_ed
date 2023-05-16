namespace Struct;

public struct Produto{

    public string nome;
    public decimal preco;
    public int quantidadeEstoque;

    public void CupomDescontoValor(decimal valorDesconto)
    {
        if (valorDesconto <= preco)
            preco -= valorDesconto;
    }

    public void CupomDescontoPorcentagem(decimal percentualDesconto)
    {
        decimal desconto = preco * (percentualDesconto / 100);
        if (desconto <= preco)
            preco -= desconto;
    }

    public void verificarQuantidadeEstoque()
    {
        if (quantidadeEstoque > 0)
            Console.WriteLine("Produto disponível em estoque.");
        else
            Console.WriteLine("Produto indisponível em estoque.");
    }

    public void imprimir()
    {
        Console.WriteLine("Nome do Produto: " + nome);
        Console.WriteLine("Preço: $" + preco);
        Console.WriteLine("Quantidade em Estoque: " + quantidadeEstoque);
    }

   
}