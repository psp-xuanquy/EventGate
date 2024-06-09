using EventGate.Services.Token;

namespace EventGate.Services.Token
{
    public interface ICheckToken
    {
        public bool IsExpried(TokenDecode token);
    }
}
