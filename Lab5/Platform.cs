using System;
using Lab5.modules;

namespace Lab5
{
    /// <summary>
    /// Класс, инкапсулирующий информацию о платформе
    /// </summary>
    public interface Platform
    {
        /// <summary>
        /// Метод, возвращающий название платформы
        /// </summary>
        /// <returns>Возвращает название платформы</returns>
        String getName();

        void useModule(ModuleVisitor moduleVisitor);
    }
}
