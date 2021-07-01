using System;

{
     public class Fornecedor : Imprimivel
  {
      private string _nome;
      private string _cnpj;

            public string Nome
            {
                get
                {
                return this._nome;
                }
            }

            public string Cnpj
            {
                get
                {
                return this._cnpj;
                }
            }

            public Fornecedor(string nome, string cnpj)
            {
                this._nome = nome;
                this._cnpj = cnpj;
            }
            
            public void Imprimir()
            {
                Console.WriteLine("Nome:\t{0}", this.Nome); 
                Console.WriteLine("CNPJ:\t{0}", this.Cnpj);
            }
   }
}
