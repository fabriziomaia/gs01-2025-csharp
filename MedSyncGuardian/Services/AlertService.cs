using System;

namespace MedSyncGuardian.Services
{
    public class AlertService
    {
        public void MonitorarAlertas()
        {
            Console.WriteLine("Monitorando alertas do sistema...");
        }

        public static void EmitirAlerta(string mensagem)
        {
            Console.WriteLine("🚨 ALERTA: " + mensagem);
            LoggerService.Logar("Alerta emitido: " + mensagem);
        }
    }
}
