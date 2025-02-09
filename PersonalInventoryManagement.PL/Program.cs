using PersonalInventoryManagement.DAL.DataBase;
using PersonalInventoryManagement.DAL.Entities;
using PersonalInventoryManagement.PL.Category;
using PersonalInventoryManagement.PL.Images.Categories;

namespace PersonalInventoryManagement.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            User u = context.Users.Find(3);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Reports());
        }
    }
}