using CovidCol.DBContexts;
using CovidCol.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCol.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly CovidColContext _dbContext;

        public UserRepository(CovidColContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteUsuario(int usuarioId)
        {
            var usuario = _dbContext.Usuarios.Find(usuarioId);
            _dbContext.Usuarios.Remove(usuario);
            Save();
        }

        public Usuario GetUsuarioByDoc(long document)
        {
            return _dbContext.Usuarios
                        .Include(t => t.TipoDocumento)
                        .Include(c => c.Ciudad)
                            .ThenInclude(d => d.Departamento)
                        .FirstOrDefault(u => u.NumeroDocumento == document);
        }

        public Usuario GetUsuarioById(int idUsuario)
        {
            return _dbContext.Usuarios
                        .Include(t => t.TipoDocumento)
                        .Include(c=> c.Ciudad)
                            .ThenInclude(d => d.Departamento)
                        .FirstOrDefault(i => i.Id == idUsuario);
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _dbContext.Usuarios
                        .Include(t => t.TipoDocumento)
                        .Include(c =>  c.Ciudad)
                            .ThenInclude(d => d.Departamento)
                        .ToList();
        }

        public void InsertUsuario(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _dbContext.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
