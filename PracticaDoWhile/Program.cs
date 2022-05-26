using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado = 0M;
            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplicacion");

                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }
            while ((opcion < 1) || (opcion > 2));

            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.ReadKey();

            while ((opcion < 1) || (opcion > 2)) ;
            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());
            Console.ReadKey();

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                case 2:
                    resultado = num1 - num2;
                    break;

                case 3:
                    if (num2 !=0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no es valido.");
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    resultado = num1 * num2;
                    break;
            }
            Console.WriteLine("El resultado es: {0}", resultado);
            Console.ReadKey();
        }
    }
}
