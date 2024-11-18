using System;
using System.Collections.Generic;

namespace CRUDStivenSosaEF.Models;

public partial class Categoria
{
    public int CodigoCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
