using System.Text;
internal class Test2
{
    private static void main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de palavras com letras duplicadas: ");  
        var str = Console.ReadLine();
        var strResult = new StringBuilder();

        foreach (var element in str!.ToCharArray())
        {
            if (strResult.Length == 0 || strResult[strResult.Length - 1] != element) strResult.Append(element);
    
        }
        var result = strResult.ToString();
        Console.WriteLine(strResult);
    }
}
