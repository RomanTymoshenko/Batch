using System.ComponentModel;
using System.ServiceProcess;
using System.Configuration.Install;

namespace Batch.Host.Service
{
    [RunInstaller(true)]
    public partial class BatchServiceInstaller : System.Configuration.Install.Installer
    {
        ServiceInstaller _serviceInstaller;
        ServiceProcessInstaller _processInstaller;
        public BatchServiceInstaller()
        {
            InitializeComponent();
            _serviceInstaller = new ServiceInstaller();
            _processInstaller = new ServiceProcessInstaller();
            
            _processInstaller.Account = ServiceAccount.LocalSystem;
            _serviceInstaller.StartType = ServiceStartMode.Manual;
            _serviceInstaller.ServiceName = "BatchService";
            Installers.Add(_processInstaller);
            Installers.Add(_serviceInstaller);
        }
    }
}
