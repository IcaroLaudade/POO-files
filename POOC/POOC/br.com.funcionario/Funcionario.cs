using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Funcionario
    {
        private double salario;
        public double getSalario() {
            return this.salario;
        }
        public void setSalario(double salario) {
            this.salario = salario;
        }
        public virtual double calcularParticipacaoNosLucros() {
            return 0;
        }
    }
}
