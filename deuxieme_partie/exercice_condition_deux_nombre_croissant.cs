 namespace demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("saisisez la valeure a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("saisisez la valeure b : ");
            b = int.Parse(Console.ReadLine());

            if (a > b )
            {
                Console.WriteLine("la valeure a est plus grand que la valeure b ");
            }else if(a < b)
            {
                Console.WriteLine("la valeure a est plus petite que la valeure b");
            }
            else
            {
                Console.WriteLine("les deux valeure sont égale !");
            }
        }

    }
}