using MyApp.Models;
using MyApp.Services;

namespace MyApp.Controllers
{
    /// <summary>
    /// Контроллер для работы с пользователями
    /// </summary>
    public class UsersController
    {
        private static User ENTERED_USER = new();
        private List<User> _users;
        private readonly UserStorageService _userStorageService;

        public User EnteredUser => ENTERED_USER;
        public List<User> Users => _users;
        public int Count => _users.Count;
        public User this[int index] => _users[index];
        // пример: usersController[0] -> users[0]

        // При инициализации:
        //// I: плохо - не видно зависимости 
        //UsersController usersController = new UsersController();

        //// II: хорошо - видно зависимость
        //UserStorageService userStorageService = new UserStorageService("users.txt");
        //UsersController usersController_1 = new UsersController(userStorageService);

        // Плохо
        //public UsersController()
        //{
        //    _userStorageService = new("Users.txt");
        //}

        // Хорошо
        public UsersController(UserStorageService userStorageService)
        {
            _userStorageService = userStorageService;
        }

        public bool Registation(User user)
        {
            if (user == null)
                return false;

            _users = _userStorageService.Load();

            if(AvialableLogin(user.Login) == false) 
                return false;

            user.Id = GetNextId();
            _users.Add(user);

            _userStorageService.Save(_users, false);

            ENTERED_USER.Id = user.Id;
            ENTERED_USER.Login = user.Login;
            ENTERED_USER.Password = user.Password;
            ENTERED_USER.Email = user.Email;
            ENTERED_USER.Role = user.Role;

            _users.Clear();

            return true;
        }

        public bool Enter(string login, string password)
        {
            _users = _userStorageService.Load();

            foreach (User user in _users) {
                if (user.Login == login && user.Password == password) {
                    ENTERED_USER.Id = user.Id;
                    ENTERED_USER.Login = user.Login;
                    ENTERED_USER.Password = user.Password;
                    ENTERED_USER.Email = user.Email;
                    ENTERED_USER.Role = user.Role;
                    
                    _users.Clear();

                    return true;
                }
            }

            _users.Clear();
            return false;
        }

        private int GetNextId()
        {
            if (_users.Count == 0)
                return 1;

            return _users[_users.Count - 1].Id + 1;
        }

        private bool AvialableLogin(string login)
        {
            foreach (var user in _users) {
                if (user.Login == login)
                    return false;
            }

            return true;
        }
    }
}
