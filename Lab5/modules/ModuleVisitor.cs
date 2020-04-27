namespace Lab5.modules
{
    /// <summary>
    /// Класс, инкапсулирующий информацию о модуле фреймворка
    /// </summary>
    public interface ModuleVisitor
    {
        /// <summary>
        /// Метод, содержащий реализацию модуля для Android платформы
        /// </summary>
        void visitPlatform(AndroidPlatform platform);
        /// <summary>
        /// Метод, содержащий реализацию модуля для IOS платформы
        /// </summary>
        void visitPlatform(IOSPlatform platform);
        /// <summary>
        /// Метод, содержащий реализацию модуля для Linux платформы
        /// </summary>
        void visitPlatform(LinuxPlatform platform);
        /// <summary>
        /// Метод, содержащий реализацию модуля для MacOS платформы
        /// </summary>
        void visitPlatform(MacOSPlatform platform);
        /// <summary>
        /// Метод, содержащий реализацию модуля для Windows платформы
        /// </summary>
        void visitPlatform(WindowsPlatform platform);
    }
}