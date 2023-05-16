using Struct;

namespace EXEMPLO{
    class Program{ 

    static void Main(String[] args)
    {

        string escolha;

Console.WriteLine("Escolha o que quer fazer: ");
escolha = Console.ReadLine();

if(escolha == "jogador"){



        jogadorFutebol jogadorFutebol =  new();


        jogadorFutebol.nome = "dudu";
        jogadorFutebol.time = "palmeiras";
        jogadorFutebol.posicao = "atacante";
        jogadorFutebol.registrarNumeroCartoesAmarelos = "45";
        jogadorFutebol.registrarNumeroCartoesVermelhos = "12";
        jogadorFutebol.verificarVinculoClube = "palmeiras";
        
        System.Console.WriteLine( jogadorFutebol.imprimir());
}
else if(escolha == "equipe"){
    EquipeEsports equipe1 = new EquipeEsports();
        equipe1.nome = "Zart";
        equipe1.numeroCampeonatosVencidos = 6;
        equipe1.valorTotalPremiacoes = 1000;
        equipe1.dataEstreia = new DateTime(2023, 05, 15);

        equipe1.registrarCampeonatoVencido(10000);
        equipe1.registrarCampeonatoVencido(25000);

        equipe1.imprimir();

        Console.WriteLine(" novata ou veterana: " + (equipe1.verificarAnoEstreia() ? "Novata" : "Veterana"));
}

else if(escolha == "Produto"){

       Produto produto1 = new Produto();
        produto1.nome = "celular";
        produto1.preco = 1000;
        produto1.quantidadeEstoque = 20;

        produto1.CupomDescontoValor(10);
        produto1.CupomDescontoPorcentagem(20);

        produto1.imprimir();
        produto1.verificarQuantidadeEstoque();

    }

    else if(escolha == "Professor"){
       Professor professor = new Professor();
        professor.nome = "Andre";
        professor.salario = 4000;
        professor.cargaHoraria = 50;

        professor.aumentarCargaHorariaDeTrabalho(20, 300);
        professor.descontoSalarialPorFaltaEmValor(100);




        professor.imprimir();
    }


}
}
}