using System;
using System.Collections.Generic;
using System.Text;

namespace DialogService
{
    /// <summary>
    /// Functionality to get Win32 platform implementation of dialog service
    /// </summary>
    public class PlatformImplementation : AbstractPlatform
    {
        /// <summary>
        /// Gets Win32 dialog service implementation
        /// </summary>
        /// <returns></returns>
        public override IDialogService Get() => new Win32.Win32DialogService();
    }
}
