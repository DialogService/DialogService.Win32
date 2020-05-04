using DialogService.Items;
using System;

namespace DialogService.Win32.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var testDialog = TestDialog.GetDialog();
            var service = new DialogPlatformBuilder()
                .AddPlatform<PlatformImplementation>()
                .GetService();

            var result = service.Show(testDialog);

            service.ShowMessageBox(TestDialog.GetClosedBy(result), "Win32 Test");
        }
    }
}
