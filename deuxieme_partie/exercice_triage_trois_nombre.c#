namespace demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int premier_nombre = 0, deuxieme_nombr = 0, troisieme_nombre = 0;

            Console.WriteLine("Saisissez la valeur a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la valeur b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisissez la valeur c : ");
            c = int.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                premier_nombre = a;
            }
            else if (b <= a && b <= c)
            {
                premier_nombre = b;
            }
            else if (c <= a && c <= b)
            {
                premier_nombre = c;
            }

            if ((a <= b && a >= c) || (a <= c && a >= b))
            {
                deuxieme_nombr = a;
            }
            else if ((b <= a && b >= c) || (b <= c && b >= a))
            {
                deuxieme_nombr = b;
            }
            else if ((c <= a && c >= b) || (c <= b && c >= a))
            {
                deuxieme_nombr = c;
            }

            if (a >= b && a >= c)
            {
                troisieme_nombre = a;
            }
            else if (b >= a && b >= c)
            {
                troisieme_nombre = b;
            }
            else if (c >= a && c >= b)
            {
                troisieme_nombre = c;
            }

            Console.WriteLine("Les nombres classés dans l'ordre croissant sont : " + premier_nombre + " " + deuxieme_nombr + " " + troisieme_nombre);
        }
    }
}