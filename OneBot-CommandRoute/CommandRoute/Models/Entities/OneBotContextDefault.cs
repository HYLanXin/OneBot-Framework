using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Sora.EventArgs.SoraEvent;

namespace OneBot.CommandRoute.Models.Entities;

public class OneBotContextDefault<T> : OneBotContext<T> where T : BaseSoraEventArgs
{
    /// <summary>
    /// Sora 基本事件参数
    /// </summary>
    public sealed override T SoraEventArgs { get; protected set; }

    /// <summary>
    /// IOC Service Scope
    /// </summary>
    public sealed override IServiceScope ServiceScope { get; protected set; }

    /// <summary>
    /// 上下文传递的内容
    /// </summary>
    public override IDictionary<object, object?> Items { get; protected set; } =
        new ConcurrentDictionary<object, object?>();


    public OneBotContextDefault(T e, IServiceScope scope)
    {
        SoraEventArgs = e;
        ServiceScope = scope;
    }
}
