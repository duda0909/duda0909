using System;


{
    public class ProdutoFisi : Produto
    {

        private double _frete;

        public double Frete
        {
            get { return this._frete; }
        }
        public ProdutoFisico(string nome, double preco, double frete, Fornecedor fornecedor)
        {
            this._nome = nome;
            this._preco = preco;
            this._fornecedor = fornecedor;
            this._frete = frete;     
        }

        public override double CalculaValorTotal()
        {
            return this._frete + this._preco;
        }
        public override void Imprimir()
        {
            Console.WriteLine("<====Fornecedor====");
            Console.WriteLine("Nome:\t{0}", this._fornecedor.Nome);
            Console.WriteLine("CNPJ:\t{0}", this._fornecedor.Cnpj);
            Console.WriteLine("==========================");
            Console.WriteLine("produto:\t{0}", this.Nome); 
            Console.WriteLine("Preço:\t\tR$ {0:0.00}", this._preco);
            Console.WriteLine("Frete:\t\tR$ {0:0.00}", this._frete);
            Console.WriteLine("alor:\t\tR$ {0:0.00}", this.calculaValorTotal());
        }
    }
}
