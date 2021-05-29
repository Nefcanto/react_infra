using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace watcher
{
    class Program
    {
        static string source = "/nefcanto/react_infra";

        static List<Regex> regexes = new List<Regex>
        {
            new Regex("/public.*"),
            new Regex("/src.*"),
            new Regex("/imports.js"),
            new Regex("/package.*.json")
        };

        static string target = "/temp/output";

        static void Main(string[] args)
        {
            CopyBaseOnce();

            return;

            var path = Path.Combine(target, "Components");
            var watcher = new FileSystemWatcher(path, "*.js");
            watcher.Changed += HandleChange;
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            Console.ReadKey(false);
        }

        private static void CopyBaseOnce()
        {
            var allDirectories = Directory.GetDirectories(source, "*", SearchOption.AllDirectories);
            File.WriteAllLines(Path.Combine(AppContext.BaseDirectory, "folders.txt"), allDirectories);
            var filteredDirectories = allDirectories.Where(i => regexes.Any(x => x.IsMatch(i))).ToList();
            foreach (string directory in filteredDirectories)
            {
                Directory.CreateDirectory(directory.Replace(source, target));
            }

            var allFiles = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
            var filteredFiles = allFiles.Where(i => regexes.Any(x => x.IsMatch(i))).ToList();
            foreach (string file in filteredFiles)
            {
                File.Copy(file, file.Replace(source, target), true);
            }
        }

        private static void HandleChange(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Changed)
            {
                Console.WriteLine($"File {e.FullPath} is changed");
                // Here, we will generate the full component js file, and will save it in the output folder based on conventions. We also add other required files to that folder. The we run react from that folder. With each save of developer, only that file would be updated in the output folder, thus recompiling that app.
            }
        }
    }
}
