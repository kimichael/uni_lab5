using System;
namespace Lab5.modules
{
    /// <summary>
    /// Класс, реализующий аудио модуль
    /// </summary>
    public class AudioModule : ModuleVisitor
    {
        public void visitPlatform(AndroidPlatform platform)
        {
            Console.WriteLine("Using audio module on Android");
        }

        public void visitPlatform(IOSPlatform platform)
        {
            Console.WriteLine("Using audio module on IOS");
        }

        public void visitPlatform(LinuxPlatform platform)
        {
            Console.WriteLine("Using audio module on Linux");
        }

        public void visitPlatform(MacOSPlatform platform)
        {
            Console.WriteLine("Using audio module on MacOS");
        }

        public void visitPlatform(WindowsPlatform platform)
        {
            Console.WriteLine("Using audio module on Windows");
        }
    }
}
