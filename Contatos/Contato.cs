using System;
using System.Collections.Generic;
using System.Text;

namespace Contatos
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtnasc;

        public string Email {
            get { return email; }
            set { email = value; }
        }
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone {
            get { return telefone; }
            set { telefone = value; }
        }
        public Data Dtnasc {
            get { return dtnasc; }
            set { dtnasc = value; }
        }

        public Contato(string email, string nome, string telefone, Data dtNascimento)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtnasc = dtNascimento;
        }

        public Contato() : this(String.Empty, String.Empty, String.Empty, new Data())
        {

        }
        public override string ToString()
        {
            return "Email:" + email + "\nNome:" + nome + "\nTelefone" + telefone + "Data de Nascimento" + dtnasc.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.email.Equals(((Contato)obj).Email);
        }
    }
}
