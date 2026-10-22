using ProjetoConexaoBanco.Models;

namespace ProjetoConexaoBanco.Repository.Contract
{
    public interface IUsuarioRepository
    {
        //CRUD - Create, Read, Update, Delete
        IEnumerable<Usuario> ObterTodosUsuarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int id);

        void Excluir(int id);


    }
}
