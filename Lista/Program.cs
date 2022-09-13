using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lista

{
    internal class Program
    {

        static void Main(string[] args)
        {
           

            Console.WriteLine("Quantos funcionarios voce quer registrar ?");
            int x = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add (new Funcionario(id,name,salario));
                Console.WriteLine();
            }

            Console.Write("Digite o ID do Funcionário que terá aumento salarial: ");
            int buscaid = int.Parse(Console.ReadLine());

            Funcionario emp = lista.Find (x => x.Id == buscaid);

            if (emp != null)
            {
                Console.Write("Digite a porcentagem do aumento:");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalarial(percentage);
            }

            else
            {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista Atualizada de Funcionarios: ");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }






         
        }
    }

}
