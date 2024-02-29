using System;
using CP1_ClassLibrary.Models;
using System.Collections.Generic;

namespace CP1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            List<Professor> listaProfessores = new List<Professor>();
            List<Coordenador> listaCoordenadores = new List<Coordenador>();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();



            while (true)
            {
                Console.WriteLine("Que tipo de usuário deseja cadastrar?");
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Professor");
                Console.WriteLine("3 - Coordenador");
                Console.WriteLine("4 - Cadastrar Funcionário");
                Console.WriteLine("5 - Consultar usuários cadastrados");
                Console.WriteLine("6 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 6) break;

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno(listaAlunos);
                        break;

                    case 2:
                        CadastrarProfessor(listaProfessores);
                        break;

                    case 3:
                        CadastrarCoordenador(listaCoordenadores);
                        break;

                    case 4:
                        CadastrarFuncionario(listaFuncionarios);
                        break;

                    case 5:
                        ExibirUsuariosCadastrados(listaAlunos, listaProfessores, listaCoordenadores, listaFuncionarios);
                        break;

                  

                }
            }
        }

        private static void CadastrarAluno(List<Aluno> listaAlunos)
        {
            Console.WriteLine("Iniciando cadastro de um novo aluno");

            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do aluno:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o curso do aluno:");
            string curso = Console.ReadLine();

            Aluno aluno = new Aluno(curso, nome, cpf);
            listaAlunos.Add(aluno);
            Console.WriteLine($"Aluno {nome} cadastrado com sucesso!");
        }

        private static void CadastrarProfessor(List<Professor> listaProfessores)
        {
            Console.WriteLine("Iniciando cadastro de um novo professor");

            Console.WriteLine("Digite o nome do professor:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do professor:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o tempo de contrato do professor:");
            string tempoContrato = Console.ReadLine();

            Console.WriteLine("Digite o cargo do professor:");
            string cargo = Console.ReadLine();

            Console.WriteLine("Quantas disciplinas o professor ministra?");
            int qtdDisciplinas = Convert.ToInt32(Console.ReadLine());
            string[] disciplinas = new string[qtdDisciplinas];

            for (int i = 0; i < qtdDisciplinas; i++)
            {
                Console.WriteLine($"Digite o nome da {i + 1}ª disciplina:");
                disciplinas[i] = Console.ReadLine();
            }

            Professor professor = new Professor(disciplinas, tempoContrato, cargo, nome, cpf);
            listaProfessores.Add(professor);
            Console.WriteLine($"Professor {nome} cadastrado com sucesso!");
        }

        private static void CadastrarCoordenador(List<Coordenador> listaCoordenadores)
        {
            Console.WriteLine("Iniciando cadastro de um novo coordenador");

            Console.WriteLine("Digite o nome do coordenador:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do coordenador:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o tempo de contrato do coordenador:");
            string tempoContrato = Console.ReadLine();

            Console.WriteLine("Digite o cargo do coordenador:");
            string cargo = Console.ReadLine();

            Console.WriteLine("Quantos cursos o coordenador coordena?");
            int qtdCursos = Convert.ToInt32(Console.ReadLine());
            string[] cursos = new string[qtdCursos];

            for (int i = 0; i < qtdCursos; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}º curso:");
                cursos[i] = Console.ReadLine();
            }

            Coordenador coordenador = new Coordenador(cursos, tempoContrato, cargo, nome, cpf);
            listaCoordenadores.Add(coordenador);
            Console.WriteLine($"Coordenador {nome} cadastrado com sucesso!");
        }
        private static void CadastrarFuncionario(List<Funcionario> listaFuncionarios)
        {
            Console.WriteLine("Iniciando cadastro de um novo funcionário");

            Console.WriteLine("Digite o nome do funcionário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do funcionário:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o tempo de contrato do funcionário:");
            string tempoContrato = Console.ReadLine();

            Console.WriteLine("Digite o cargo do funcionário:");
            string cargo = Console.ReadLine();

            Funcionario funcionario = new Funcionario(tempoContrato, cargo, nome, cpf);
            listaFuncionarios.Add(funcionario);
            Console.WriteLine($"Funcionário {nome} cadastrado com sucesso!");
        }


        private static void ExibirUsuariosCadastrados(List<Aluno> listaAlunos, List<Professor> listaProfessores, List<Coordenador> listaCoordenadores, List<Funcionario> listaFuncionarios)
        {
            Console.WriteLine("Exibindo todos os usuários cadastrados");

            Console.WriteLine("----------LISTA DE USUÁRIOS----------");

            if (listaCoordenadores.Count > 0)
            {
                Console.WriteLine("\n**COORDENADORES**\n");
                foreach (Coordenador c in listaCoordenadores)
                {
                    Console.WriteLine($"Nome: {c.GetNome()}");
                    Console.WriteLine($"CPF: {c.GetCPF()}");

                    Console.WriteLine("\nLISTA DE CURSOS COORDENADOS:");
                    foreach (string curso in c.GetCursos())
                    {
                        Console.WriteLine(curso);
                    }
                }
            }

            if (listaProfessores.Count > 0)
            {
                Console.WriteLine("\n**PROFESSORES**\n");
                foreach (Professor p in listaProfessores)
                {
                    Console.WriteLine($"Nome: {p.GetNome()}");
                    Console.WriteLine($"CPF: {p.GetCPF()}");

                    Console.WriteLine("\nLISTA DE DISCIPLINAS MINISTRADAS:");
                    foreach (string disciplina in p.GetDisciplinas())
                    {
                        Console.WriteLine(disciplina);
                    }
                }
            }

            if (listaAlunos.Count > 0)
            {
                Console.WriteLine("\n**ALUNOS**\n");
                foreach (Aluno a in listaAlunos)
                {
                    Console.WriteLine($"Nome: {a.GetNome()}");
                    Console.WriteLine($"CPF: {a.GetCPF()}");
                    Console.WriteLine($"Curso: {a.GetCurso()}\n");
                }
            }

            if (listaFuncionarios.Count > 0)
            {
                Console.WriteLine("\n**FUNCIONÁRIOS**\n");
                foreach (Funcionario f in listaFuncionarios)
                {
                    Console.WriteLine($"Nome: {f.GetNome()}");
                    Console.WriteLine($"CPF: {f.GetCPF()}");
                    Console.WriteLine($"Tempo de Contrato: {f.GetTempoContrato()}");
                    Console.WriteLine($"Cargo: {f.GetCargo()}\n");
                }
            }
        }
    }
}
