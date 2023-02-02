using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace formspresencaa
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Turma { get; set; }
        public string Empresa { get; set; }

        public Aluno(string nome, string turma, string empresa)
        {
            this.Nome = nome;
            this.Turma = turma;
            this.Empresa = empresa;
        }
    }
}

