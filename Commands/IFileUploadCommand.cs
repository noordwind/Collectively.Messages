namespace Collectively.Messages.Commands
{
    public interface IFileUploadCommand : IAuthenticatedCommand
    {
        string Name { get; set; }
        string FileBase64 { get; set; }
    }
}