using Sora.Server;

namespace OneBot.CommandRoute.Services
{
    public interface IBotService
    {
        //��ʼ��������ʵ��
        SoraWSServer Server { get; set; }
        void Start();
    }
}
