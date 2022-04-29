using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hasher
{
    public interface IHasher
    {
        Task<string> GenerateHash(byte[] salt, string password);
        Task<byte[]> GenerateSalt();
    }
}
