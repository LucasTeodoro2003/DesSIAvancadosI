// List<int> numeros = new List<int> { 10, 5, 3, 9, 2, 7 };
// numeros.ForEach(n => Console.Write($"Os numeros são: {n}\n"));


// List<int> numeros = new List<int> { 10, 5, 3, 9, 2, 7 };
// var filtrar = numeros.Where(n => n > 5).ToList();
// filtrar.ForEach(f => Console.Write($"Os numeros são: {f}\n"));

// List<int> numeros = new List<int> { 10, 5, 3, 9, 2, 7 };
// var numerosOrdenados = numeros.OrderBy(n => n).ToList();
// numerosOrdenados.ForEach(n => Console.Write($"Os numeros são: {n}\n"));

// List<int> numeros = new List<int> { 10, 5, 3, 9, 2, 7 };
// var somarTudo = numeros.Sum();
// Console.Write($"O total é: {somarTudo}\n");


// public delegate void Operacao(int x, int y);
// public class Calculadora {
//     public void Somar(int x, int y) {
//         Console.WriteLine($"Soma: {x + y}");
//     }
//     public void Subtrair(int x, int y) {
//         Console.WriteLine($"Subtração: {x - y}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculadora calc = new Calculadora();
//         Operacao operacao = new Operacao(calc.Somar);
//         operacao(5, 3);
//         operacao += calc.Subtrair;
//         Console.WriteLine("Calculando:");
//         operacao(5, 3);
//     }
// }


// public delegate void Operacao(int x, int y);
// public class Calculadora {
//     public void Somar(int x, int y) {
//         Console.WriteLine($"Soma: {x + y}");
//     }
//     public void Subtrair(int x, int y) {
//         Console.WriteLine($"Subtração: {x - y}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculadora calc = new Calculadora();
//         Operacao operacao = calc.Somar;
//         operacao += calc.Subtrair;
//         Console.WriteLine("Calculando:");
//         operacao(5, 3);
//     }
// }


// public class Operacoes { //Delegates com Action<T> e Func<T, TResult>
//     public void MostrarMensagem(string mensagem) {
//         Console.WriteLine(mensagem);
//     }
//     public int Somar(int a, int b) {
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Operacoes op = new Operacoes();
//         Action<string> exibirMensagem = op.MostrarMensagem;
//         exibirMensagem("Lucas!");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Operacoes somar = new Operacoes();
//         Func<int, int, int> somarNumeros = somar.Somar;
//         int resultado = somarNumeros(5, 3);
//         Console.WriteLine($"Resultado da soma: {resultado}");
//     }
// }

// List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
// numerosPares.ForEach(n => Console.Write($"Numeros Pares: {n}\n"));

// List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var somarNumeros = numeros.Sum(n => n);
// Console.WriteLine($"Numeros Somados: {somarNumeros}");

List<int> numeros = new List<int> { 2, 4, 6, 8, 10 };
numeros.ForEach(n => Console.WriteLine($"Numero Multiplicado {n} - Valor total: {n*2}"));