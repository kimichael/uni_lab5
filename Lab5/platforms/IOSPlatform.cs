using System;
using Lab5.modules;

namespace Lab5
{
    public class IOSPlatform : Platform
    {
        public string getName()
        {
            return "IOS";
        }

        public void useModule(ModuleVisitor moduleVisitor)
        {
            moduleVisitor.visitPlatform(this);
        }
    }
}
