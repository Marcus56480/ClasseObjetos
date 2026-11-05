using ClassesObjetos;
Produto p1 = new Produto(); // Instaciando um objeto da classe produto 

p1.Nome = "Notebook";
// p1.preco = 3500m;
p1.alterarPreco(3500m);

p1.Exibir();

Produto p2 = new Produto();

p2.Nome = "Mouse";
//p2.preco = 100m;
p2.alterarPreco(100m);

p2.Exibir();

// Classes e metodos static 

int resultado = Calculadora.Somar(12, 12);
Console.WriteLine($"Resultado: {resultado}");

// Utilizando a classe estatica
// Conta.Depositar(300m);

Conta conta_Corrente = new Conta();
Conta conta_Poupanca = new Conta();

conta_Corrente.Depositar(100);
conta_Poupanca.Depositar(50);

Console.WriteLine(DateTime.Now);

Pessoa p = new Pessoa();
Console.WriteLine($"Nome: {p.Nome} - Idade: {p.Idade}");

Pessoa pessoa = new Pessoa("Marcus", 18);
Console.WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade}");
