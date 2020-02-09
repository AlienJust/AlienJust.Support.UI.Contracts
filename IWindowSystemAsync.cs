using System.Threading.Tasks;

namespace AlienJust.Support.UI.Contracts
{
    public interface IWindowSystemAsync
    {
        Task<string> ShowOpenFileDialogAsync(string dialogTitle, string filter);

        Task<string> ShowSaveFileDialogAsync(string dialogTitle, string filter);

        Task<BinaryChoise> ShowYesNoDialogAsync(string message, string caption);

        Task ShowMessageBoxAsync(string message, string caption);
    }
}
