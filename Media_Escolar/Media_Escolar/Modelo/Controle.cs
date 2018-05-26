using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Escolar.Modelo
{
    public class Controle : AbsPropriedades
    {
        public Controle(String nota1_string, String nota2_string) : base(nota1_string, nota2_string)
        {

        }   

        public override void Executar()
        {
                this.mensagem = "";

                 AbsPropriedades validacao = new Validacao(this.nota1_string, this.nota2_string);
            
                if (validacao.mensagem.Equals(""))
                {
                    AbsPropriedades calculo_media = new Calculo_Media(validacao.nota1, validacao.nota2);
                    this.resposta = calculo_media.ToString();
                }
                else
                {
                    this.mensagem = validacao.mensagem;
                }
            

        }

    }
}
