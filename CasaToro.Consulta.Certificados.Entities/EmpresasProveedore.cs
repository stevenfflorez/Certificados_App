using System;
using System.Collections.Generic;

namespace CasaToro.Consulta.Certificados.Entities;

public partial class EmpresasProveedore
{
    public string Nit { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public virtual EmpresasMaster IdEmpresaNavigation { get; set; } = null!;

    public virtual ProveedoresMaster NitNavigation { get; set; } = null!;
}
