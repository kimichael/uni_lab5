using System;
namespace Lab5.modules
{
    public class CDDriveModule : ModuleVisitor
    {
        public void visitPlatform(AndroidPlatform platform)
        {
            Console.WriteLine("Using CD drive module on Android");
        }

        public void visitPlatform(IOSPlatform platform)
        {
            Console.WriteLine("Using CD drive module on IOS");
        }

        public void visitPlatform(LinuxPlatform platform)
        {
            Console.WriteLine("Using CD drive module on Linux");
        }

        public void visitPlatform(MacOSPlatform platform)
        {
            Console.WriteLine("Using CD drive module on MacOS");
        }

        public void visitPlatform(WindowsPlatform platform)
        {
            Console.WriteLine("Using CD drive module on Windows");
        }
    }
}
