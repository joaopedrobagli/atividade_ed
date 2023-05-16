namespace Struct;

public struct jogadorFutebol{

    public string nome;

    public string time;

    public string posicao;

    
    public string registrarNumeroCartoesAmarelos;

    public string registrarNumeroCartoesVermelhos;

    public string verificarVinculoClube;

    public jogadorFutebol(string nome ,string time,string posicao, string registrarNumeroCartoesAmarelos, string registrarNumeroCartoesVermelhos, string verificarVinculoClube){
        this.nome = nome;
        this.time = time;
        this.posicao = posicao;
        this.registrarNumeroCartoesAmarelos = registrarNumeroCartoesAmarelos;
        this.registrarNumeroCartoesVermelhos = registrarNumeroCartoesVermelhos;
        this.verificarVinculoClube = verificarVinculoClube;
    }

    public string imprimir(){
        return "\n o jogador:" + this.nome + 
        "\n time: " + this.time +
    "\n posicao: " + this.posicao + "\n tomou esse numero de cartões amarelos: " + this.registrarNumeroCartoesAmarelos  + 
    "\n tomou esse numero de cartões vermelhos: " + this.registrarNumeroCartoesVermelhos + "\n possui vinculo com: " + this.verificarVinculoClube;
    

    }

}