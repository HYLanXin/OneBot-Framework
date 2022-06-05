
using XinBotDBEntity;
using Sora.Entities;

namespace XinBot.PublicCommon
{
    public static class GroupHelper
    {
        /// <summary>
        /// 获取指定机器人所有的群列表信息
        /// </summary>
        /// <param name="botid"></param>
        public static void GetBotGroupInfoLists(this long botid) 
        {
            using (BotDbEntity db = new BotDbEntity()) 
            {
                var grouplist = db.BotServer_GroupInfos.Where(e => e.BotId == botid).ToList();

            }
        }

        public static void AddGroupToDB(this Group groupinfo) 
        { 
            
        }
    }
}
