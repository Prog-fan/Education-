using System;
using System.Windows.Forms;

namespace Organizer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var authForm = new AuthorizationForm())
            {
                if (authForm.ShowDialog() != DialogResult.OK)
                {
                   return;
                }
            }
            Application.Run(new OrganizerForm());
        }
    }
}
