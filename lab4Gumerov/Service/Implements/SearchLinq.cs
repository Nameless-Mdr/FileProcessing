using Domain.Models;
using Service.Interfaces;

namespace Service.Implements;

public class SearchLinq : ISearch
{
    public Subfolder SubfolderWithLargestCountFiles(string path)
    {
        // если каталога не существует, возвращаем пустую папку
        if (!Directory.Exists(path))
            return new Subfolder();

        var allFolders = new List<DirectoryInfo>();

        try
        {
            // рассматриваем все подкаталоги начальной папки
            foreach (var startFolder in Directory.GetDirectories(path).Select(folder => new DirectoryInfo(folder)))
            {
                // добавляем все вложенные папки в список
                allFolders.AddRange(startFolder.GetDirectories("*", SearchOption.AllDirectories));
            }
        }
        catch (UnauthorizedAccessException)
        {
            return new Subfolder { Name = "Trying read system folders" };
        }

        // возвращаем вложенную папку с самым большим количеством файлов
        return allFolders
            .Select(x => new Subfolder
                { Name = x.Name, Path = x.FullName, CountFile = x.GetFiles("*").Length })
            .Where(x => x.CountFile > 0)
            .MaxBy(x => x.CountFile) ?? new Subfolder();
    }

    public IEnumerable<FileModel> FilesWithSmallestSize(string path, int n)
    {
        if (!Directory.Exists(path))
            return new List<FileModel>();

        try
        {
            // получаем все файлы во всех каталогах
            var files = new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories);

            // сортируя файлы по весу, возвращаем список первых n файлов
            return files.OrderBy(x => x.Length)
                .Select(file => new FileModel
                {
                    Name = file.Name,
                    Extension = string.IsNullOrEmpty(file.Extension) ? "Empty Extension" : file.Extension,
                    Size = file.Length,
                    DateCreated = file.CreationTime
                }).Take(n).ToList();
        }
        catch (UnauthorizedAccessException)
        {
            return new List<FileModel>();
        }
    }

    public IEnumerable<Folder> SubfoldersWithFilesSameExtension(string path, short m)
    {
        if (!Directory.Exists(path))
            return new List<Folder>();

        var allFolders = new List<DirectoryInfo>();

        try
        {
            foreach (var startFolder in Directory.GetDirectories(path).Select(folder => new DirectoryInfo(folder)))
            {
                allFolders.AddRange(startFolder.GetDirectories("*", SearchOption.AllDirectories));
            }
        }
        catch (UnauthorizedAccessException)
        {
            return new List<Folder>();
        }

        // группируем файлы по расширению, рассматриваем каждую группу и добавляем в список те файлы, количество которых больше процента m
        return (from folder in allFolders
                let files = folder.GetFiles("*")
                let count = files.Length
                from file in files.GroupBy(x => x.Extension)
                where file.Count() / (double)count > (double)m / 100
                select new Folder
                {
                    Name = folder.Name,
                    Path = folder.FullName,
                    ExtensionFile = string.IsNullOrEmpty(file.Key) ? "Empty Extension" : file.Key,
                    Percent = file.Count() / (double)count * 100
                })
            .ToList();
    }

    public IEnumerable<FileDate> FilesCreatedInCertainInterval(string path, DateTime start, DateTime end, int k)
    {
        if (!Directory.Exists(path))
            return new List<FileDate>();

        var startFolder = new DirectoryInfo(path);
        var span = new TimeSpan(0, k, 0);

        try
        {
            var files = startFolder.GetFiles("*", SearchOption.AllDirectories);

            // фильтруем файлы по дате создания, возвращаем список файлов с интервалом создания
            return files.OrderBy(x => x.CreationTime)
                .Where(x => x.CreationTime >= start && x.CreationTime <= end)
                .Select(x => new FileDate
                {
                    Name = x.Name,
                    Extension = string.IsNullOrEmpty(x.Extension) ? "Empty Extension" : x.Extension,
                    Size = x.Length,
                    DateCreated = x.CreationTime,
                    LeftDate = start + (int)((x.CreationTime - start).TotalMinutes / k) * span,
                    RightDate = start + (int)((x.CreationTime - start).TotalMinutes / k) * span + span
                });
        }
        catch (UnauthorizedAccessException)
        {
            return new List<FileDate>();
        }
    }
}