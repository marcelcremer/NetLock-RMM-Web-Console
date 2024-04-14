﻿using BCrypt;

namespace Classes.Helper
{
    public class BCrypt_Handler
    {
        public static async Task<string> Hash_Content(string input)
        {
            return await Task.Run(() =>
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashed = BCrypt.Net.BCrypt.HashPassword(input, salt);

                return hashed;
            });
        }

        public static async Task<string> Verify_Content(string input)
        {
            return await Task.Run(() =>
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashed = BCrypt.Net.BCrypt.HashPassword(input, salt);

                return hashed;
            });
        }
    }
}
