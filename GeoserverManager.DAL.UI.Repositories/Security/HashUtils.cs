using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.DAL.UI.Repositories.Security
{
    public class HashUtils
    {
        /// <summary>
        /// default salt size
        /// </summary>
        public const int DEFAULT_SALT_SIZE = 4;
        /// <summary>
        /// Generate a salted sha1 password hash
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="saltSize"></param>
        /// <returns></returns>
        public static string Sha1HashPasswordWithSalt(string pwd, int saltSize)
        {
            //generate salt
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var salt = new byte[saltSize];
            rng.GetBytes(salt);
            //copmute hash
            var hash = ComputeHash(pwd, salt);
            //append hash and salt
            byte[] saltedHash = AppendByteArrays(hash, salt);
            //return base64 saltedhash
            return Convert.ToBase64String(saltedHash);
        }

        private static byte[] ComputeHash(string pwd, byte[] salt)
        {
            //get password bytes
            var bytes = System.Text.Encoding.Unicode.GetBytes(pwd);
            //append password and salt
            byte[] all = AppendByteArrays(bytes, salt);
            //compute hash
            var sha = new System.Security.Cryptography.SHA1Managed();
            var hash = sha.ComputeHash(all);
            return hash;
        }

        /// <summary>
        /// compares a password with a sha1 salted hash
        /// </summary>
        /// <param name="pwd"></param>
        /// <param name="saltedHash"></param>
        /// <param name="saltSize"></param>
        /// <returns></returns>
        public static bool ComparePasswordWithSha1SaltedHash(string pwd, string saltedHash, int saltSize)
        {
            //convert base64 hash to bytearray
            byte[] all = Convert.FromBase64String(saltedHash);
            //get salt
            byte[] salt = new byte[saltSize];
            Array.Copy(all, all.Length - saltSize, salt, 0, saltSize);

            //get original checksum
            byte[] sha = new byte[all.Length - saltSize];
            Array.Copy(all, 0, sha, 0, sha.Length);

            //copmute hash
            var hash = ComputeHash(pwd, salt);
            //compare received hash with computed hash
            if (hash.Length == sha.Length)
            {
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i] != sha[i])
                    {
                        //password doesn't match
                        return false;
                    }
                }
                //all equals, password match
                return true;
            }
            //different hash sizes, password doesn't match
            return false;

        }

        /// <summary>
        /// append two byte arrays
        /// </summary>
        /// <param name="salt"></param>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static byte[] AppendByteArrays(byte[] bytes, byte[] salt)
        {
            byte[] all = new byte[bytes.Length + salt.Length];
            Array.Copy(bytes, all, bytes.Length);
            Array.Copy(salt, 0, all, bytes.Length, salt.Length);
            return all;
        }
    }
}
