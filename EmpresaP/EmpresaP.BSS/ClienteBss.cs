using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaP.DAL;
using EmpresaP.Modelos;

namespace EmpresaP.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClientesDal();
        }

        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerIdBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public void EditarClienteBss(Cliente c)
        {
            dal.EditarClienteDal(c);
        }
        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }

        public DataTable ClienteDatosTBss(int id)
        {
            return dal.ClienteDatosTDal(id);
        }
        public DataTable ClienteDatosLBss(int id)
        {
            return dal.ClienteDatosLDal(id);
        }
        
    }
}
