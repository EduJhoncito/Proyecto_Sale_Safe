using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace Sale_Save.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
           
        }
        [Required(ErrorMessage = "Ingresa un ID  por favor")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Ingresa NOMBRE  por favor")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "Ingresa APELLIDO  por favor")]
        public string Apellido { get; set; } = null!;

        [Required(ErrorMessage = "Ingresa DIRECCION  por favor")]
        public string Direccion { get; set; } = null!;

        [Required(ErrorMessage = "Ingresa TELEFONO por favor")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Ingresa DNI por favor")]
        public int Dni { get; set; }

        
    }
}
