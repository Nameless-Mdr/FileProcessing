using Domain.Models;
using Service.Interfaces;

namespace Service.Implements;

public class SearchNoLinq : ISearch
{
    public Subfolder SubfolderWithLargestCountFiles(string path)
    {
        if (!Directory.Exists(path))
            return new Subfolder();

        var allFolders = new List<DirectoryInfo>();

        try
        {
            foreach (var startFolder in Directory.GetDirectories(path))
            {
                // добавляем все папки в список
                var dirInfo = new DirectoryInfo(startFolder);
                allFolders.AddRange(dirInfo.GetDirectories("*", SearchOption.AllDirectories));
            }
        }
        catch (UnauthorizedAccessException)
        {
            return new Subfolder {Name = "Trying read system folders"};
        }

        var subfolder = new Subfolder();
        foreach (var folder in allFolders)
        {
            // если количество файлов больше количества файлов результируюущей папки, переприсваиваем значение
            var count = folder.GetFiles().Length;
            if (count <= subfolder.CountFile) continue;
            subfolder.Name = folder.Name;
            subfolder.Path = folder.FullName;
            subfolder.CountFile = count;
        }

        return subfolder;
    }

    public IEnumerable<FileModel> FilesWithSmallestSize(string path, int n)
    {
        if (!Directory.Exists(path))
            return new List<FileModel>();

        var startFolder = new DirectoryInfo(path);
        var resFiles = new List<FileModel>();

        try
        {
            var files = startFolder.GetFiles("*", SearchOption.AllDirectories);
            // сортируем все файлы по весу
            SortFilesByLength(files);

            // заносим в список первые n файлов
            foreach (var t in files)
            {
                var tmp = new FileModel
                {
                    Name = t.Name,
                    Extension = string.IsNullOrEmpty(t.Extension) ? "Empty Extension" : t.Extension,
                    Size = t.Length,
                    DateCreated = t.CreationTime
                };
                resFiles.Add(tmp);

                if (--n == 0)
                    return resFiles;
            }
        }
        catch (UnauthorizedAccessException)
        {
            return new List<FileModel>();
        }

        return resFiles;
    }

    public IEnumerable<Folder> SubfoldersWithFilesSameExtension(string path, short m)
    {
        if (!Directory.Exists(path))
            return new List<Folder>();

        var allFolders = new List<DirectoryInfo>();
        var resFolder = new List<Folder>();

        try
        {
            foreach (var startFolder in Directory.GetDirectories(path))
            {
                var dirInfo = new DirectoryInfo(startFolder);
                allFolders.AddRange(dirInfo.GetDirectories("*", SearchOption.AllDirectories));
            }
        }
        catch (UnauthorizedAccessException)
        {
            return new List<Folder>();
        }

        foreach (var folder in allFolders)
        {
            var files = folder.GetFiles("*");
            var count = files.Length;
            // создаем директорию, где ключ - расширение, значение - количество файлов с данным расширением
            var dirFiles = new Dictionary<string, int>();
            foreach (var file in files)
            {
                // если в директории еще нет информации о расширении, создаем новый элемент директории
                // иначе инкрементируем значение
                if (!dirFiles.ContainsKey(file.Extension))
                    dirFiles.Add(file.Extension, 1);
                else
                    dirFiles[file.Extension]++;
            }

            foreach (var dir in dirFiles)
            {
                // если количество файлов с данным расширением больше процента m, добавляем информацию о папке в результирующий список
                if (dir.Value / (double)count > (double)m / 100)
                {
                    var tmp = new Folder
                    {
                        Name = folder.Name,
                        Path = folder.FullName,
                        ExtensionFile = string.IsNullOrEmpty(dir.Key) ? "Empty Extension" : dir.Key,
                        Percent = dir.Value / (double)count * 100
                    };
                    resFolder.Add(tmp);
                }
            }
        }

        return resFolder;
    }

    public IEnumerable<FileDate> FilesCreatedInCertainInterval(string path, DateTime start, DateTime end, int k)
    {
        if (!Directory.Exists(path))
            return new List<FileDate>();

        var startFolder = new DirectoryInfo(path);
        var span = new TimeSpan(0, k, 0);
        var resFiles = new List<FileDate>();

        try
        {
            var files = startFolder.GetFiles("*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                // доблавяем в результирующий список файл, который был создан в период start и end
                if(file.CreationTime >= start && file.CreationTime <= end)
                    resFiles.Add(new FileDate
                    {
                        Name = file.Name,
                        Extension = string.IsNullOrEmpty(file.Extension) ? "Empty Extension" : file.Extension,
                        Size = file.Length,
                        DateCreated = file.CreationTime,
                        LeftDate = start + (int)((file.CreationTime - start).TotalMinutes / k) * span,
                        RightDate = start + (int)((file.CreationTime - start).TotalMinutes / k) * span + span
                    });
            }

            return resFiles;
        }
        catch (UnauthorizedAccessException)
        {
            return new List<FileDate>();
        }
    }

    private static void SortFilesByLength(FileInfo[] files)
    {
        for (int i = 0; i < files.Length - 1; i++)
        {
            for (int j = i; j < files.Length; j++)
            {
                if (files[j].Length < files[i].Length)
                {
                    (files[j], files[i]) = (files[i], files[j]);
                }
            }
        }
    }
}