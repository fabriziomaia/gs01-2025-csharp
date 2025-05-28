namespace MedSyncGuardian.Models
{
    public class MedicationSchedule
    {
        public string PacienteId { get; set; }
        public string Medicamento { get; set; }
        public DateTime HorarioAdministracao { get; set; }
        public string Dosagem { get; set; }
        public string PrescritoPor { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
