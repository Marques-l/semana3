using semana3; 
List<Carro> carros = new List<Carro>();
string opcao; 
 Ticket NovaEntrada = new Ticket();

  
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
Console.WriteLine("Hora de entrada"); 
NovaEntrada.Entrada = DateTime.Parse(Console.ReadLine()); 
}
else if (opcao=="3"){
Console.WriteLine("Hora de saída");
NovaEntrada.Saida=DateTime.Parse(Console.ReadLine()); 
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
 