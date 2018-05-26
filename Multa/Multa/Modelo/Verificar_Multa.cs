using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multa.Modelo
{
    public class Verificar_Multa : AbsPropriedades
    {
        public Verificar_Multa(Double vel_via, Double vel_reg, Double multa_ref) : base (vel_via, vel_reg, multa_ref)
        {

        }

        public override void Executar()
        {
            this.multa = (this.vel_reg - this.vel_via);
            this.multa = (this.multa / this.vel_via);
            this.multa = this.multa * 100;

            if ((this.multa >= 1) && (this.multa < 10))
            {
                this.resposta = "Valor da multa = R$ " + this.multa_ref.ToString("N2");
            }
            else
            {
                if (this.multa <= 0)
                {
                    this.resposta = "Velocidade abaixo do limite\nVeículo não multado";
                }
                else
                {
                    this.resposta = "Velocidade acima de 10% do limite\n" + "Valor da multa = R$ " + (this.multa_ref * 1.1).ToString("N2") + "\nAcréscimo de 10% sobre \no valor de referência";

                }
            }
        }
    }
}
