using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Secretaria : Funcionario
    {
        
        public override double calcularParticipacaoNosLucros() {
            return getSalario() * 0.2;
        }
    }
}
