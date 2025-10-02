using System;
using System.Collections.Generic;

namespace CasaToro.Consulta.Certificados.Entities;

public partial class EmpresasMaster
{
    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public string? Direccion { get; set; }

    public virtual ICollection<CertificadosIca> CertificadosIcas { get; set; } = new List<CertificadosIca>();

    public virtual ICollection<CertificadosIva> CertificadosIvas { get; set; } = new List<CertificadosIva>();

    public virtual ICollection<CertificadosRtefte> CertificadosRteftes { get; set; } = new List<CertificadosRtefte>();

    public virtual ICollection<FacturasProveedore> FacturasProveedores { get; set; } = new List<FacturasProveedore>();
}
