using System;
using Lab5.modules;

namespace Lab5
{
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
