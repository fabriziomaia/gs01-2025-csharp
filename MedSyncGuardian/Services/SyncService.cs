using System;
using System.Threading.Tasks;
using MedSyncGuardian.Models;
using MedSyncGuardian.Utils;

namespace MedSyncGuardian.Services
{
    public class SyncService
    {
        public async Task SincronizarAsync()
        {
            try
            {
                Console.WriteLine("Tentando sincronizar com o servidor...");
                await Task.Delay(1000); // Simula requisição
                LoggerService.Logar("Sincronização bem-sucedida.");
            }
            catch (Exception ex)
            {
                LoggerService.LogarErro("Falha na sincronização: " + ex.Message);
                throw;
            }
        }
    }
}
