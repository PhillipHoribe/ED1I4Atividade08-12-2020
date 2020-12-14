using System;
using System.Text.RegularExpressions;

namespace Contatos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao, email;

            Contatos listContatos = new Contatos();

            do
            {
                Console.WriteLine();
                Console.WriteLine("0-Sair");
                Console.WriteLine("1-Adicionar Contato");
                Console.WriteLine("2-Pesquisar Contato");
                Console.WriteLine("3-Alterar Contato");
                Console.WriteLine("4-Remover Contato");
                Console.WriteLine("5-Listar Contato");
                Console.WriteLine();
                Console.Write("Selecione uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        listContatos.adicionar(getDados());
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Email:");
                        email = Console.ReadLine();
                        Contato contato = new Contato();
                        contato.Email = email;
                        Contato pesquisar = listContatos.pesquisar(contato);
                        Console.Clear();
                        if (pesquisar == null)
                        {
                            Console.WriteLine("not found");
                        }
                        else
                        {
                            Console.WriteLine("Nome:" + pesquisar.Nome);
                            Console.WriteLine("Email:" + pesquisar.Email);
                            Console.WriteLine("Telefone:" + pesquisar.Telefone);
                            Console.WriteLine("Data Nascimento:" + pesquisar.Dtnasc.ToString());
                        }

                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Write("Email:");
                        email = Console.ReadLine();
                        Contato contato2 = new Contato();
                        contato2.Email = email;
                        Contato pesquisar2 = listContatos.pesquisar(contato2);
                        if (contato2.Email != null)
                        {
                            listContatos.alterar(getDados());
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("not found");
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Email:");
                        email = Console.ReadLine();
                        Contato contatos = new Contato();
                        contatos.Email = email;
                        Contato pesquisar1 = listContatos.pesquisar(contatos);
                        if (listContatos.remover(contatos))
                        {
                            Console.Clear();
                            Console.WriteLine("Sucess");
                        }
                        else
                        {
                            Console.WriteLine("error user: " + contatos.Email + " not found");
                        }

                        break;
                    case "5":
                        Console.Clear();

                        if (listContatos.Agenda.Count <= 0)
                        {
                            Console.WriteLine("Empty");
                        }
                        else
                        {
                            foreach (var c in listContatos.Agenda)
                            {
                                Console.WriteLine("Nome:" + c.Nome);
                                Console.WriteLine("Email:" + c.Email);
                                Console.WriteLine("Telefone:" + c.Telefone);
                                Console.WriteLine("Data Nascimento:" + c.Dtnasc.ToString());

                                Console.WriteLine();
                            }
                        }

                        Console.WriteLine();
                        break;
                }

            } while (!opcao.Equals("0"));


        }

        public static Contato getDados()
        {
            string nome, email, telefone, dtNascimento;
            Console.Clear();
            Nome:
            Console.Write("Nome:");
            nome = Console.ReadLine();
                if (String.IsNullOrEmpty(nome))
                    goto Nome;
            Email:
            Console.WriteLine();
            Console.Write("Email:");
            email = Console.ReadLine();
                if (String.IsNullOrEmpty(email))
                    goto Email;
            Telefone:
            Console.WriteLine();
            Console.Write("Telefone:");
            telefone = Console.ReadLine();
                if (String.IsNullOrEmpty(telefone))
                    goto Telefone;
            dtNascimento:
            Console.WriteLine();
            Console.Write("data:(dd/mm/yyy)");
            dtNascimento = Console.ReadLine();
                if (String.IsNullOrEmpty(dtNascimento))
                    goto dtNascimento;
            Data data = new Data();
            return new Contato(email, nome, telefone, data);
        }
    }
}

