using System;

{
    public class Cliente : Imprimivel
    {
        private string _nome;
        private string _cpf;

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public string Cpf
        {
            get
            {
                return this._cpf;
            }
        }

        public Cliente(string nome, string cpf)
        {
            this._nome = nome;
            this._cpf = cpf;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:\t{0}", this.Nome); 
            Console.WriteLine("CPF:\t{0}", this.Cpf);
        }
    }
}

