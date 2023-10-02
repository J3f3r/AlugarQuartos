using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlugarQuartos
{
    class Estudante
    {
        public string nome { get; set; }
        public string email { get; set; }

        public Estudante(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
        public override string ToString()
        {
            return nome + ", " + email;
        }

    }
}
