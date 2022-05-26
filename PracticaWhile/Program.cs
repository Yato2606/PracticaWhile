using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaWhile
{
    internal class Program
{
    static void Main(string[] args)
    {
        string contraseña1, contraseña2 = " ";
        Console.Write("Escribe tu contraseña: ");
        contraseña1 = Console.ReadLine();
        Console.ReadKey();

        while (contraseña1 != contraseña2)
        {
            Console.Write("Confirma tu contraseña: ");
            contraseña2 = Console.ReadLine();
            Console.ReadKey();
        }
        Console.WriteLine("!Contraseña Guardada!");
        Console.ReadKey();
    }
}
}
