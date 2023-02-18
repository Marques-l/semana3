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
        public string CadastroCarro(){
            return $"{Placa}{Modelo}{Cor}{Marca}"; 
        }
        
       public void CadastrarCarro() {
        List<Carro> CarrosCadastrados = new List<Carro>(); 
        for(int i = 0; i<CarrosCadastrados.Count; i++) 
        {
        Console.WriteLine(CarrosCadastrados[i].CadastroCarro()); 
        }
}
    }
}