using semana3; 

string opcao; 



Carro Novo = new Carro(); 
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
Carro NovoCarro = CadastrarCarro(); 
Carro.Carros1.Add(NovoCarro); 
}
else if(opcao =="2") { 

ObterCarro();
GerarTicket(); 
}
else if (opcao=="3"){


 FecharTicket(); 
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
       Console.WriteLine("Carro encontrado, tecle enter para continuar");
       Console.ReadLine();
       break;  
    }
    if (carroId==null) {
      Console.WriteLine("O carro não está cadastrado, por favor, cadastre o carro");
      break; 
    }
   }
  }
      
   
   void GerarTicket(){
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId=null;
    foreach(var id in Carro.Carros1) {
      if (id.Placa==placa){
       carroId = id;  
       Console.WriteLine("Tecle enter para gerar hora de entrada");
       Console.ReadLine(); 
       Ticket ticket1 = new Ticket(); 
       if (ticket1.Ativo==true) {
      Console.WriteLine("O carro já possui um Ticket ativo"); }
      if (ticket1.Ativo==false) {
      ticket1.Entrada=DateTime.Now; 
      ticket1.Ativo =  true; 
      carroId.NovaEntrada.Add(ticket1); 
      Console.WriteLine("Seu Ticket foi criado");
      
    }
      }
       }
       }
    
    

     void FecharTicket(){
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    Carro carroId=null;
    foreach(var id in Carro.Carros1) {
      if (id.Placa==placa){
      carroId = id; 
      
    Console.WriteLine("Tecle enter para gerar hora de saída");
    Ticket ticket2 = new Ticket();
    
    ticket2.Saida=DateTime.Now; 
    
    Console.WriteLine(ticket2.CalcularTempo()); 
    Console.WriteLine(ticket2.CalcularValor());
    carroId.NovaSaida.Add(ticket2);
    break;
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
   foreach (Ticket ticket1 in carroId.NovaEntrada){
    Console.WriteLine($"Histórico de entrada {ticket1.Entrada}"); 
   
   }

   foreach (Ticket ticket2 in carroId.NovaSaida){
     
    Console.WriteLine($"Histórico de saída:{ticket2.Saida}"); 
     Console.WriteLine($"{ticket2.Valor}"); 
    Console.WriteLine($"{ticket2.Tempo}"); 
    }
   
   
   }
   