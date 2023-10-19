using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public  class usuario
    {

        public int idusuario { get; set; }
        public int Idrol { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }   
        public string NumDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }   
        public string Clave { get; set; }
        public bool Estado { get; set; }

    }
}
