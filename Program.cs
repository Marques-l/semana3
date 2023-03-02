using semana3; 
string opcao; 
 Ticket NovaEntrada = new Ticket();

  void Menu() { 
  do{
Console.WriteLine("1-Cadastrar carro");
Console.WriteLine("2-Marcar entrada");
Console.WriteLine("3-Marcar saída");
Console.WriteLine("4-Consultar histórico");
Console.WriteLine("5-sair");
opcao = Console.ReadLine(); 

if (opcao=="1"){
 Carro novoCarro =CadastrarCarro(); 
 
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


} while (opcao!="5"); 

Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine();
}
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
  

Menu(); 