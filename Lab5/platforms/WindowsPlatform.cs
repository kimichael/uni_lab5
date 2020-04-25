using System;
using Lab5.modules;

namespace Lab5
{
    /// <summary>
    /// Класс, реализующий платформу Windows
    /// </summary>
    public class WindowsPlatform : Platform
    {
        public string getName()
        {
            return "Windows";
        }

        public void useModule(ModuleVisitor moduleVisitor)
        {
            moduleVisitor.visitPlatform(this);
        }
    }
}
