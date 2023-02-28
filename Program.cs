using semana3; 
string opcao; 
 Ticket NovaEntrada = new Ticket();
 List<Carro>  NovoCarro = new List<Carro>(); 

  void Menu() { 
  do{
Console.WriteLine("1-Cadastrar carro");
Console.WriteLine("2-Marcar entrada");
Console.WriteLine("3-Marcar saída");
Console.WriteLine("4-Consultar histórico");
Console.WriteLine("5-sair");
opcao = Console.ReadLine(); 

if (opcao=="1"){
 CadastrarCarro(); 
 
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
  ExibirCarro(); 
}


} while (opcao!="5"); 

Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine();
}
void CadastrarCarro() {
        Carro NovoCarro = new Carro();
        Console.WriteLine("Insira a placa do veículo"); 
        NovoCarro.Placa = Console.ReadLine(); 
        Console.WriteLine("Insira o modelo do veículo"); 
        NovoCarro.Modelo = Console.ReadLine(); 
        Console.WriteLine("Insira a cor do veículo"); 
        NovoCarro.Cor = Console.ReadLine(); 
        Console.WriteLine("Insira a marca do veículo"); 
        NovoCarro.Marca = Console.ReadLine();
            
    }
  
void ExibirCarro(){
        Console.WriteLine("Placa ---- Modelo ---- Cor ----- Marca"); 
        for(int i = 0; i<NovoCarro.Count; i++) 
        {
        Console.WriteLine(NovoCarro[i].ResumoCarro()); 
        NovoCarro.Add(NovoCarro[i]);
        }
        }
Menu(); 