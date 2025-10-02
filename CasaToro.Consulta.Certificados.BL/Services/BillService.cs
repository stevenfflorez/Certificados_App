using System.Data.Entity;
using CasaToro.Consulta.Certificados.DAL;
using CasaToro.Consulta.Certificados.Entities;

namespace CasaToro.Consulta.Certificados.BL.Services
{
    public class BillService
    {
        private readonly ApplicationDbContext _context;

        public BillService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<FacturasProveedore> GetBillsForProvider(string nit)
        {
            return _context.FacturasProveedores
                 .Where(b => b.Nit == nit)
                 .Include(b => b.IdEmpresaNavigation)
                 .Include(b => b.NitNavigation)
                 .Select(b => new FacturasProveedore
                 {
                     NumeroFactura = b.NumeroFactura,
                     IdEmpresa = b.IdEmpresa,
                     Nit = b.Nit,
                     Moneda = b.Moneda,
                     FechaFactura = b.FechaFactura,
                     ValorTotal = b.ValorTotal,
                     Iva = b.Iva,
                     ReteFuente = b.ReteFuente,
                     ReteIva = b.ReteIva,
                     ReteIca = b.ReteIca,
                     ValorPago = b.ValorPago ?? 0.0m,
                     FechaPago = b.FechaPago ?? DateOnly.MinValue,
                     BancoReceptor = b.BancoReceptor ?? "-",
                     CuentaBancaria = b.CuentaBancaria ?? "-",
                     CodigoSpiga = b.CodigoSpiga ?? 0,
                     Estado = b.Estado,
                     IdEmpresaNavigation = b.IdEmpresaNavigation,
                     NitNavigation = b.NitNavigation,
                     Descripcion = b.Descripcion ?? "-"
                 })
                 .ToList();
        }
    }
}
