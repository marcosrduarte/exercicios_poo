using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade.Modelo
{
    public abstract class AbsPropriedade
    {
        public Double idade;
        public String idade_string;
        public String mensagem;
        public String resposta;
        public AbsPropriedade(Double idade)
        {
            this.idade = idade;
            Executar();
        }

        public AbsPropriedade(String idade_string)
        {
            this.idade_string = idade_string;
            Executar();
        }

        public virtual void Executar()
        {

        }

        public override String ToString()
        {
            return this.resposta;
        }
    }
}
