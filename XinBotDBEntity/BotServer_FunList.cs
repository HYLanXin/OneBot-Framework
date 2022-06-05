using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace XinBotDBEntity
{
    [Table("BotServer_FunList")]
    public class BotServer_FunList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("主键ID")]
        public int Id { get; set; }

        [MaxLength(100), Required, DisplayName("功能名称")]

        public string FunName { get; set; } = "";
        [MaxLength(100), Required, DisplayName("功能代码")]

        public string FunCode { get; set; } = "";

        [MaxLength(100), Required, DisplayName("功能类型")]
        public string FunType { get; set; } = "梦影";

        [MaxLength(100), Required, DisplayName("功能地址")]
        public string FunUrl { get; set; } = "";

        [Required, DisplayName("间隔时间")]
        public int IntervalTime { get; set; } = 10;

        [Required, DisplayName("添加时间")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public List<BotServer_GroupFunList>? GroupFunLists { get; set; }
    }
}
