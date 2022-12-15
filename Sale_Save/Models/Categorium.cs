using System;
using System.Collections.Generic;

namespace Sale_Save.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string TipoCategoria { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
