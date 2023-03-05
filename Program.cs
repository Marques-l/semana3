using semana3; 

string opcao; 
List<Ticket> ticket = new List<Ticket>();
Ticket ticket1 = new Ticket(); 
Carro.Carros1.Add(new Carro ("1","Hatch", "Vermelho", "Mercedez")); 
Carro.Carros1.Add(new Carro ("2","Conversível", "Amarelo", "Toyota"));
Carro.Carros1.Add(new Carro ("3","Hatch", "Azul", "Mercedez"));
  
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
Carro.Carros1.Add(novoCarro); 
}
else if(opcao =="2") { 

ObterCarro();
}
else if (opcao=="3"){

 GerarTicket(); 
}

else if (opcao=="4"){
Historico(); 
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
             
           for(int i = 0; i<Carro.Carros1.Count; i++) 
        {
           Console.WriteLine("Placa--------Cor");
           Console.WriteLine(Carro.Carros1[i].ResumoCliente()); 
        
        }
      
        
   }
   void ObterCarro(){
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId=null;
    foreach(var id in Carro.Carros1) {
      if (id.Placa==placa){
      carroId = id;  
        Console.WriteLine("Hora de entrada");  
      
      ticket1.Entrada = DateTime.Parse(Console.ReadLine()); 
      ticket1.Ativo = true; 
      Console.WriteLine("Seu Ticket foi criado"); 
      break; 
      }
     
    }
   if (carroId==null) {
    Console.WriteLine("Carro não cadastrado, cadastre o carro."); 
    ticket1.Ativo=false; 
   }
   
   }
   void GerarTicket(){
    if (ObterCarro!=null) {
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId=null;
    foreach(var id in Carro.Carros1) {
      if (id.Placa==placa){
      carroId = id; 
    Console.WriteLine("Hora de saída");
    
    ticket1.Saida=DateTime.Now; 
    
    Console.WriteLine(ticket1.CalcularTempo()); 
    Console.WriteLine(ticket1.CalcularValor());
    break;
      }
    } 
    
    }
     
   }
   void Historico(){
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId=null;
    if (carroId==null) {
    Console.WriteLine("Carro não cadastrado, cadastre o carro."); 
   }
   foreach (var ins in carroId.NovaEntrada){
    Console.WriteLine($"Histórico de entrada {ins.NovaEntrada}"); 
   
   }

   foreach (var outs in carroId.NovaSaida){
    Console.WriteLine($"Histórico de saída:{outs.NovaSaida}"); 
     Console.WriteLine($"{ticket1.Valor}"); 
    Console.WriteLine($"{ticket1.Tempo}"); 
   }
   
   }