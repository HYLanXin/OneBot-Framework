
using System.Reflection;

using Microsoft.EntityFrameworkCore;

namespace XinBotDBEntity
{
    public class BotDbEntity : DbContext
    {
        public BotDbEntity()
        {
        }
        public BotDbEntity(DbContextOptions<BotDbEntity> options) : base(options)
        {
            //没有数据库要先update-database
            //add-migration NAME 添加迁移
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder) 
        //{
        //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}

        public virtual DbSet<BotServer_FunList> BotServer_FunLists { get; set; } = null!;
        public virtual DbSet<BotServer_GroupFunList> BotServer_GroupFunLists { get; set; } = null!;
        public virtual DbSet<BotServer_GroupInfo> BotServer_GroupInfos { get; set; } = null!;
        public virtual DbSet<BotServer_CommonConfig> BotServer_CommonConfigs { get; set; } = null!;
    }
}
