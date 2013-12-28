using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;

namespace FrameWork
{
    public class CryptorEngine
    {
        /// <summary>
        /// Encrypt a string using dual encryption method. Return a encrypted cipher Text
        /// </summary>
        /// <param name="toEncrypt">string to be encrypted</param>
        /// <param name="useHashing">use hashing? send to for extra secirity</param>
        /// <returns></returns>
        /// 

        public static string Key;
        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            byte[] resultArray;
            string key = "Acis";
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else

                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            #region AesManaged
            AesManaged myAes = new AesManaged();
            myAes.Mode = CipherMode.ECB;
            myAes.Key = keyArray;
            myAes.Padding = PaddingMode.ISO10126;
            ICryptoTransform encryptor = myAes.CreateEncryptor();
            resultArray = encryptor.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            myAes.Clear();
            #endregion

            #region TripleDESCryptoServiceProvider
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            resultArray = cTransform.TransformFinalBlock(resultArray, 0, resultArray.Length);
            tdes.Clear();
            #endregion

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);

        }
        /// <summary>
        /// DeCrypt a string using dual encryption method. Return a DeCrypted clear string
        /// </summary>
        /// <param name="cipherString">encrypted string</param>
        /// <param name="useHashing">Did you use hashing to encrypt this data? pass true is yes</param>
        /// <returns></returns>
        public static string Decrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);
            byte[] resultArray;
            string key = "Acis";

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            #region TripleDESCryptoServiceProvider

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();
            #endregion

            #region AesManaged
            AesManaged myAes = new AesManaged();
            myAes.Mode = CipherMode.ECB;
            myAes.Key = keyArray;
            myAes.Padding = PaddingMode.ISO10126;
            ICryptoTransform encryptor = myAes.CreateDecryptor();
            resultArray = encryptor.TransformFinalBlock(resultArray, 0, resultArray.Length);
            myAes.Clear();
            #endregion


            return UTF8Encoding.UTF8.GetString(resultArray);

        }



    }
}
