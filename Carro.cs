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
         
         public static List<Carro> NovaEntrada {get; set;} 
         public static List<Carro> NovaSaida {get; set;}
 
         
           public Carro(){
            
          NovaEntrada = new List<Carro>(); 
          NovaSaida = new List<Carro>(); 
          
        }
        public Carro(string placa, string modelo, string cor, string marca)
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
    