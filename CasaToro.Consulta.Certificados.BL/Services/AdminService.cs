using CasaToro.Consulta.Certificados.DAL;
using CasaToro.Consulta.Certificados.Entities;


namespace CasaToro.Consulta.Certificados.BL.Services
{
    public class AdminService
    {
        private readonly ApplicationDbContext _context;

        public AdminService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Administradore getAdminById(string id)
        {
            return _context.Administradores.Find(id);
        }
    }
}
