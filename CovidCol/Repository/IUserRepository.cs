using CovidCol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCol.Repository
{
    public interface IUserRepository
    {
        IEnumerable<Usuario> GetUsuarios();
        Usuario GetUsuarioByDoc(long document);
        Usuario GetUsuarioById(int idUsuario);
        void InsertUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int usuarioId);
        void Save();
    }
}
