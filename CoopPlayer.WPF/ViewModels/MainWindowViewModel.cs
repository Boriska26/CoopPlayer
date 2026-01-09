using System.Reflection;

namespace CoopPlayer.WPF.ViewModels
{
    internal class MainWindowViewModel
    {
        private string _title;

        public MainWindowViewModel()
        {
            _title = $"CoopPlayer - {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        public string Title => _title;
    }
}
