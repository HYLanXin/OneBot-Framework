using System.Threading.Tasks;
using OneBot.CommandRoute.Models;
using Sora.EventArgs.SoraEvent;

namespace OneBot.CommandRoute.Services;

/// <summary>
/// OneBot 中间件
/// </summary>
public interface IOneBotMiddleware
{
    /// <summary>
    /// OneBot 中间件处理
    /// </summary>
    /// <param name="oneBotContext">OneBot 事件上下文</param>
    /// <param name="next">下一步</param>
    /// <returns></returns>
    public ValueTask Invoke<T>(OneBotContext<T> oneBotContext, OneBotRequestDelegate<T> next)
        where T : BaseSoraEventArgs;
}
