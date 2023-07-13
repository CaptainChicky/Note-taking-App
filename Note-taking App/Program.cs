using System;
using System.Windows.Forms;

namespace NoteTakingApp
{
    static class Program
    {
        /// <summary>
        ///  STA Threading needed for the message pump to ensure form works correctly
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NoteForm());
        }
    }
}
