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
            User u = new User();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Products());
        }
    }
}