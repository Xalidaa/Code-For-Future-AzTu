using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gulshan_Teacher
{
    public class User : Human
    {
        public string Username;
        public string Email;
        public bool IsAdmin;
        public bool IsLogged = false;
        private string password;
        private string bio = "";

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (value.Length < 5)
                {
                    throw new Exception("Password must be at least 5 characters long.");
                }
                password = value;
            }
        }

        public string Bio
        {
            get
            {
                return bio;
            }

            set
            {
                string newValue = value ?? "";
                if (newValue.Length > 30)
                {
                    throw new Exception("Bio must be less than 30 characters long.");
                }
                bio = newValue;
            }
        }



        public User(string name, string surname, string gender, string nationality, string username,string email, string password, int age = 0, bool isAdmin = false, string bio = "" ) : base(name, surname,gender, nationality, age)
        {
            Username = username;
            Email = email;
            IsAdmin = isAdmin;
            Password = password;
            Bio = bio;
        }


        public string ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword != password)
            {
                return "Old password is incorrect.";
            }
            if (currentPassword == newPassword)
            {
                return "New password must be different from old password.";
            }

            if (newPassword.Length < 5)
            {
                return "Password must be at least 5 characters long.";
            }
            password = newPassword;
            return "Password changed successfully.";

        }

        public string ChangeEmail(List<User> users, string newEmail)
        {
            if (newEmail == Email)
            {
                return "New email must be different from old email.";
            }

            if (users.Any(u => u.Email == newEmail))
            {
                return "Email is already taken.";
            }

            Email = newEmail;
            return "Email changed successfully.";
        }




    }
}
