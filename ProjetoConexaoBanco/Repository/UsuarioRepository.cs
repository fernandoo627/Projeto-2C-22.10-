using Microsoft.Extensions.Configuration;
using ProjetoConexaoBanco.Models;
using ProjetoConexaoBanco.Repository.Contract;

namespace ProjetoConexaoBanco.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly string _conexaoMySQL;

        public UsuarioRepository(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }
        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ObterTodosUsuarios()
        {
            
        }

        public Usuario ObterUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
