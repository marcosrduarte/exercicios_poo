using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa.Modelo
{
    public abstract class AbsPropriedades
    {
        public Double vel_via;
        public Double vel_reg;
        public Double multa_ref;

        public String vel_via_string;
        public String vel_reg_string;
        public String multa_ref_string;

        public String mensagem;
        public String resposta;

        public Double multa;

        public AbsPropriedades(Double vel_via, Double vel_reg, Double multa_ref)
        {
            this.vel_via = vel_via;
            this.vel_reg = vel_reg;
            this.multa_ref = multa_ref;
            Executar();
        }

        public AbsPropriedades(String vel_via_string, String vel_reg_string, String Multa_ref_string)
        {
            this.vel_via_string = vel_via_string;
            this.vel_reg_string = vel_reg_string;
            this.multa_ref_string = Multa_ref_string;
            Executar();
        }

        public virtual void Executar()
        {

        }

        public override string ToString()
        {
            return this.resposta;
        }

    }
}
