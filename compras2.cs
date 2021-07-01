using System;
using System.Collections;


{
public class Compras
{
    private Compra_Atributos _compra_atributos;
    private Carrinho _carrinho;
    private Estoque _estoque;




        public Compras(Carrinho carrinho_, Estoque estoque_, Cliente cliente_ )
        {
            this._compra_atributos = new Compra_Atributos(cliente_);
            this._carrinho = carrinho_;
            this._estoque = estoque_;      
        }



        //========================================
        //========================================
        //========================================
        public bool Conferir_Estoque()
        {
                    
        foreach (var item in _carrinho.Itens)
            {
                var System_Linq_Query = _estoque.Itens.FirstOrDefault(x => x.Key.Nome == item.Key.Nome);   

                if(item.Value > System_Linq_Query.Value)
                {
                    Console.WriteLine("");
                    Console.WriteLine($" Estoque não possui \"{item.Key.Nome}\" suficientes para a compra - [\"{item.Value}\" Unidades no carrinho / \"{System_Linq_Query.Value}\" restantes no estoque] ]");
                    return false;
                }
            
            }
            
            if(_carrinho.Itens.Count <= 0)
            {
                Console.WriteLine($" no carrinho não possui produtos suficientes para a compra - [\"{_carrinho.Itens.Count}\" produtos no carrinho / \"{_estoque.Itens.Count}\" restantes no estoque] ]");
                return false;
            }
        

        return true;
        }


         public void Comprar_Produtos()
        {

            if(!Conferir_Estoque()) return;
        
            Console.WriteLine("=================");
            foreach (var item in _carrinho.Itens)
            {

            var System_Linq_Query = _estoque.Itens.FirstOrDefault(x => x.Key.Nome == item.Key.Nome);             
                
                for (var i = 0; i < item.Value; i++)
                {                        
                    _estoque.Remover(item.Key);                              
                }   

            var RestCount = _estoque.Itens.FirstOrDefault(x => x.Key.Nome == item.Key.Nome);
            Console.WriteLine($"O Produto \"{item.Key.Nome}\" foi adquirido com sucesso! - [\"{item.Value}\" Unidades compradas / \"{RestCount.Value}\" restantes no estoque] ");
                                
           }
        
         //==><===
        _compra_atributos.Adicionar(_carrinho.Itens);
         //==><===
        _carrinho.Limpar();
         //==><===

        Console.WriteLine("==============");

        }

       public void ImprimirRecibo()
       {
         _compra_atributos.ImprimirAtributos(); 
         _compra_atributos.Limpar(); 
       }
       
    
    }
}


