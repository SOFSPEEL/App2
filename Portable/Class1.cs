using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;

namespace Portable
{



    public class Class1
    {
        private IMvxCommand _editMediaCommand;

        public IMvxCommand EditMediaCommand => _editMediaCommand ?? (_editMediaCommand = new MvxAsyncCommand(ActionAsync));


        private static async Task ActionAsync()
        {
            await UserDialogs.Instance.ActionSheetAsync(null, "Cancel", null, null, "Junk1", "Junk2");
        }

    }
}
