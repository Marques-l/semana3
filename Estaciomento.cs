using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana3
{
    public class Estaciomento 
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida  { get; set; }
        public bool Ativo { get; set; }
        public TimeSpan Tempo; 
        public double Valor; 
    public void CalcualarTempo (){
      if (Ativo){ 
       Tempo = Entrada - Saida; 
       }
    }
    public void CalcualarValor(){
      Valor = Tempo.TotalMinutes *0.99; 
    }
    }
}