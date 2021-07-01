using System;
using System.Collection;

namespace Aula14
{
    public class Relatorio
    {
        private string _titulo;
        private string _descricao;
        private List<Imprimivel> _itens;

        public string Titulo
        {
            get
            {
                return this._titulo;
            }
        }
 
        public string Descricao
        {
            get
            {
                return this._descricao;
            }
        }

        public Relatorio(string titulo, string descricao)
        {
            this._descricao = descricao;
            this._titulo = titulo;
            this._itens = new List<Imprimivel>();
        }

        public void AdicionarItem(Imprimivel item)
        {
            this._itens.Add(item);
        }

        public void ImprimirRelatorio()
        {
            
            Console.WriteLine("\n===== RELATÓRIO ====");
            Console.WriteLine(this._titulo);
            Console.WriteLine("=================");
            Console.WriteLine(this._descricao);
            Console.WriteLine("========== ITENS ======");
            foreach (var item in _itens)
            {
                item.Imprimir(); 
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("==================");
        }
    }
}
