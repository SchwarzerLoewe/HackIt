namespace HackIt.Core
{
    public interface INavigatable
    {
        string Title { get; }
        void OnNavigate();
    }
}