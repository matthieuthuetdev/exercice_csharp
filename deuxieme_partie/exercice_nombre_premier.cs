namespace demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool premier;
            int nombre;
            premier = true;
            Console.WriteLine("saisisez un nombre positif :");
            nombre = int.Parse(Console.ReadLine());
            for(int i = 2; i < nombre - 1; i++)
            {
                if ((nombre % i) == 0)
                    premier = false;
            }
            if(premier)
            {
                Console.WriteLine("nombre premier");
            }
            else
            {
                Console.WriteLine("nombre non premier");
            }
        }
    }
}