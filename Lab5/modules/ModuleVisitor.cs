namespace Lab5.modules
{
    public interface ModuleVisitor
    {
        void visitPlatform(AndroidPlatform platform);
        void visitPlatform(IOSPlatform platform);
        void visitPlatform(LinuxPlatform platform);
        void visitPlatform(MacOSPlatform platform);
        void visitPlatform(WindowsPlatform platform);
    }
}