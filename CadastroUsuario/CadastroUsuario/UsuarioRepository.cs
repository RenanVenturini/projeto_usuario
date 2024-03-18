using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CadastroUsuario
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository()
        {
            _connectionString = "Data Source=DESKTOP-EA69SA6\\SQLEXPRESS;Initial Catalog=Cadastros;Integrated Security=True";
        }

        public void CriarUsuario(Usuario usuario)
        {
            
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("INSERT INTO TbUsuario (CPF, Nome, Sexo, DataNascimento, Telefone, Email, Endereco, Numero, Complemento) " +
                    "VALUES (@CPF, @Nome, @Sexo, @DataNascimento, @Telefone, @Email, @Endereco, @Numero, @Complemento)", connection);
                cmd.Parameters.AddWithValue("@CPF", usuario.CPF);
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                cmd.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
                cmd.Parameters.AddWithValue("@Numero", usuario.Numero);
                cmd.Parameters.AddWithValue("@Complemento", usuario.Complemento);

                cmd.ExecuteNonQuery();

            }
        }

        public Usuario ObterUsuario(string cpf)
        {
            Usuario usuario = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM TbUsuario WHERE CPF = @CPF", connection);
                cmd.Parameters.AddWithValue("@CPF", cpf);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            Id = (int)reader["Id"],
                            CPF = (string)reader["CPF"],
                            Nome = (string)reader["Nome"],
                            Sexo = (string)reader["Sexo"],
                            DataNascimento = (DateTime)reader["DataNascimento"],
                            Telefone = (string)reader["Telefone"],
                            Email = (string)reader["Email"],
                            Endereco = (string)reader["Endereco"],
                            Numero = (string)reader["Numero"],
                            Complemento = (string)reader["Complemento"]
                        };
                    }
                }
            }

            return usuario;
        }

        public Usuario ObterUsuarioPorNome(string nome)
        {
            Usuario usuario = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM TbUsuario WHERE Nome = @Nome", connection);
                cmd.Parameters.AddWithValue("@Nome", nome);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            Id = (int)reader["Id"],
                            CPF = (string)reader["CPF"],
                            Nome = (string)reader["Nome"],
                            Sexo = (string)reader["Sexo"],
                            DataNascimento = (DateTime)reader["DataNascimento"],
                            Telefone = (string)reader["Telefone"],
                            Email = (string)reader["Email"],
                            Endereco = (string)reader["Endereco"],
                            Numero = (string)reader["Numero"],
                            Complemento = (string)reader["Complemento"]
                        };
                    }
                }
            }

            return usuario;
        }

        public IEnumerable<Usuario> ListarUsuario()
        {
            var usuarios = new List<Usuario>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("SELECT * FROM TbUsuario", connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new Usuario
                        {
                            Id = (int)reader["Id"],
                            CPF = (string)reader["CPF"],
                            Nome = (string)reader["Nome"],
                            Sexo = (string)reader["Sexo"],
                            DataNascimento = (DateTime)reader["DataNascimento"],
                            Telefone = (string)reader["Telefone"],
                            Email = (string)reader["Email"],
                            Endereco = (string)reader["Endereco"],
                            Numero = (string)reader["Numero"],
                            Complemento = (string)reader["Complemento"]
                        });
                    }
                }
            }

            return usuarios;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("UPDATE TbUsuario SET CPF = @CPF, Nome = @Nome, Sexo = @Sexo, DataNascimento = @DataNascimento, " +
                    "Telefone = @Telefone, Email = @Email, Endereco = @Endereco, Numero = @Numero, Complemento = @Complemento WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Id", usuario.Id);
                cmd.Parameters.AddWithValue("@CPF", usuario.CPF);
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                cmd.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Endereco", usuario.Endereco);
                cmd.Parameters.AddWithValue("@Numero", usuario.Numero);
                cmd.Parameters.AddWithValue("@Complemento", usuario.Complemento);

                cmd.ExecuteNonQuery();
            }
        }

        public void ExcluirUsuario(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand("DELETE FROM TbUsuario WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}

    

