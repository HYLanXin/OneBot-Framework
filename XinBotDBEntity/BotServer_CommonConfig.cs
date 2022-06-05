using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace XinBotDBEntity
{
    [Table("BotServer_CommonConfig")]
    [Index(nameof(ConfigCode), IsUnique = true)]
    public class BotServer_CommonConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), DisplayName("主键ID")]
        public int Id { get; set; }

        [Required, DisplayName("配置名称")]
        public string ConfigName { get; set; } = "";

        [Required, DisplayName("配置编码")]
        public string ConfigCode { get; set; } = "";

        [Required, DisplayName("配置内容")]
        public string ConfigContent { get; set; } = "";

        [Required, DisplayName("是否删除")]
        public bool IsDeleted { get; set; } = false;


    }
}
