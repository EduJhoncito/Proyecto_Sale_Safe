using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Sale_Save.Models
{
    public partial class Producto
    {
        public Producto() { 
        
        }

        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int IdMarca { get; set; }
        public string? Foto { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Marca IdMarcaNavigation { get; set; } = null!;
        
    }
    public partial class listado
    {
        public Producto p { get; set; }
        public Marca m { get; set; }
        public Categorium c { get; set; }
    }

    public partial class Clientep
    {
        public Producto p { get; set; }
        public Cliente c { get; set; }
    }

    public partial class carrito
    {
        public Producto p { get; set; }
        public Marca m { get; set; }
        public Categorium c { get; set; }
    }

}
