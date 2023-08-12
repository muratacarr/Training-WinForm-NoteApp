using Training_WinForm_NoteApp.DTO;
using Training_WinForm_NoteApp.Forms;

namespace Training_WinForm_NoteApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserLoginForm());
            //Application.Run(new NotesForm(new LoginResponseDto
            //{
            //    Fullname = "Murat ACAR",
            //    Id = 1
            //}));
            //Application.Run(new ProductsForm(new LoginResponseDto
            //{
            //    Fullname = "Murat ACAR",
            //    Id = 1
            //}));
        }
    }
}