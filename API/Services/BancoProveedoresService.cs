using Ahueso.Data;
using API.Models;
using API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;


namespace API.Services
{
    public class BancoProveedoresService : IBancoProveedoresService
    {
        private readonly CompuAdmoDbContext _context;

        public BancoProveedoresService()
        {
            _context = new CompuAdmoDbContext();
        }

        public IEnumerable<BancoProveedores> GetAll()
        {
            return _context.BancoProveedores.ToList();
        }

        public BancoProveedores GetById(int id)
        {
            return _context.BancoProveedores.Find(id);
        }

        public void Add(BancoProveedores bancoProveedores)
        {
            _context.BancoProveedores.Add(bancoProveedores);
            _context.SaveChanges();
        }

        public void Update(BancoProveedores bancoProveedores)
        {
            var existing = _context.BancoProveedores.Find(bancoProveedores.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(bancoProveedores);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var bancoProveedores = _context.BancoProveedores.Find(id);
            if (bancoProveedores != null)
            {
                _context.BancoProveedores.Remove(bancoProveedores);
                _context.SaveChanges();
            }
        }
    }
}
