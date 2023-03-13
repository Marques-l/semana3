using semana3; 

string opcao; 



Carro.Carros1.Add(new Carro ("1","Hatch", "Vermelho", "Mercedez")); //Inserindo uns itens 
Carro.Carros1.Add(new Carro ("2","Conversível", "Amarelo", "Toyota"));
Carro.Carros1.Add(new Carro ("3","Hatch", "Azul", "Mercedez"));
  
  do {
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

GerarTicket(); // Agora ele só chama GerarTicket 
}
else if (opcao=="3"){

FecharTicket(); 
}

else if (opcao=="4"){
Historico(); 
}

Console.WriteLine("Tecle Enter para continuar"); 
Console.ReadLine();
} while (opcao!="5"); 


void  CadastrarCarro() { // Corrigido 

        Carro carro = new Carro(); // Objeto para o carro
        Console.WriteLine("Insira a placa do veículo"); //Inserindo informações através do ReadLine
        carro.Placa = Console.ReadLine(); 
        Console.WriteLine("Insira o modelo do veículo"); 
        carro.Modelo = Console.ReadLine(); 
        Console.WriteLine("Insira a cor do veículo"); 
        carro.Cor = Console.ReadLine(); 
        Console.WriteLine("Insira a marca do veículo"); 
        carro.Marca = Console.ReadLine();
        Carro.Carros1.Add(carro);  // Adicionando na lista estática na classe carro 
        
           
    }
  
  
  Carro ObterCarro(string placa){ // Agora ele só identifica se o carro tá cadastrado, e não é chamado no menu 
       foreach(var carro in Carro.Carros1) { // mas sim como uma verificação do GerarTicket
      if (placa == carro.Placa){
        return carro; 
    }
    }
    return null; 
   }
        
   
   void GerarTicket(){ // Já corrigido 
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    var carro = ObterCarro(placa); 
    if (carro == null) {
      Console.WriteLine("Carro não cadastrado, por favor faça o cadastro"); 
      return; 
    }
    foreach (var ticket in carro.Tickets)
    {
      if (ticket.Ativo == true) {
        Console.WriteLine("O carro já possui Ticket ativo"); 
        return; 
      }
    }
    Ticket TicketNovo = new Ticket(); //Criando um objeto para usar a classe Ticket 
    carro.Tickets.Add(TicketNovo); // TicketNovo pelo construtor já tem todas as informações necessárias
    Console.WriteLine("O seu Ticket foi criado"); // Avisa ao usuário que o Ticket foi criado
   }
    
    

    void FecharTicket(){ 
    Console.WriteLine("Insira a placa do veículo"); 
    string placa = Console.ReadLine(); 
    var carro = ObterCarro(placa); 
    if (carro == null) {
      Console.WriteLine("Carro não cadastrado, por favor faça o cadastro"); 
      return; 
    }
    Ticket ticketAberto = null; // Null por padrão
    foreach (var ticket in carro.Tickets)
    {
      if (ticket.Ativo == true) 
      {
        ticketAberto = ticket;  
      }
   } 
   
   if (ticketAberto == null) {
    Console.WriteLine("Carro não possui Ticket aberto"); 
    return; 
   }
   ticketAberto.FecharTicket(); // Acho que tem que chamar o que a gente fez na classe Ticket aqui 
  }
   

   void Historico(){
    Console.WriteLine("Insira a placa do veículo");  // De novo verificando a placa e vendo se o carro existe 
    string placa = Console.ReadLine(); 
    var carro = ObterCarro(placa); 
    if (carro == null) {
      Console.WriteLine("Carro não cadastrado, por favor faça o cadastro"); 
      return; 
    }
   Console.WriteLine("Entrada----------                        Saída                        ----------                        Ativo                        ----------                        Valor"); 
   foreach (var ticket in carro.Tickets)
   {
    Console.WriteLine($"{ticket.Entrada}----{ticket.Saida}----{ticket.Ativo.ToString()}----{ticket.CalcularValor()} R$"); 
   }
   }
   