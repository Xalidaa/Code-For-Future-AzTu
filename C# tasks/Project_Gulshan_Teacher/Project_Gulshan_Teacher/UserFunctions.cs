using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gulshan_Teacher
{
    public static class UserFunctions
    {
        public static void SortUsersByUsername(List<User> users)
        {
            users.Sort((u1, u2) => string.Compare(u1.Username, u2.Username, StringComparison.Ordinal));
        }

        public static List<User> FilterByBirthYear(List<User> users, int year)
        {
            List<User> filtered = new List<User>();
            foreach (var user in users)
            {
                if (user.getBirthYear() > year)
                {
                    filtered.Add(user);
                }
            }
            return filtered;
            
        }

        public static string Login(List<User> users, string username, string password)
        {
            User user = null;
            foreach(var u in users)
            {
                if(u.Username == username)
                {
                    user = u;
                    break;
                }
            }
            if (user == null)
            {
                return "User not found!";
            }

            if(user.Password != password || user.Username != username)
            {
                return "Username or password is incorrect!";
            }

            foreach (var u in users)
            {
                if (u.IsLogged)
                {
                    return "another user currently logged in";
                }
            }

            user.IsLogged = true;
            return "Login successful!";
        }

        public static string Logout(List<User> users, string username)
        {
            User user = null;
            foreach(var u in users)
            {
                if (u.Username == username)
                {
                    user = u;
                    break;
                }
            }
            if (user == null)
            {
                return "User not found!";
            }

            if (!user.IsLogged)
            {
                return "User is not logged in to log out!";
            }
            user.IsLogged = false;
            return "Logout successful!";

        }

        public static void CreateUser(List<User> users, User newUser)
        {
            users.Add(newUser);
        }


        public static string DeleteUser(List<User> users, string username)
        {
            User user = null;
            foreach (var u in users)
            {
                if (u.Username == username)
                {
                    user = u;
                    break;
                }
            }
            if (user == null)
            {
                return "User not found!";
            }

            users.Remove(user);
            return "User deleted successfully";
        }
    }
}
