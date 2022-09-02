// See https://aka.ms/new-console-template for more information
namespace ejercicio
{
    public class program1
    {

        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;


            int suma;
            double media;
            int product;
            Console.WriteLine("Ingrsee el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrsee el primer numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrsee el primer numero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrsee el primer numero");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrsee el primer numero");
            product = num1 * num2 * num3 * num4;
            suma = num1 + num2 + num3 + num4;
            media = suma / 4;
            Console.WriteLine($"el resultado de la suma es : {suma} el resultado de la media es : {media} el resultado del producto es : {product}");





        }
    }
}






