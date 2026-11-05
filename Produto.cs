namespace ClassesObjetos
{
    public class Produto
    {
        public string? Nome { get; set; } // Getters e Setters
        public decimal preco { get; private set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - R$ {preco:F2}");
        }

        public void alterarPreco (decimal novoPreco)
        {
            if (novoPreco > 0)
            {
                preco = novoPreco;
            }

            else
            {
                Console.WriteLine("Valor não permitido.");
            }
        }
    }
}