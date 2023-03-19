using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3
{
    public class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public static List<Carro> Carros1 = new List<Carro>(); 
         public List<Ticket> Tickets {get; set;} // Essa vai ser a lista que provavelmente vai ser usada
        
           public Carro(){
            Tickets = new List<Ticket>(); 
          
        }
        public Carro(string placa, string modelo, string cor, string marca) :this()
        {
            Placa = placa; 
            Modelo = modelo; 
            Cor = cor; 
            Marca = marca; 
        } 
       
        public string ResumoCliente(){
            return $"{Placa} --- {Cor}"; 
        }
    }
}
    