using System;
using System.Collections.Generic;
using System.Text;

namespace Contatos
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data() : this(0, 0, 0)
        {

        }

        public void setData(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public override string ToString()
        {
            return dia.ToString() + "/" + mes.ToString() + "/" + ano.ToString();
        }
    }
}
