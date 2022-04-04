using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XinBotDBEntity
{
    [Table("BotServer_GroupInfo")]
    public class BotServer_GroupInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("主键ID")]
        public int Id { get; set; }

        [Required, MaxLength(20), DisplayName("群号")]
        public long GroupId { get; set; }

        [Required, MaxLength(20), DisplayName("区服名称")]
        public string ServerName { set; get; } = "";

        [Required, MaxLength(20), DisplayName("所属机器人账号")]
        public long BotId { get; set; }

        [Required, DisplayName("到期时间")]
        public DateTime EndTime { get; set; } = DateTime.MaxValue;

        [Required, DisplayName("是否删除")]
        public bool IsDeleted { get; set; } = false;

        [Required, DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [Required, DisplayName("创建人")]
        public long Creater { get; set; } = 943289922;

        [Required, DisplayName("修改时间")]
        public DateTime ModifiedTime { get; set; } = DateTime.Now;

        [Required, DisplayName("修改人")]
        public long Modifier { get; set; } = 943289922;

        public List<BotServer_GroupFunList>? GroupFunList { get; set; }
    }
}
