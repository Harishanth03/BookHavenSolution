using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace BookHaven.Model
{
    class ENVProcess
    {
        private static readonly string encryptionPassphrase;

        static ENVProcess()
        {
            Env.Load();

            encryptionPassphrase = Environment.GetEnvironmentVariable("ENCRYPTION_PASSPHRASE");

            if(string.IsNullOrEmpty(encryptionPassphrase))
            {
                throw new InvalidOperationException("Encryption passphrase not found.");
            }
        }

        public static string GetEncryptionPassphrase()
        {
            return encryptionPassphrase;
        }
    }
}



