using ClassesObjetos;
Produto p1 = new Produto(); // Instaciando um objeto da classe produto 

p1.Nome = "Notebook";
p1.preco = 3500m;

p1.Exibir();

Produto p2 = new Produto();

p2.Nome = "Mouse";
p2.preco = 100m;

p2.Exibir();

// Classes e metodos static 

int resultado = Calculadora.Somar(12, 12);
