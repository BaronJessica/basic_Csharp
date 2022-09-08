using exemplo_fundamentos.MODELS;

/*Pessoa pessoa1 = new Pessoa(); //instanciando classe pessoa 
pessoa1.Nome = "Baron"; 
pessoa1.Idade = 29;
pessoa1.Apresentar(); //método abrir e fechar parenteses 

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
string apresentacao = "Olá, seja bem-vindo";
int quantidade = 1;

double altura = 1.80;

Console.WriteLine(apresentacao);
Console.WriteLine("valor da variável quantidade:" + quantidade);

Console.WriteLine("valor da variável altura:" + altura.ToString("0.00"));

-------- IF --------
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque>= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade da compra {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda Realizada.");
}
else{
    Console.WriteLine("Desculpe. Não temos estoque!");
}

Switch case
Console.WriteLine("Digite um letra: ");
string letra = Console.ReadLine();

*if( letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o  || 
    letra == "u");{
        Console.WriteLine("vogal");
    }
else{
    Console.WriteLine("Não é umas vogal");
}

switch(letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u": 
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}*/

Calculadora calc = new Calculadora();
//ctrl k+c comentar todas as linhas
// calc.Somar(10, 30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2,2);

// calc.Potencia(3,3);
// calc.Coseno(30);
// calc.Seno(30);
// calc.Tangente(30);
calc.RaizQuadrada(189);
