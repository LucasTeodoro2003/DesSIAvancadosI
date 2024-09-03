public class Program{
    
    /*
    - O Action<T1, T2>: Representa um método que aceita 16
    parâmetros e não retorna valor (void)
    - Func<T, TResult>: Representa um método que aceita até
    16 parâmetros e retorna um valor do tipo TResult.
    
    */





    public static void MostrarMensagem(string mensagem){
        Console.WriteLine("Mensagem: " + mensagem);
    }

    public static int Somar(int a, int b){
        return a+b;
    }
    public static void Main(string[] args){
        Action<string> action = MostrarMensagem;
        Console.WriteLine("Qual a mensagem?");
        string? mensagemEnviada = Console.ReadLine();
        action(mensagemEnviada);

    
        Func<int, int, int> operacao = Somar;
        Console.WriteLine($"Soma: {operacao(5,3)}");


        Action<int, int> exibirOperacoes = (x,y) => {
            Console.WriteLine("Soma: " + (x + y));
            Console.WriteLine("Multiplicaçao: " + (x*y));
            };

        exibirOperacoes(10,6);

        Func<int, int> calcularQuadrado = (x) => x*x;

        Func<int, int, int> executarOperacoes = (x,y) => {
            return calcularQuadrado(x) + calcularQuadrado(y);
        };
        
        Console.WriteLine("Quadrado de 5 é: " + calcularQuadrado(5));
        Console.WriteLine("Resultado da Operação: " + executarOperacoes(4,6));
    }
}