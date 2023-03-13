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
               
        public Ticket(){ // Tentando pelo construtor
           Entrada = DateTime.Now; 
           Ativo = true; 
      }
      public Ticket(DateTime now, bool ativo){
           
      }

    public double CalcularTempo (){ // Colocando como double, como return o tempo total em minutos
    
       var tempo = Saida - Entrada;  
   
       return tempo.TotalMinutes; 
    
    }

    public double CalcularValor(){
   
      return CalcularTempo() * 0.09; 
    }
    
    public void FecharTicket(){ // Agora ele retorna os valores de interesse direto na classe 
      Saida = DateTime.Now; 
     Console.WriteLine($"O carro ficou estacionado{CalcularTempo()} e o valor a ser pago é {CalcularValor()}R$");
    }
 
}

}