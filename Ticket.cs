using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3
{
    public class Ticket 
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida  { get; set; }
        public bool Ativo { get; set; }
        public TimeSpan Tempo; 
        public double Valor; 
       public List<Ticket> NovaEntrada {get; set;} 
       public List<Ticket> NovaSaida {get; set;} 

       public Ticket(){
          NovaEntrada = new List<Ticket>(); 
          NovaSaida = new List<Ticket>(); 
       }

    public TimeSpan CalcularTempo (){
      if (Ativo){ 
       Tempo = Entrada - Saida; 
       }
       else {
        Console.WriteLine("Carro não está estacionado"); 
       }
       return Tempo; 

    }
    public double CalcularValor(){
      Valor = Tempo.TotalMinutes *0.99; 
      return Valor; 
    }
    }
}