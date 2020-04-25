using System;
using Lab5.modules;

namespace Lab5
{
    public class MacOSPlatform : Platform
    {
        public string getName()
        {
            return "MacOS";
        }

        public void useModule(ModuleVisitor moduleVisitor)
        {
            moduleVisitor.visitPlatform(this);
        }
    }
}
