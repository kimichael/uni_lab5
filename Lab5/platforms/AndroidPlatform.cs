using System;
using Lab5.modules;

namespace Lab5
{
    public class AndroidPlatform : Platform
    {
        public string getName() {
            return "Android";
        }

        public void useModule(ModuleVisitor moduleVisitor)
        {
            moduleVisitor.visitPlatform(this);
        }
    }
}
