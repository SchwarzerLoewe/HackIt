using UILibrary;

namespace HackIt.Core
{
    public interface ITool
    {
        string Name { get; }
        void HandleConsole(ShellControl shell, Command cmd);
        bool ShowDialog();
    }
}