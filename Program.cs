﻿using semana3; 
List<Carro> carros = new List<Carro>();
string opcao; 
Ticket Entrada = new Ticket();
carros.Add(new Carro ("1","Hatch", "Vermelho", "Mercedez")); 
carros.Add(new Carro ("2","Conversível", "Amarelo", "Toyota"));
carros.Add(new Carro ("3","Hatch", "Azul", "Mercedez"));
  
  do {
Console.WriteLine("1-Cadastrar carro");
Console.WriteLine("2-Marcar entrada");
Console.WriteLine("3-Marcar saída");
Console.WriteLine("4-Consultar histórico");
Console.WriteLine("5-sair");
Console.WriteLine("6-Exibir carros");
opcao = Console.ReadLine(); 

if (opcao=="1"){
 Carro novoCarro = CadastrarCarro(); 
carros.Add(novoCarro); 
}
else if(opcao =="2") { 

ObterCarro();
}
else if (opcao=="3"){

 GerarTicket(); 
}

else if (opcao=="4"){

}

else if (opcao=="6") {
  ExibirCarro(); 
}
Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine();
} while (opcao!="5"); 


Carro CadastrarCarro() {
        Carro carro = new Carro();
        Console.WriteLine("Insira a placa do veículo"); 
        carro.Placa = Console.ReadLine(); 
        Console.WriteLine("Insira o modelo do veículo"); 
        carro.Modelo = Console.ReadLine(); 
        Console.WriteLine("Insira a cor do veículo"); 
        carro.Cor = Console.ReadLine(); 
        Console.WriteLine("Insira a marca do veículo"); 
        carro.Marca = Console.ReadLine();
            return carro; 
    }
  
    void ExibirCarro(){
             
           for(int i = 0; i<carros.Count; i++) 
        {
           Console.WriteLine("Placa--------Cor");
           Console.WriteLine(carros[i].ResumoCliente()); 
        
        }
      
        
   }
   void ObterCarro(){
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId;
    foreach(var id in carros) {
      if (id.Placa==placa){
      carroId = id;  
       Console.WriteLine("Hora de entrada");  
      Entrada.Entrada = DateTime.Parse(Console.ReadLine()); 
      Entrada.Ativo = true; 
      break; 
      }
        
    }
   
   }
   void GerarTicket(){
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId;
    foreach(var id in carros) {
      if (id.Placa==placa){
      carroId = id; 
    Console.WriteLine("Hora de saída");
    Entrada.Saida=DateTime.Now; 
    
    Console.WriteLine(Entrada.CalcularTempo()); 
    Console.WriteLine(Entrada.CalcularValor());
    break;
      }

    }

   }