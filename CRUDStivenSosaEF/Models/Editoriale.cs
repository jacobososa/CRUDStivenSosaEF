using System;
using System.Collections.Generic;

namespace CRUDStivenSosaEF.Models;

public partial class Editoriale
{
    public int NitEditorial { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public string? SitioWeb { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
