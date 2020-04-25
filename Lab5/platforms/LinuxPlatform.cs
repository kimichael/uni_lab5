using System;
using Lab5.modules;

namespace Lab5
{
    /// <summary>
    /// Класс, реализующий платформу Linux
    /// </summary>
    public class LinuxPlatform : Platform
    {
        public string getName()
        {
            return "Linux";
        }

        public void useModule(ModuleVisitor moduleVisitor)
        {
            moduleVisitor.visitPlatform(this);
        }
    }
}
