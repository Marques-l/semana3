using semana3; 
string opcao; 
List<Carro> Ticket = new List<Carro>();  
 Ticket NovaEntrada = new Ticket();
 Carro NovoCarro = new Carro(); 
do{
Console.WriteLine("1-Cadastrar carro");
Console.WriteLine("2-Marcar entrada");
Console.WriteLine("3-Marcar saída");
Console.WriteLine("4-Consultar histórico");
Console.WriteLine("5-sair");
opcao = Console.ReadLine(); 

if (opcao=="1"){
 Console.WriteLine("Insira a placa do veículo"); 
 NovoCarro.Placa = Console.ReadLine(); 
 Console.WriteLine("Insira o modelo do veículo"); 
 NovoCarro.Modelo = Console.ReadLine(); 
 Console.WriteLine("Insira a cor do veículo"); 
 NovoCarro.Cor = Console.ReadLine(); 
Console.WriteLine("Insira a marca do veículo"); 
 NovoCarro.Marca = Console.ReadLine(); 
}
if(opcao =="2") { 
Console.WriteLine("Hora de entrada"); 
NovaEntrada.Entrada = DateTime.Parse(Console.ReadLine()); 
}
if (opcao=="3"){
Console.WriteLine("Hora de saída");
NovaEntrada.Saida=DateTime.Parse(Console.ReadLine()); 
}

if (opcao=="4"){

}

if (opcao=="5"){

}
} while (opcao!="3"); 
Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine(); 