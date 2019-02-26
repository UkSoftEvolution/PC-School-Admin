using System;
using System.Text;
using System.Windows.Controls;
using System.Security.Cryptography;

namespace PC_School_Admin.Other
{
    /// <summary>
    /// Класс для шифрования пароля
    /// </summary>
    public class Encryption
    {
        /// <summary>
        /// Зашифровать пароль
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <returns>Зашифрованный пароль</returns>
        public string Encrypt(object obj)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes((obj as PasswordBox).Password));
            string pass = BitConverter.ToString(checkSum).Replace("-", string.Empty);
            return pass;
        }
    }
}