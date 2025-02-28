using System;
using System.Collections.Generic;
using Task2.BL;

namespace Task2.DL
{
    internal class AdminDL
    {
        private static List<Admin> adminList = new List<Admin>();

        public static bool SignUp(string username, string password)
        {
            foreach (Admin admin in adminList)
            {
                if (admin.username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Username already taken. Please choose another.");
                    return false;
                }
            }
            adminList.Add(new Admin(username, password));
            Console.WriteLine("Admin Sign-up successful! You can now log in.");
            return true;
        }
        public static Admin SignIn(string username, string password)
        {
            foreach (Admin admin in adminList)
            {
                if (admin.username == username && admin.password == password)
                {
                    Console.WriteLine($"Welcome back, {admin.username}!");
                    return admin;
                }
            }
            Console.WriteLine("Invalid username or password.");
            return null;
        }
    }
}
