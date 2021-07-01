using System;


{
public class Assinatura : Licensa
{
    private int _duracao;

    public double Duracao
    {
        get { return this._duracao; }
    }

    public Assinatura(string nome, double mensalidade, int duracao, string chaveAtivacao) : base(nome, mensalidade, chaveAtivacao)
    {
        this._duracao = duracao;
    }

    public override double calculaValorTotal()
    {
        return this._preco * this._duracao;
    }
    
    public override void Imprimir()
    {
        Console.WriteLine("software:\t{0}", this.Nome); 
        Console.WriteLine("mensalidade:\tR$ {0:0.00}", this._preco);
        Console.WriteLine("Duração:\t{0}", this._duracao);
        Console.WriteLine("valor:\t\tR$ {0:0.00}", this.calculaValorTotal());
    }
}
}
