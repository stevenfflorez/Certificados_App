using CasaToro.Consulta.Certificados.Entities;

namespace CasaToro.Consulta.Certificados.Web.Models
{
    public class CertificatesViewModel
    {
        public List<EmpresasMaster> companies ;
        public HashSet<int> years;
        public HashSet<string> months;
    }
}
