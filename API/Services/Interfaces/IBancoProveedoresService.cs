using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services.Interfaces
{
    public interface IBancoProveedoresService
    {
        IEnumerable<BancoProveedores> GetAll();
        BancoProveedores GetById(int id);
        void Add(BancoProveedores bancoProveedores);
        void Update(BancoProveedores bancoProveedores);
        void Delete(int id);
    }
}
