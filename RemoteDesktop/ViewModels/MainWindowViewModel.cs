using RemoteDesktop.Models;
using RemoteDesktop.ViewModels.Base;

using System.Collections.ObjectModel;
using System.Linq;

namespace RemoteDesktop.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _status = string.Empty;

        public MainWindowViewModel()
        {
            ClientFolders = new ObservableCollection<UserClientFolder>(Enumerable
                .Range(1, 10)
                .Select(x => new UserClientFolder()
                {
                    Name = "Folder " + x,
                    Clients = new ObservableCollection<UserClient>(Enumerable
                    .Range(1, 3)
                    .Select(y => new UserClient()
                    {
                        Name = "Client " + y
                    }))
                }));
        }

        #region Fields

        public string Status
        {
            get => _status;
            set => Set(ref _status, value);
        }

        public ObservableCollection<UserClientFolder> ClientFolders { get; }

        #endregion Fields
    }
}