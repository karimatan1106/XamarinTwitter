using System.Threading;
using CoreTweet;

namespace XamarinTweet.Models
{
    public class Tweet
    {
        #region 認証パラメータ
        private const string Consumer_Key = "Your ConsumerKey";
        private const string Consumer_Secret = "Your ConsumerSecuret";
        private const string Access_Token = "Your AccessToken";
        private const string Access_Token_Secret = "Your AccessTokenSecret";
        #endregion

        #region フィールド
        private readonly Tokens _tokens;
        #endregion

        #region コンストラクタ
        public Tweet()
        {
            // API にアクセスするためのトークン群
            _tokens = Tokens.Create(
                Consumer_Key,
                Consumer_Secret,
                Access_Token,
                Access_Token_Secret
            );
        }
        #endregion

        #region メソッド
        public void SayHelloTwitter()
        {
            var tokenSource = new CancellationTokenSource();
            _tokens.Statuses.UpdateAsync(
                new { status = "Hello Twitter" },
                tokenSource.Token
            );
        }
        #endregion
    }
}
