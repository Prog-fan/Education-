using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Organizer
{
    class Logic
    {
        public string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public string SaveUserName(string username)
        {
            var userFilePath = Path.Combine(path, "user_info");
            using (StreamWriter sw = new StreamWriter(userFilePath, false))
            {
                sw.WriteLine(username);
            }
            return userFilePath;
        }

        public string GetUserName()
        {
            var userFilePath = Path.Combine(path, "user_info");
            if (File.Exists(userFilePath))
            {
                return File.ReadAllText(userFilePath).Trim();
            }
            else
            {
                return "Пользователь не найден";
            }
        }

        public string UsersFile()
        {
            var userFilePath = Path.Combine(path, "users");
            return userFilePath;
        }

        public string TempFile()
        {
            var tempFilePath = Path.Combine(path, "temp");
            return tempFilePath;
        }

        public bool UserExists(string username)
        {
            if (File.Exists(UsersFile()))
            {
                foreach (var line in File.ReadLines(UsersFile()))
                {
                    var parts = line.Split(':');
                    if (parts[0] == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Authenticate(string username, string password)
        {
            if (File.Exists(UsersFile()))
            {
                foreach (var line in File.ReadLines(UsersFile()))
                {
                    var parts = line.Split(':');
                    if (parts[0] == username && parts[1] == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}