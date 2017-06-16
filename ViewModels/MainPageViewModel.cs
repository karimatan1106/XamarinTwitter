using Prism.Commands;
using Prism.Mvvm;
using XamarinTweet.Models;

namespace XamarinTweet.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region コマンド
        public DelegateCommand SendTwitterCommand { get; }
        #endregion

        #region  コンストラクタ

        public MainPageViewModel()
        {
            var tweet = new Tweet();
            SendTwitterCommand = new DelegateCommand(() => tweet.SayHelloTwitter());
        }

        #endregion
    }
}
