using System;
using System.Collections.Generic;

namespace WebMinerva.Models;

public partial class UnidadMedida
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();
}
