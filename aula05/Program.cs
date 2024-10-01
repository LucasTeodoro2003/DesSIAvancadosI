public class Program{
    public static void Main(string[] args){
        //Conversao implicita
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine("Conversao implicita de int para double: ");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");


        //Conversao usando o Convert
        double valorDouble = 7.65;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "123";
        int textoConvertidoInt = Convert.ToInt32(textoValor);
        Console.WriteLine($"Double: {valorDouble}, Inteiro: {valorConvertidoInt}, String: {textoValor}, Inteiro: {textoConvertidoInt}");
        

        //Conversao explicita usando o (castring)
        double x = 9.75;
        int a = (int)x;
        Console.WriteLine($"Double: {x}, Inteiro: {a}");


        //Conversao usando Parse
        string textDecimal = "12.75";
        int decimalString = int.Parse(textDecimal);
        Console.WriteLine($"String: {textDecimal}, Double {decimalString}");

        //Conversao usando TryParse
        string textDecimalTry = "12.75";
        int.TryParse(textDecimalTry, out int decimalStringTry);
        Console.WriteLine($"String: {textDecimalTry}, Int: {decimalStringTry}");



        char caractere = 'A';
        int codigoAscii = (int)caractere;
        Console.WriteLine($"Char: {caractere}, Ascii: {codigoAscii}");
    }
}