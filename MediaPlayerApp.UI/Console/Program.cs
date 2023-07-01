using MediaPlayerApp.UI.Interfaces;

namespace MediaPlayerApp.UI.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IUserInterface userInterface = new ConsoleUI();
            userInterface.Start();
        }
    }
}
