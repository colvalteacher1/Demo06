using System;
using System.Collections.Generic;

namespace Demo06.Models;

public partial class Person
{
    public uint Id { get; set; }

    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public uint? Age { get; set; }

    public string? Ville { get; set; }

    public DateTime? DateNaissance { get; set; }

    public bool? Actif { get; set; }
}
