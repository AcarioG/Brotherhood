using System.Threading.Tasks;

namespace Brotherhood.UI.Repositories
{
    public interface IErrorMessage
    {
        Task ShowErrorMessage(string message);
    }
}