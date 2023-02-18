using semana3; 
List<Carro> Ticket = new List<Carro>();  
Estaciomento NovaEntrada = new Estaciomento(); 
Console.WriteLine("Hora de entrada"); 
NovaEntrada.Entrada = DateTime.Parse(Console.ReadLine()); 
Console.WriteLine("Hora de saída");
NovaEntrada.Saida=DateTime.Parse(Console.ReadLine()); 