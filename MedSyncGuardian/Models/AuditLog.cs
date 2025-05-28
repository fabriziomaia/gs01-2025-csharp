namespace MedSyncGuardian.Models
{
    public class AuditLog
    {
        public DateTime Timestamp { get; set; }
        public string Acao { get; set; }
        public string Resultado { get; set; }
        public string Usuario { get; set; }
        public string IPOrigem { get; set; }
    }
}
