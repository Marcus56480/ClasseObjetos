namespace ClassesObjetos
{
    public class Produto
    {
        public string? Nome { get; set; } // Getters e Setters
        public decimal preco { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - R$ {preco:F2}");
        }
    }
}