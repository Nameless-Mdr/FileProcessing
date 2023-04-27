using Domain.Models;

namespace Service.Interfaces;

public interface ISearch
{
    // функция 1
    public Subfolder SubfolderWithLargestCountFiles(string path);

    // функция 2
    public IEnumerable<FileModel> FilesWithSmallestSize(string path, int n);

    // функция 3
    public IEnumerable<Folder> SubfoldersWithFilesSameExtension(string path, short m);

    // функция 4
    public IEnumerable<FileDate> FilesCreatedInCertainInterval(string path, DateTime start, DateTime end, int k);
}