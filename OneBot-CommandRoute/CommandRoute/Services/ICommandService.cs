using System;
using System.Threading.Tasks;
using OneBot.CommandRoute.Events;
using OneBot.CommandRoute.Models;
using Sora.EventArgs.SoraEvent;

namespace OneBot.CommandRoute.Services
{
    /// <summary>
    /// 指令路由服务
    /// </summary>
    public interface ICommandService
    {
        /// <summary>
        /// 事件管理器
        /// </summary>
        public EventManager Event { get; set; }

        /// <summary>
        /// 注册指令
        /// </summary>
        public void RegisterCommand();

        /// <summary>
        /// 事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="oneBotContext"></param>
        /// <returns></returns>
        public ValueTask HandleEvent<T>(object sender, OneBotContext<T> oneBotContext) where T : BaseSoraEventArgs;


        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="oneBotContext"></param>
        /// <param name="exception"></param>
        public ValueTask EventOnException<T>(object sender, OneBotContext<T> oneBotContext, Exception exception)
            where T : BaseSoraEventArgs;
    }
}
