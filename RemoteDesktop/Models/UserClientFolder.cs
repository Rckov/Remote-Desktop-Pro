using System.Collections.ObjectModel;

namespace RemoteDesktop.Models
{
    internal class UserClientFolder
    {
        public string Name { get; set; }

        public ObservableCollection<UserClient> Clients { get; set; }
    }
}