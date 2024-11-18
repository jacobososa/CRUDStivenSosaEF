using System;
using System.Collections.Generic;

namespace CRUDStivenSosaEF.Models;

public partial class LibrosAutor
{
    public int LibrosAutor1 { get; set; }

    public int? IdAutor { get; set; }

    public int? Isbn { get; set; }

    public virtual Autor? IdAutorNavigation { get; set; }

    public virtual Libro? IsbnNavigation { get; set; }
}
