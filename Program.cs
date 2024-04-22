string nome;
int idade, altura, peso;

string resposta;
do
{
    Console.WriteLine("Digite o nome da pessoa:");
    nome = Console.ReadLine();

    Console.WriteLine("Digite a idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a altura em centímetros:");
    altura = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o peso em quilogramas:");
    peso = Convert.ToInt32(Console.ReadLine());

    double alturaMetros = altura / 100.0;
    double imc = peso / (alturaMetros * alturaMetros);
    string categoriaIMC;

    if (imc < 18.5)
        categoriaIMC = "Abaixo do peso";
    else if (imc <= 24.9)
        categoriaIMC = "Peso normal";
    else if (imc <= 29.9)
        categoriaIMC = "Sobrepeso (acima do peso desejado)";
    else
        categoriaIMC = "Obesidade";

    string faixaEtaria;

    if (idade < 12)
        faixaEtaria = "Criança";
    else if (idade < 18)
        faixaEtaria = "Adolescente";
    else if (idade < 60)
        faixaEtaria = "Adulto";
    else
        faixaEtaria = "Idoso";

    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade} anos");
    Console.WriteLine($"IMC: {imc:F2} - {categoriaIMC}");
    Console.WriteLine($"Faixa Etária: {faixaEtaria}");

    Console.WriteLine("Deseja gerar um novo relatório para outra pessoa? (s/n)");
    resposta = Console.ReadLine().ToLower();
} while (resposta == "s");

Console.WriteLine("Programa encerrado.");



