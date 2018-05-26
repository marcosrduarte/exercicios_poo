using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa.Modelo
{
    public class Validacao : AbsPropriedades
    {
        public Validacao(String vel_via_string, String vel_reg_string, String multa_ref_string ) : base (vel_via_string, vel_reg_string, multa_ref_string)
        {

        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.vel_via = Double.Parse(vel_via_string);
                this.vel_reg = Double.Parse(vel_reg_string);
                this.multa_ref = Double.Parse(multa_ref_string);
            }
            catch (FormatException e)
            {

                this.mensagem = "Erro de Conversão";
            }
            
        }
    }
}
