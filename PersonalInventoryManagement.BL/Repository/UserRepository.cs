using Microsoft.EntityFrameworkCore;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.DAL.DataBase;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository() => _context = new ApplicationDbContext();

        #region Login 

        public User Login(string Email, string password)
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Username and password are required");

            var user = _context.Users.FirstOrDefault(u => u.Email == Email);

            if (user == null || !VerifyPassword(password, user.Password))
                throw new Exception("Invalid username or password");

            return user; // ✅ 
        }

        #endregion


        #region Add User
        public User AddUser(User userVM)
        {
            // Ensure the userVM object is not null
            if (userVM == null)
                throw new ArgumentNullException("User Can't be null");

            // Check if the username is already taken
            if (_context.Users.Any(u => u.UserName == userVM.UserName))
                throw new Exception("Username already exists!");

            // Check if the email is already registered
            if (_context.Users.Any(u => u.Email == userVM.Email))
                throw new Exception("Email already exists!");

            // Create a new User entity from the provided data
            var user = new User
            {
                Name = userVM.Name,
                Email = userVM.Email,
                Password = HashPassword(userVM.Password),
                UserName = userVM.UserName,
                ImageURL = ""
            };

            // Add the user entity to the database context
            _context.Users.Add(user);
            _context.SaveChanges(); // Commit the changes to the database

            // Return a UserVM containing the saved user details
            return new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                UserName = user.UserName,
            };
        }

        #endregion


        #region Hashing Password

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }


        #endregion


        #region Verify Password

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
        }

        #endregion


        #region Email Exist

        public (bool IsExist, User user) EmailExist(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return (false,null);
            return (true, user);
        }

        #endregion


        #region Reset Password

        

        public bool ResetPassword(string password, User user)
        {
            if (string.IsNullOrWhiteSpace(password) || user == null)
            {
                return false; // Invalid input
            }

            var validateUser = _context.Users.Find(user.Id);
            if (validateUser == null)
                return false;

            // Hash and update password
            validateUser.Password = HashPassword(password);

            try
            {
                _context.Update(validateUser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        #endregion


        #region Update 

        public (bool IsExist, User user) Update(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            var existingUser = _context.Users.Find(user.Id);

            if (existingUser == null)
            {
                return (false, null);
            }

            try
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.UserName = user.UserName;
                existingUser.ImageURL = user.ImageURL;

                _context.SaveChanges();

                return (true, existingUser);
            }
            catch (DbUpdateException ex)
            {
                return (false, null);
            }
            catch (Exception ex)
            {
                return (false, null);
            }
        }


        #endregion


        #region Change Password

        public bool ChangePassword(User user, string oldPassword, string newPassword)
        {
            if (user == null)
            {
                return false; // User not found
            }

            // Verify old password
            if (!VerifyPassword(oldPassword, user.Password))
            {
                return false; // Old password is incorrect
            }

            // Hash the new password
            user.Password = HashPassword(newPassword);

            try
            {
                _context.SaveChanges();
                return true; // Password changed successfully
            }
            catch (Exception)
            {
                return false; // Error occurred during save
            }
        }

        #endregion
    }


}

