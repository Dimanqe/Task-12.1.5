using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("User1", "David", true);
            User user2 = new User("User2", "John", true);
            User user3 = new User("User3", "David", false);           

            List<User> people = new List<User>() { user1, user2, user3 };

            foreach (User user in people)
            {
                if (user.IsPremium)
                {
                    Console.WriteLine($"Приветствуем пользователя: {user.Login} по имени: {user.Name}");
                }
                else
                    User.ShowAds();
            }
            Console.ReadKey();
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool ispremium)
        {
            Login = login;
            Name = name;
            IsPremium = ispremium;
        }

        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }


}
