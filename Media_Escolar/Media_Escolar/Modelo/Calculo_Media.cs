using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Escolar.Modelo
{
    public class Calculo_Media : AbsPropriedades
    {
        public Calculo_Media(Double nota1, Double nota2) : base(nota1, nota2)
        {

        }

        public override void Executar()
        {
            this.media = (nota1 + nota2) / 2;

            if (this.media >= 7)
            {
                this.resposta = this.media.ToString("N2") + " - Aprovado";
            }

            else
            {

                if ((this.media < 7 && this.media >= 5))
                {
                    this.resposta = this.media.ToString("N2") + " - Exame";
                }

                else
                {
                    this.resposta = this.media.ToString("N2") + " - Reprovado";
                }
            }
            
        }

    }

}   

