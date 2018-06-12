using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace ExtensibilityTemplates
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", Vsix.Version, IconResourceID = 400)]       
    [Guid("57a60f7e-ca7d-430a-ae6d-f9ce7062ac39")]
    public sealed class MyPackage : AsyncPackage
    {
    }
}
