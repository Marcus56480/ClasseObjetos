namespace ClassesObjetos
{
    public class Pessoa 
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            Nome = "Não Informado";
            Idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}