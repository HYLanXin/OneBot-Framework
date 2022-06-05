using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XinBotDBEntity.CommonEntity
{
    public class BaseEntity<T>
    {
        [Required, DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [Required, DisplayName("创建人")]
        public long Creater { get; set; } = 943289922;

        [Required, DisplayName("修改时间")]
        public DateTime ModifiedTime { get; set; } = DateTime.Now;

        [Required, DisplayName("修改人")]
        public long Modifier { get; set; } = 943289922;

        [Required, DisplayName("时间戳")]
        public long TimeStamp { get { return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(); } }
    }
}
