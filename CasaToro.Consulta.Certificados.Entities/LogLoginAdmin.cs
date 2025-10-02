using System;
using System.Collections.Generic;

namespace CasaToro.Consulta.Certificados.Entities;

public partial class LogLoginAdmin
{
    public Guid IdRegistroLogin { get; set; }

    public string IdAdmin { get; set; } = null!;

    public string NombreAdmin { get; set; } = null!;

    public DateTime FecLogin { get; set; }

    public virtual Administradore IdAdminNavigation { get; set; } = null!;
}
