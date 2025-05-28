using System;
using System.IO;

namespace MedSyncGuardian.Services
{
    public static class LoggerService
    {
        private static string logPath = "logs.txt";

        public static void Logar(string mensagem)
        {
            File.AppendAllText(logPath, $"{DateTime.Now}: {mensagem}\n");
        }

        public static void LogarErro(string erro)
        {
            File.AppendAllText(logPath, $"{DateTime.Now} [ERRO]: {erro}\n");
        }
    }
}
