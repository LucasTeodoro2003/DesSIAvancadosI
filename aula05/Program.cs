public class Program{
    public static void Main(string[] args){
        //Conversao implicita
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversao implicita de int para double: ");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");


        //Conversao eusando o Convert
        double valorDouble = 7.45;
        int valorTeste = 8;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);
        Console.WriteLine($"Double: {valorDouble}, Inteiro: {valorConvertidoInt}, String: {textoValor}, Inteiro: {textoConvertidoInt}");
        Console.WriteLine($"{(int)valorDouble}, {(double)valorTeste}");
    }
}