using System;
using System.Threading.Tasks;

namespace Hasher
{
    class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(async () =>
            {

                Hasher hasher = new Hasher();
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                // generate a 128-bit salt using a secure PRNG
                var salt = await hasher.GenerateSalt();
                Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

                //derive a 256 - bit subkey(use HMACSHA1 with 10, 000 iterations)
                string hashedpassword = await hasher.GenerateHash(salt, password);
                Console.WriteLine($"Hashed: {hashedpassword}");

            }).GetAwaiter().GetResult();
        }
    }
}
