using CasaToro.Consulta.Certificados.Entities;
using CasaToro.Consulta.Certificados.DAL;
namespace CasaToro.Consulta.Certificados.BL.Services
{
    public class LogService
    {
        private readonly ApplicationDbContext _context;

        public LogService(ApplicationDbContext context)
        {
            _context = context;
        }


        public void addLogDownload(LogDescarga log)
        {
            _context.LogDescargas.Add(log);
            _context.SaveChanges();
        }

        public void addLogLogin(LogLogin log)
        {
            _context.LogLogins.Add(log);
            _context.SaveChanges();
        }

        public void addLogLoginAdmin(LogLoginAdmin log)
        {
            _context.LogLoginAdmins.Add(log);
            _context.SaveChanges();
        }
    }
}
