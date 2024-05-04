﻿using DownloadManager.Application;
using DownloadManager.UserInterface;

namespace DownloadManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            UI ui = new UI(
                new Host(),
                new Controller(
                    new FileSystemManager(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
                        logger),
                    logger),
                new ReflectionCommandLoader());
            ui.Run();
        }
    }
}