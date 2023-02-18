using semana3; 
string opcao; 
List<Carro> Ticket = new List<Carro>();  
do{
Console.WriteLine("1-Cadastrar carro");
Console.WriteLine("2-Marcar entrada");
Console.WriteLine("3-Marcar saída");
Console.WriteLine("4-Consultar histórico");
Console.WriteLine("5-sair");
opcao = Console.ReadLine(); 
} while (opcao!="3"); 
Estaciomento NovaEntrada = new Estaciomento(); 
Console.WriteLine("Hora de entrada"); 
NovaEntrada.Entrada = DateTime.Parse(Console.ReadLine()); 
Console.WriteLine("Hora de saída");
NovaEntrada.Saida=DateTime.Parse(Console.ReadLine()); 