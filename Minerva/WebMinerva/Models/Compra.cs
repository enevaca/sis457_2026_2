using System;
using System.Collections.Generic;

namespace WebMinerva.Models;

public partial class Compra
{
    public long Id { get; set; }

    public int IdProveedor { get; set; }

    public int Transaccion { get; set; }

    public DateOnly Fecha { get; set; }

    public decimal Total { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<CompraDetalle> CompraDetalle { get; set; } = new List<CompraDetalle>();

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
}
