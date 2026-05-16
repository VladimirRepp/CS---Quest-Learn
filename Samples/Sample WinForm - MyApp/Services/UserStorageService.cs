using MyApp.Models;

namespace MyApp.Services
{
    /// <summary>
    /// Сервис для работы с хранилищем данных пользователей
    /// </summary>
    public class UserStorageService
    {
        private readonly string _filename;

        public UserStorageService(string filename)
        {
            _filename = filename;
        }

        public List<User> Load()
        {
            List<User> users = new();

            // Шаблон записанных данных в файле:
            // 1
            // log
            // pas
            // em@mail.ru
            // user

            using (StreamReader reader = new StreamReader(_filename))
            { 
                string line;
                User user = null;
                int lineCounter = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    switch (lineCounter)
                    {
                        case 0:
                            user = new User();
                            user.Id = int.Parse(line);
                            break;

                        case 1:
                            user.Login = line;
                            break;

                        case 2:
                            user.Password = line;
                            break;

                        case 3:
                            user.Email = line;
                            break;

                        case 4:
                            user.Role = line;
                            users.Add(user);

                            lineCounter = -1;
                            break;
                    }

                    lineCounter++;
                }
            }

            return users;
        }

        public bool Save(List<User> users, bool isAdd = true)
        {
            if (users == null)
                return false;

            if (users.Count == 0)
                return false;

            // Шаблон записанных данных в файле:
            // 1
            // log
            // pas
            // em@mail.ru
            // user

            using (StreamWriter writer = new StreamWriter(_filename, isAdd))
            {
                foreach(User user in users)
                {
                    for(int i = 0; i < 5; i++)
                    {
                        if (i == 0)
                            writer.WriteLine(user.Id.ToString());
                        else if(i == 1)
                            writer.WriteLine(user.Login);
                        else if (i == 2)
                            writer.WriteLine(user.Password);
                        else if (i == 3)
                            writer.WriteLine(user.Email);
                        else if (i == 4)
                            writer.WriteLine(user.Role);
                    }
                }
            }

            return true;
        }
    }
}