using System;
using Lab5.modules;

namespace Lab5
{
    /// <summary>
    /// Класс, отвечающий за пятую лабораторную работу по ТРПО
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа для приложения
        /// </summary>
        /// <param name="args">Список аргументов командной строки</param>
        static void Main(string[] args)
        {

            // Для начала выбираем платформу, на которой будем работать
            Console.WriteLine("Choose your platform\n" +
                "1. Android\n" +
                "2. IOS\n" +
                "3. Linux\n" +
                "4. MacOS\n" +
                "5. Windows\n");

            Platform platform;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.KeyChar)
            {
                case '1':
                    platform = new AndroidPlatform();
                    break;
                case '2':
                    platform = new IOSPlatform();
                    break;
                case '3':
                    platform = new LinuxPlatform();
                    break;
                case '4':
                    platform = new MacOSPlatform();
                    break;
                case '5':
                    platform = new WindowsPlatform();
                    break;
                default:
                    throw new ArgumentException("Unknown key");
            }

            Console.WriteLine($"\nYou chose {platform.getName()}");

            // Теперь выбираем нужный модуль
            Console.WriteLine("Choose module\n" +
                "1. CanvasModule\n" +
                "2. RadioModule\n" +
                "3. WiFiModule\n" +
                "4. CDDriveModule\n" +
                "5. BluetoothModule\n" +
                "6. AudioModule\n" +
                "7. NeuralNetworkModule\n" +
                "8. CameraModule");

            ModuleVisitor moduleVisitor;

            ConsoleKeyInfo moduleKeyInfo = Console.ReadKey();
            switch (keyInfo.KeyChar)
            {
                case '1':
                    moduleVisitor = new CanvasModule();
                    break;
                case '2':
                    moduleVisitor = new RadioModule();
                    break;
                case '3':
                    moduleVisitor = new WiFiModule();
                    break;
                case '4':
                    moduleVisitor = new CDDriveModule();
                    break;
                case '5':
                    moduleVisitor = new BluetoothModule();
                    break;
                case '6':
                    moduleVisitor = new AudioModule();
                    break;
                case '7':
                    moduleVisitor = new NeuralNetworkModule();
                    break;
                case '8':
                    moduleVisitor = new CameraModule();
                    break;
                default:
                    throw new ArgumentException("Unknown key");
            }

            Console.WriteLine();
            platform.useModule(moduleVisitor);
        }
    }
}
