using System;
using System.IO;

namespace watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "Components");
            var watcher = new FileSystemWatcher(path, "*.js");
            watcher.Changed += HandleChange;
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            Console.ReadKey(false);
        }

        private static void HandleChange(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Changed) {
                Console.WriteLine($"File {e.FullPath} is changed");
                // Here, we will generate the full component js file, and will save it in the output folder based on conventions. We also add other required files to that folder. The we run react from that folder. With each save of developer, only that file would be updated in the output folder, thus recompiling that app.
            }
        }
    }
}
