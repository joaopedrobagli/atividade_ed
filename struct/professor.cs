namespace Struct;

public struct Professor{
   public string nome;
    public decimal salario;
    public int cargaHoraria;

    

    
    public void aumentarCargaHorariaDeTrabalho(int horasAumento, decimal valorReajuste)
    {
        cargaHoraria += horasAumento;
        salario += valorReajuste;
    }

public void descontoSalarialPorFaltaEmValor(decimal valorDesconto)
    {
        salario -= valorDesconto;
    }
   

    

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Salário: $" + salario);
        Console.WriteLine("Carga Horária: " + cargaHoraria + " horas");
    }
}