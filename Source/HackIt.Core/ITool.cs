namespace HackIt.Core
{
    public interface ITool
    {
        string Name { get; set; }
        string HelpText { get; }
        bool UseRegex { get; set; }
        void HandleConsole(object shell, Command cmd); //ToDo: fix HandleConsole shell parameter
        bool ShowDialog();
    }
}