using System.Security.Cryptography;
using System.Text;

namespace MedSyncGuardian.Utils
{
    public static class ChecksumValidator
    {
        public static string CalcularHash(string conteudo)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(conteudo);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool ValidarHash(string conteudo, string hashEsperado)
        {
            string hashCalculado = CalcularHash(conteudo);
            return hashCalculado == hashEsperado;
        }
    }
}
