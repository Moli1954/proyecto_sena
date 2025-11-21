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
        public async Task crearUsuario(usuarioModel1 usuario)
        {
            if (usuario != null)
            {
                usuario.Usuario_contrasena = passwordServicio.Hashpassword (usuario.Usuario_contrasena);
                dBContex.Usuarios.Add(usuario);
                await dBContex.SaveChangesAsync();

            }
        }



        private readonly DBContext dBContex;
        private readonly Ipawordservicio passwordServicio;
        public Userinterface(DBContext dBContex, Ipawordservicio passwordServicio)
        {
            this.dBContex = dBContex;
            this.passwordServicio = passwordServicio;
        }
    }
}