using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using formspresencaa.DTOS;

namespace formspresencaa.Repositorios
{
    public class AlunoRepositorio
    {

        private readonly string _connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bigode\Desktop\Code\Registro de Presença\AppDePresenca\AppDePresenca\Database.mdf;Integrated Security=True";





        public bool SalvarAluno(Aluno aluno)
        {

            int IdPessoaCriada = -1;
            try
            {
                var query = @"INSERT INTO Alunos 
                                      (Nome, Turma, Empresa) 
                                      OUTPUT Inserted.Id
                                      VALUES (@nome, @turma, @empresa)";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@nome", aluno.Nome);
                    command.Parameters.AddWithValue("@turma", aluno.Turma);
                    command.Parameters.AddWithValue("@empresa", aluno.Empresa);
                    command.Connection.Open();
                    IdPessoaCriada = (int)command.ExecuteScalar();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }

        public bool SalvarTurma(string turma)
        {

            int IdPessoaCriada = -1;
            try
            {
                var query = @"INSERT INTO Turma 
                                      (Turma) 
                                      OUTPUT Inserted.Id
                                      VALUES (@Turma)";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Parameters.AddWithValue("@Turma", turma);
                    command.Connection.Open();
                    IdPessoaCriada = (int)command.ExecuteScalar();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }



        public bool ValidacaoNome(string dataDeHoje, string nome)
        {
            var aluno = BuscarInfoAluno(nome);
            if (aluno == null)
            {
                return false;
            }
            if (nome == aluno.Nome)
            {
                CriarDiaDeHojeDarPresenca(dataDeHoje, nome);
                return true;
            }
            else
            {
                return false;
            }

        
        }

        public bool CriarDiaDeHojeDarPresenca(string dataDeHoje, string nome)
        {
                try
                {
                    var query = @"INSERT INTO Data(Data, Nome)  VALUES ('" + dataDeHoje + "', '" + nome + "')";
                    using (var sql = new SqlConnection(_connection))
                    {
                        SqlCommand command = new SqlCommand(query, sql);
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                    }
                    return true;

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Erro: " + ex.Message);
                    return false;

                }
        }

        public List<DataDTO> BuscarTodosDoDia(string dataDeHoje)
        {
            try
            {
                var query = @"select Nome from Data where Data='" + dataDeHoje + "'";

                using (var connection = new SqlConnection(_connection))
                {
                    return connection.Query<DataDTO>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return new List<DataDTO>();
            }
        }

        public List<AlunoDTO> BuscarTodosDaTurma(string turma)
        {
            try
            {
                var query = @"select Nome from Alunos where Turma='" + turma + "'";

                using (var connection = new SqlConnection(_connection))
                {
                    return connection.Query<AlunoDTO>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return new List<AlunoDTO>();
            }
        }


        public bool AtualizarDadosAluno(Aluno aluno, string reservado)
        {

            try
            {
                var query = @"UPDATE alunos SET Nome='" + aluno.Nome + "', Turma='" + aluno.Turma + "', Empresa='" + aluno.Empresa + "' WHERE Nome='" + reservado + "';";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }

        public bool AtualizarDadosTurma(string turma, string reservado)
        {

            try
            {
                var query = @"UPDATE Turma SET Turma='" + turma + "' WHERE Turma='" + reservado + "';";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }

        public bool AtualizarDadosTurmaEmGeral(string turma, string reservado)
        {

            try
            {
                var query = @"UPDATE Alunos SET Turma='" + turma + "' WHERE Turma='" + reservado + "';";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }

        public List<AlunoDTO> BuscarTodosAlunos()
        {
            try
            {
                var query = @"select * from  Alunos";

                using (var connection = new SqlConnection(_connection))
                {
                    return connection.Query<AlunoDTO>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return new List<AlunoDTO>();
            }
        }

        public List<String> BuscarTodasTurmas()
        {
            try
            {
                var query = @"select Turma from  Turma";

                using (var connection = new SqlConnection(_connection))
                {
                    return connection.Query<String>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return new List<String>();
            }
        }

        public AlunoDTO BuscarAluno(string nome)
        {
            try
            {
                var query = @"select Nome from Alunos where Nome='"+nome+"'";

                using (var connection = new SqlConnection(_connection))
                {

                    return connection.QueryFirstOrDefault<AlunoDTO>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
        }


        public AlunoDTO BuscarInfoAluno(string nome)
        {

            try
            {
                var query = @"select Nome, Turma, Empresa from Alunos where Nome='" + nome + "'";

                using (var connection = new SqlConnection(_connection))
                {
                    return connection.QueryFirstOrDefault<AlunoDTO>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
        }


        public bool DeletarAluno(string nome)
        {

            try
            {
                var query = @"DELETE FROM Alunos WHERE Nome ='" + nome + "'";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }

        public bool DeletarPresenca(string dataDeHoje, string nome)
        {

            try
            {
                var query = @"DELETE FROM Data WHERE Data = '"+dataDeHoje+"' and Nome  =  '"+nome+"'";
                using (var sql = new SqlConnection(_connection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
                return false;

            }
        }

    }
}
