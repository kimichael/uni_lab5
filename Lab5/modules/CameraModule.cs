using System;
namespace Lab5.modules
{
    /// <summary>
    /// Класс, реализующий модуль камеры
    /// </summary>
    public class CameraModule : ModuleVisitor
    {
        public void visitPlatform(AndroidPlatform platform)
        {
            Console.WriteLine("Using camera module on Android");
        }

        public void visitPlatform(IOSPlatform platform)
        {
            Console.WriteLine("Using camera module on IOS");
        }

        public void visitPlatform(LinuxPlatform platform)
        {
            Console.WriteLine("Using camera module on Linux");
        }

        public void visitPlatform(MacOSPlatform platform)
        {
            Console.WriteLine("Using camera module on MacOS");
        }

        public void visitPlatform(WindowsPlatform platform)
        {
            Console.WriteLine("Using camera module on Windows");
        }
    }
}
