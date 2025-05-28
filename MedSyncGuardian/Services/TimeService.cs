using System;
using System.Threading.Tasks;

namespace MedSyncGuardian.Services
{
    public class TimeService
    {
        public async Task MonitorarRelogioAsync()
        {
            Console.WriteLine("Verificando sincronização de horário...");
            await Task.Delay(500); // Simula verificação
            DateTime localTime = DateTime.Now;
            if (Math.Abs((DateTime.UtcNow - localTime).TotalMinutes) > 5)
            {
                AlertService.EmitirAlerta("Desvio de horário detectado!");
            }
        }
    }
}