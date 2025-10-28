using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace pryecto_nicol.Models

{
    public class usuarioModel1
    {
        public int UserId { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Apellido { get; set; }
        public string Usuario_correo { get; set; }
        public string Usuario_contrasena { get; set; }  
    }
}


