using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pryecto_nicol.Data;
using pryecto_nicol.Models;
using pryecto_nicol.Services;

namespace pryecto_nicol.Views.implementacion
{
    public class Userinterface : IUserinterface
    {
        public void crearUsuario(usuarioModel1 usuario)
        {
            if (usuario != null)
            {
                dBContex.Usuarios.Add(usuario);
                dBContex.SaveChangesAsync();

            }
        }
        private readonly DBContext dBContex;
        public Userinterface(DBContext dBContex)
        {
            this.dBContex = dBContex;
        }
    }
}