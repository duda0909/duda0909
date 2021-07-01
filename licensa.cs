using System
{
public class Licensa: Produto
{
    
    protected string _chaveAtivacao;

    public string ChaveAtivacao
    {
        get { return this._chaveAtivacao; }
    }

    public Licensa(string nome, double preco, string chaveAtivacao)
    {
        this._nome = nome;
        this._preco = preco;
        this._chaveAtivacao = chaveAtivacao;
    }

    public override double calculaValorTotal()
    {
        return this._preco;
    }

    public override void Imprimir()
    {
        Console.WriteLine("software:\t{0}", this.Nome); 
        Console.WriteLine("valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
    }
}
}
