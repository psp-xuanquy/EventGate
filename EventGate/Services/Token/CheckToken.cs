using EventGate.Services.Token;

namespace EventGate.Services.Token
{
    public class CheckToken : ICheckToken
    {
        public bool IsExpried(TokenDecode token)
        {
            return DateTime.Compare(token.Expried, DateTime.Now) < 0;
        }
    }
}
