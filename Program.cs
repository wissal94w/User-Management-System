using System;
using System.Collections.Generic;

namespace TestProject2
{
    class Program
    {
        // تعريف القائمة خارج الـ Main لتراها كل الدالات
        static List<string> usersList = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== Clean Architecture User System ===");
            bool running = true;

            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "1") AddUser();
                else if (choice == "2") ShowUsers();
                else if (choice == "3") SearchUser();
                else if (choice == "4") DeleteUser();
                else if (choice == "5") { running = false; Console.WriteLine("Goodbye! 👋"); }
                else Console.WriteLine("Invalid choice! ❌");
            }
        }

        // 1. دالة عرض القائمة
        static void ShowMenu()
        {
            Console.WriteLine("\nChoose an option (1-5):");
            Console.WriteLine("1. Add User | 2. Show All | 3. Search | 4. Delete | 5. Exit");
            Console.Write("\nEnter choice: ");
        }

        // 2. دالة إضافة مستخدم
        static void AddUser()
        {
            Console.Write("Enter name to add: ");
            string name = Console.ReadLine();
            usersList.Add(name);
            Console.WriteLine("Added! ✅");
        }

        // 3. دالة عرض المستخدمين المطورة
        static void ShowUsers()
        {
            Console.WriteLine("\n--- Users ---");

            // هنا يطبع البرنامج عدد المستخدمين الإجمالي تلقائياً
            Console.WriteLine("Total Users Registered: " + usersList.Count);
            Console.WriteLine("---------------------");

            if (usersList.Count == 0)
            {
                Console.WriteLine("Empty! ⚠️");
            }
            else
            {
                foreach (string u in usersList)
                {
                    Console.WriteLine("- " + u);
                }
            }
        }

        // 4. دالة البحث
        static void SearchUser()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();
            if (usersList.Contains(name)) Console.WriteLine("Found! 🔍");
            else Console.WriteLine("Not found! ❌");
        }

        // 5. دالة الحذف
        static void DeleteUser()
        {
            Console.Write("Enter name to delete: ");
            string name = Console.ReadLine();
            if (usersList.Remove(name)) Console.WriteLine("Deleted! 🗑️");
            else Console.WriteLine("Not found! ⚠️");
        }
    }
}