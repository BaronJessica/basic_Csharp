namespace exemplo_fundamentos.MODELS
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            //Console.WriteLine($"Olá, meu nome é" + $" {Nome} e tenho {Idade} anos");
            Console.WriteLine($"Olá, meu nome é {Name} \n e tenho {Idade} anos");
        }
    }
}