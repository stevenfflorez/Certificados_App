﻿using System;
using System.Collections.Generic;

namespace CasaToro.Consulta.Certificados.Entities;

public partial class CertificadosRtefte
{
    public Guid IdRtf { get; set; }

    public string Nit { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Concepto { get; set; } = null!;

    public decimal Porcentaje { get; set; }

    public decimal Base { get; set; }

    public decimal Retenido { get; set; }

    public int Ano { get; set; }

    public int? Mes { get; set; }

    public string CiudadPago { get; set; } = null!;

    public string CiudadExpedido { get; set; } = null!;

    public DateOnly FechaExpedicion { get; set; }

    public virtual EmpresasMaster IdEmpresaNavigation { get; set; } = null!;

    public virtual ProveedoresMaster NitNavigation { get; set; } = null!;
}
