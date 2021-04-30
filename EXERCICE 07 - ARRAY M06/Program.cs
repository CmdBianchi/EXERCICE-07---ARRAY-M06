using System;
namespace EXERCICE_07___ARRAY_M06 {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            Student[] vect = new Student[10]; //-------> VETOR DE CLASSE

            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i <=n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for(int i =0; i < 10; i++) { 
                if (vect[i] != null) {
                    Console.WriteLine(i + ": "+ vect[i]);
                }
            }
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
