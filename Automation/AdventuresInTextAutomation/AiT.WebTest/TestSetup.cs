using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AiT.WebTest;

[TestClass]
public class TestSetup
{
    private static Process? _applicationProcess;

    [AssemblyInitialize]
    public static void AssemblyInit(TestContext context)
    {
        // This is ugly, I know.
        // Ideally I'd be doing this in a pipeline where the application is ran then we're running the tests.
        // I only added this as I kept forgetting to run AiT on my laptop!
        _applicationProcess = Process.Start(@"C:\Users\devel\Documents\GitHub\AdventuresInText\AiT.Web\bin\Release\net10.0\AiT.Web.exe", "--urls=http://localhost:5109/");
        Thread.Sleep(10000);
        Console.WriteLine("Application started.");
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        if (_applicationProcess != null && !_applicationProcess.HasExited)
        {
            _applicationProcess.Kill();
            _applicationProcess.WaitForExit();
        }
        
        Console.WriteLine("Application stopped.");
    }
}
