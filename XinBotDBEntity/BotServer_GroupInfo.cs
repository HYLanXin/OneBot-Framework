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

        public List<BotServer_GroupFunList>? GroupFunList { get; set; }
    }
}
