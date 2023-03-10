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
        public string Placa; 
        
      public Ticket(){
           
      }
      public Ticket(DateTime now, bool ativo){
           
      }

    public TimeSpan CalcularTempo (){
     
       Tempo = Entrada - Saida; 
       
       return Tempo; 

    }
    public double CalcularValor(){
      Valor = Tempo.TotalMinutes *0.09; 
      return Valor; 
    }
    }
}