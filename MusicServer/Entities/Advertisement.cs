using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// 首页轮播广告实体
    /// </summary>
    public class Advertisement
    {
        public Guid ID { get; set; }
        public string  ImgUrl{get;set;}
        public string ActionUrl { get; set; }

        public Advertisement()
        {
            ID = Guid.NewGuid();
        }
    }
}
