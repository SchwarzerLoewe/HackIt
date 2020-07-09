using UILibrary;

namespace HackIt.Core
{
    public interface ITool
    {
        string Name { get; set; }
        string HelpText { get; }
        bool UseRegex { get; set; }
        void HandleConsole(ShellControl shell, Command cmd);
        bool ShowDialog();
    }
}