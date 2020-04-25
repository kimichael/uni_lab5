using System;
namespace Lab5.modules
{
    public class BluetoothModule : ModuleVisitor
    {
        public void visitPlatform(AndroidPlatform platform)
        {
            Console.WriteLine("Using bluetooth module on Android");
        }

        public void visitPlatform(IOSPlatform platform)
        {
            Console.WriteLine("Using bluetooth module on IOS");
        }

        public void visitPlatform(LinuxPlatform platform)
        {
            Console.WriteLine("Using bluetooth module on Linux");
        }

        public void visitPlatform(MacOSPlatform platform)
        {
            Console.WriteLine("Using bluetooth module on MacOS");
        }

        public void visitPlatform(WindowsPlatform platform)
        {
            Console.WriteLine("Using bluetooth module on Windows");
        }
    }
}
