int valor;

Console.Write("Digite um número: ");
valor = int.Parse(Console.ReadLine());

if(valor % 2 == 0) {
    Console.WriteLine("Par");
}
else {
    Console.WriteLine("Ímpar");
}

Console.WriteLine("Versão da aplicação: 1.0");
