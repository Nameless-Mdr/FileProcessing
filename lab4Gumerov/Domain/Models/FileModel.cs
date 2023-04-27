namespace Domain.Models;

public class FileModel
{
    public string Name { get; set; } = "File not found";

    public string Extension { get; set; } = "File not found";

    public DateTime DateCreated { get; set; }

    public long Size { get; set; }
}