using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Gerente : Funcionario
    {
        public Gerente(String a) { 
        
        }
        public override double calcularParticipacaoNosLucros() {

            return getSalario() * 0.5; 
        }
    }
}
