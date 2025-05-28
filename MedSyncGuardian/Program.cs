using System;
using System.Threading.Tasks;
using MedSyncGuardian.Services;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando MedSync Guardian...");

        try
        {
            var syncService = new SyncService();
            var timeService = new TimeService();
            var alertService = new AlertService();
            
            await timeService.MonitorarRelogioAsync();
            await syncService.SincronizarAsync();
            alertService.MonitorarAlertas();

            Console.WriteLine("Sistema em execução. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            LoggerService.LogarErro("Erro inesperado: " + ex.Message);
        }
    }
}
