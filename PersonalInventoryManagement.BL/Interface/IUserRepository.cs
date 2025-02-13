using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInventoryManagement.DAL.Entities;

namespace PersonalInventoryManagement.BL.Interface
{
    public interface IUserRepository
    {
        /// <summary>
        /// Adds a new user to the system after validating the input data.
        /// This method ensures that the username and email are unique,
        /// encrypts the password before saving, and returns the user details.
        /// </summary>
        /// <param name="user">The user containing the user details.</param>
        /// <returns>Returns the newly added user details as a UserVM object.</returns>
        /// <exception cref="ArgumentNullException">Thrown when userVM is null.</exception>
        /// <exception cref="Exception">Thrown when the username or email already exists.</exception>
        User AddUser(User user);

        User Login(string username, string password);

        (bool IsExist, User user) EmailExist(string email);

        bool ResetPassword(string password,User user);

        (bool IsExist, User user) Update(User user);

        bool ChangePassword(User user, string oldPassword, string newPassword);
    }
}
