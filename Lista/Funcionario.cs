using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salario { get; set; }

    
        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }


        public void AumentoSalarial (double porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100));

        }

        public override string ToString()
        {
            return "Id: " + Id + "\n" + "Nome: " + Name + "\n" + "Salario: " + Salario;
        }









        }


}
