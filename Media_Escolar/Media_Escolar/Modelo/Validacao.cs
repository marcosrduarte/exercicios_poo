using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Escolar.Modelo
{
    public class Validacao : AbsPropriedades
    {
        public Validacao(String nota1_string, String nota2_string) : base (nota1_string, nota2_string)
        {

        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.nota1 = Convert.ToDouble(nota1_string);
                this.nota2 = Convert.ToDouble(nota2_string);

            }
            catch (FormatException e)
            {

                this.mensagem = "Erro de Conversão ou Caracter Inválido";
            }
        }
    }
}
