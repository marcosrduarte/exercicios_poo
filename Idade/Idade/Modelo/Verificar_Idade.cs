using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade.Modelo
{
    public class Verificar_Idade : AbsPropriedade 
    {
        public Verificar_Idade(Double idade) : base (idade)
        {

        }
        public override void Executar()
        {
            

            if (this.idade >= 60)
            {
                this.resposta = "Idoso";
            }
            else
            {
                if (this.idade <= 17)
                {
                    this.resposta = "criança ou adolescente";
                }
                else
                {
                    this.resposta = "Adulto";
                }
            }
        }
    }
}
