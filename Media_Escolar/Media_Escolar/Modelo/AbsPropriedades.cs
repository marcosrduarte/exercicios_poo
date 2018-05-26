using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Escolar.Modelo
{
    public abstract class AbsPropriedades
    {
        public Double nota1;
        public Double nota2;
        public String nota1_string;
        public String nota2_string;
        public String mensagem;
        public String resposta;
        public String media_string;
        public Double media;
        public AbsPropriedades(Double nota1, Double nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            
            Executar();
        }
        public AbsPropriedades(String nota1_string, String nota2_string)
        {
            this.nota1_string = nota1_string;
            this.nota2_string = nota2_string;
        
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
