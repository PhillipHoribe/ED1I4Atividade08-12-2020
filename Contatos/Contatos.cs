using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contatos
{
    class Contatos
    {
        private readonly List<Contato> agenda;
        private int index = 0;
        private Contato pesquisado;

        public Contato pesquisados {
             get { return pesquisado; } 
        }
        public List<Contato> Agenda
        {
            get { return agenda; }
        }

        public Contatos()
        {
            this.agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            this.agenda.Add(c);

            return true;
        }

        public Contato pesquisar(Contato c)
        {
            index = agenda.FindIndex(x => x.Email.Equals(c.Email));
            pesquisado = agenda.Where(x => x.Email.Equals(c.Email)).FirstOrDefault();

            return agenda.Where(x => x.Email == c.Email || x.Nome == c.Nome || x.Telefone == c.Telefone).FirstOrDefault();
        }

        public bool remover(Contato c)
        {
            return agenda.Remove(c);
        }
        public bool alterar(Contato c)
        {
            if (index < 0)
                return false;

            int index1 = agenda.IndexOf(c);

            agenda[index] = c;

            return true;
        }
    }
}
