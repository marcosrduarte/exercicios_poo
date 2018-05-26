using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade.Modelo
{
   public class Validacao : AbsPropriedade
    {
        public Validacao(String idade_string) : base (idade_string)
        {

        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.idade = Double.Parse(idade_string);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de Conversão";
                
            }
        }
    }
}
