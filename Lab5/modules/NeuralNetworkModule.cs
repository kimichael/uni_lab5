using System;
namespace Lab5.modules
{
    public class NeuralNetworkModule : ModuleVisitor
    {
        public void visitPlatform(AndroidPlatform platform)
        {
            Console.WriteLine("Using neural network module on Android");
        }

        public void visitPlatform(IOSPlatform platform)
        {
            Console.WriteLine("Using neural network module on IOS");
        }

        public void visitPlatform(LinuxPlatform platform)
        {
            Console.WriteLine("Using neural network module on Linux");
        }

        public void visitPlatform(MacOSPlatform platform)
        {
            Console.WriteLine("Using neural network module on MacOS");
        }

        public void visitPlatform(WindowsPlatform platform)
        {
            Console.WriteLine("Using neural network module on Windows");
        }
    }
}
