using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double salario = double.Parse(Console.ReadLine());
                Func.Funcionario gerente = new Func.Gerente("1");
                Func.Funcionario secret = new Func.Secretaria();
                gerente.setSalario(salario);
                secret.setSalario(salario);
                Console.WriteLine(gerente.calcularParticipacaoNosLucros());
                Console.WriteLine(secret.calcularParticipacaoNosLucros());
                Console.ReadKey();
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            }
    }
}
