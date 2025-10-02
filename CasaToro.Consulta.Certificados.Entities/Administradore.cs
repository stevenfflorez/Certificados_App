using System;
using System.Collections.Generic;

namespace CasaToro.Consulta.Certificados.Entities;

public partial class Administradore
{
    public string IdAdmin { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public virtual ICollection<LogLoginAdmin> LogLoginAdmins { get; set; } = new List<LogLoginAdmin>();
}
