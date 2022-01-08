using System;

namespace Operador
{
    class Program
    {
        static void Main(string[] args)
        {
            String usuario;
            Console.WriteLine("Digite seu usuário:");
            usuario = Console.ReadLine().ToUpper();

            if (!(usuario =="ADMINISTRADOR"))
            {
                Console.WriteLine("Atenção, usuário sem poderes adminstrativos. Algumas tarefas serão bloqueadas.");
            }
        }
    }
}
