using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade.Modelo
{
    public class Controle : AbsPropriedade
    {
        public Controle(String idade_string) : base (idade_string)
        {

        }

        public override void Executar()
        {
            this.mensagem = "";

            Validacao validacao = new Validacao(idade_string);

            if (validacao.mensagem.Equals(""))
            {
                Verificar_Idade verificar_Idade = new Verificar_Idade(validacao.idade);
                this.resposta = verificar_Idade.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem; 
            }
        }
    }
}
