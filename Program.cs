// See https://aka.ms/new-console-template for more information
int valor;

Console.Write("Digite um número: ");
valor = int.Parse(Console.ReadLine());

if(valor % 2 == 0) {
    Console.WriteLine("Par");
}
else {
    Console.WriteLine("Ímpar");
}
