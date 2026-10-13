using System;
using System.Collections.Generic;

namespace WebMinerva.Models;

public partial class Proveedor
{
    public int Id { get; set; }

    public long Nit { get; set; }

    public string RazonSocial { get; set; } = null!;

    public string? Direccion { get; set; }

    public long? Celular { get; set; }

    public string Representante { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Compra> Compra { get; set; } = new List<Compra>();
}
