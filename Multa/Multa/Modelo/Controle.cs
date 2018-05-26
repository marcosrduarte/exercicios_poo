using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa.Modelo
{
    public class Controle : AbsPropriedades 
    {
        public Controle(String vel_via_string, String vel_reg_string, String multa_ref_string) : base (vel_via_string, vel_reg_string, multa_ref_string)
        {

        }

        public override void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.vel_via_string, this.vel_reg_string, this.multa_ref_string);

            if (validacao.mensagem.Equals(""))
            {
                Verificar_Multa verificar_Multa = new Verificar_Multa(validacao.vel_via, validacao.vel_reg, validacao.multa_ref);
                this.resposta = verificar_Multa.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            
        }
    }
}
