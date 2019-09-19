using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 音乐的实体
    /// </summary>
    public class Album
    {
        public Guid ID { get; set; }
        public string SortCode { get; set; }
        public string Title { get; set; }
        public string Singer { get; set; }
        public string  Src { get; set; }
        public string CoverImgUrl { get; set; }

        public Album()
        {
            ID = Guid.NewGuid();
        }
    }
}
