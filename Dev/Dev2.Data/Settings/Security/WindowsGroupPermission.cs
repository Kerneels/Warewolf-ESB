using System;
using Newtonsoft.Json;

namespace Dev2.Data.Settings.Security
{
    public class WindowsGroupPermission : ObservableObject
    {
        public const string BuiltInAdministratorsText = "BuiltIn\\Administrators";

        bool _isServer;
        Guid _resourceID;
        string _resourceName;
        string _windowsGroup;
        bool _view;
        bool _execute;
        bool _contribute;
        bool _deployTo;
        bool _deployFrom;
        bool _administrator;
        bool _isNew;

        public bool IsServer { get { return _isServer; } set { OnPropertyChanged(ref _isServer, value); } }

        public Guid ResourceID { get { return _resourceID; } set { OnPropertyChanged(ref _resourceID, value); } }

        public string ResourceName { get { return _resourceName; } set { OnPropertyChanged(ref _resourceName, value); } }

        public string WindowsGroup { get { return _windowsGroup; } set { OnPropertyChanged(ref _windowsGroup, value); } }

        public bool View { get { return _view; } set { OnPropertyChanged(ref _view, value); } }

        public bool Execute { get { return _execute; } set { OnPropertyChanged(ref _execute, value); } }

        public bool Contribute { get { return _contribute; } set { OnPropertyChanged(ref _contribute, value); } }

        public bool DeployTo { get { return _deployTo; } set { OnPropertyChanged(ref _deployTo, value); } }

        public bool DeployFrom { get { return _deployFrom; } set { OnPropertyChanged(ref _deployFrom, value); } }

        public bool Administrator { get { return _administrator; } set { OnPropertyChanged(ref _administrator, value); } }

        public bool IsNew { get { return _isNew; } set { OnPropertyChanged(ref _isNew, value); } }

        [JsonIgnore]
        public Permissions Permissions
        {
            get
            {
                var result = Permissions.None;
                if(View) { result |= Permissions.View; }
                if(Execute) { result |= Permissions.Execute; }
                if(Contribute) { result |= Permissions.Contribute; }
                if(DeployTo) { result |= Permissions.DeployTo; }
                if(DeployFrom) { result |= Permissions.DeployFrom; }
                if(Administrator) { result |= Permissions.Administrator; }

                return result;
            }
            set
            {
                View = (value & Permissions.View) == Permissions.View;
                Execute = (value & Permissions.Execute) == Permissions.Execute;
                Contribute = (value & Permissions.Contribute) == Permissions.Contribute;
                DeployTo = (value & Permissions.DeployTo) == Permissions.DeployTo;
                DeployFrom = (value & Permissions.DeployFrom) == Permissions.DeployFrom;
                Administrator = (value & Permissions.Administrator) == Permissions.Administrator;
            }
        }

        [JsonIgnore]
        public bool IsBuiltInAdministrators
        {
            get
            {
                return IsServer && WindowsGroup.Equals(BuiltInAdministratorsText, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        [JsonIgnore]
        public bool IsValid
        {
            get
            {
                return IsServer
                    ? !string.IsNullOrEmpty(WindowsGroup)
                    : !string.IsNullOrEmpty(WindowsGroup) && !string.IsNullOrEmpty(ResourceName);
            }
        }

        public static WindowsGroupPermission CreateDefault()
        {
            return new WindowsGroupPermission
            {
                IsServer = true,
                WindowsGroup = BuiltInAdministratorsText,
                View = false,
                Execute = false,
                Contribute = true,
                DeployTo = true,
                DeployFrom = true,
                Administrator = true

            };
        }
    }
}
