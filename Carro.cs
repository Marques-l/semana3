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
        List<Ticket> Tickets { get; set; } 
         
           public Carro(){
           
        }
        public Carro(string placa, string modelo, string cor, string marca)
        {
            Placa = placa; 
            Modelo = modelo; 
            Cor = cor; 
            Marca = marca; 
        }
       
   
    }
}
    