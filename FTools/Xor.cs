using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTools
{
    class Xor
    {

        public static string XOR(string text)
        {
            return Xor.XOR(text, XorForm.key, false);
        }

        // Token: 0x06002B4A RID: 11082 RVA: 0x0001C6B3 File Offset: 0x0001A8B3
        public static string XOR(string text, bool encrypt)
        {
            return Xor.XOR(text, XorForm.key, encrypt);
        }

        // Token: 0x06002B4B RID: 11083 RVA: 0x000F5BB8 File Offset: 0x000F3DB8
        public static string XOR(string text, string key, bool encrypt)
        {
            if (encrypt)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(text);
                byte[] bytes2 = Encoding.UTF8.GetBytes(key);
                return Convert.ToBase64String(Xor.EncryptDecrypt(bytes, bytes2));
            }
            byte[] data = Convert.FromBase64String(text);
            byte[] bytes3 = Encoding.UTF8.GetBytes(key);
            return Encoding.UTF8.GetString(Xor.EncryptDecrypt(data, bytes3));
        }

        // Token: 0x06002B4C RID: 11084 RVA: 0x000F5C14 File Offset: 0x000F3E14
        public static byte[] XOR(byte[] bytes)
        {
            byte[] bytes2 = Encoding.UTF8.GetBytes("");
            return Xor.EncryptDecrypt(bytes, bytes2);
        }

        // Token: 0x06002B4D RID: 11085 RVA: 0x0001C6D6 File Offset: 0x0001A8D6
        public static byte[] XOR(byte[] bytes, byte[] key)
        {
            return Xor.EncryptDecrypt(bytes, key);
        }

        // Token: 0x06002B4E RID: 11086 RVA: 0x000F5C50 File Offset: 0x000F3E50
        private static byte[] EncryptDecrypt(byte[] data, byte[] key)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            byte[] array = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                array[i] = (byte)i;
            }
            for (int j = 0; j < 256; j++)
            {
                num3 = (num3 + (int)array[j] + (int)key[j % key.Length]) % 256;
                byte b = array[j];
                array[j] = array[num3];
                array[num3] = b;
            }
            byte[] array2 = new byte[data.Length];
            for (int k = 0; k < data.Length; k++)
            {
                num = (num + 1) % 256;
                num2 = (num2 + (int)array[num]) % 256;
                byte b = array[num];
                array[num] = array[num2];
                array[num2] = b;
                array2[k] = (byte)(data[k] ^ array[(int)(array[num] + array[num2]) % 256]);
            }
            return array2;
        }
    }
}
