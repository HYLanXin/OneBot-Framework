using Sora.Server;

namespace QQRobot.Services
{
    public interface IBotService
    {
        //��ʼ��������ʵ��
        SoraWSServer Server { get; set; }
        void Start();
    }
}
