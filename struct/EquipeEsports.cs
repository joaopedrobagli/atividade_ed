namespace Struct;

public struct EquipeEsports{

    public string nome;
    public int numeroCampeonatosVencidos;
    public decimal valorTotalPremiacoes;
    public DateTime dataEstreia;

    public void registrarCampeonatoVencido(decimal valorPremio)
    {
        numeroCampeonatosVencidos++;
        atualizarValorTotalPremiacoes(valorPremio);
    }

    public void atualizarValorTotalPremiacoes(decimal valor)
    {
        valorTotalPremiacoes += valor;
    }

    public bool verificarAnoEstreia()
    {
        return dataEstreia.Year == DateTime.Now.Year;
    }

    public void imprimir()
    {
        Console.WriteLine("Nome da Equipe: " + nome);
        Console.WriteLine("Número de Campeonatos Vencidos: " + numeroCampeonatosVencidos);
        Console.WriteLine("Valor Total de Premiações: $" + valorTotalPremiacoes);
        Console.WriteLine("Data de Estreia: " + dataEstreia.ToString("dd/MM/yyyy"));
    }
}