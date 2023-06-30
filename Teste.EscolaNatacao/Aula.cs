using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.EscolaNatacao
{
    public class Aula
    {
        public DateTime InicioAula { get; set; }
        public Aluno Aluno { get; set; }

        public Professor Professor { get; set; }
        public string Hora { get; set; }
    }
}
