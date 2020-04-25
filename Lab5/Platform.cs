using System;
using Lab5.modules;

namespace Lab5
{
    public interface Platform
    {
        String getName();

        void useModule(ModuleVisitor moduleVisitor);
    }
}
