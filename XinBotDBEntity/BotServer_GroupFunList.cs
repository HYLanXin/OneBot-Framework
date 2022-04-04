using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XinBotDBEntity
{
    public class BotServer_GroupFunList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, DisplayName("功能ID")]
        public int Funid { get; set; }
        [ForeignKey("Id")]
        public BotServer_FunList? BotServer_Fun { get; set; }

        [Required, DisplayName("群信息ID")]
        public int GroupId { get; set; }
        [ForeignKey("Id")]
        public BotServer_GroupInfo? GroupInfo { get; set; }

        [Required, DisplayName("功能是否开启")]
        public bool IsOpen { get; set; } = true;

        [Required, DisplayName("是否需要管理员")]
        public bool IsAdmin { get; set; } = false;
    }
}
