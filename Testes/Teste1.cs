internal class Test1
{
    public static int soma(int num)
    {
            if (num <=1)
                return num;
            return num + soma (num - 1);
    }
    private static void Main(string[] args)
    {
        int num;
        int cont = 1;
       Console.Write("Digite um número: ");
       num = Convert.ToInt32(Console.ReadLine());

       while(cont <= num)
       {
        Console.WriteLine("{0}", cont);
        cont++;
       }
       Console.WriteLine("A soma de 1 até {0} é {1}", num, soma(num));
    }
}
