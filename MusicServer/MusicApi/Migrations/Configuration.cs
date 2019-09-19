namespace MusicApi.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entities.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Entities.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var album = new Album();
            album.SortCode = "01";
            album.Title = "后来";
            album.Singer = "刘若英";
            album.Src = "/music/01.mp3";
            album.CoverImgUrl = "/images/cover.jpg";

            var album1 = new Album();
            album1.SortCode = "02";
            album1.Title = "天籁之音";
            album1.Singer = "蔡琴";
            album1.Src = "/music/01.mp3";
            album1.CoverImgUrl = "/images/cover1.jpg";

            var album2 = new Album();
            album2.SortCode = "03";
            album2.Title = "周杰伦";
            album2.Singer = "周杰伦";
            album2.Src = "/music/01.mp3";
            album2.CoverImgUrl = "/images/cover2.jpg";

            var album3 = new Album();
            album3.SortCode = "04";
            album3.Title = "给你一点颜色";
            album3.Singer = "谭维维";
            album3.Src = "/music/01.mp3";
            album3.CoverImgUrl = "/images/cover3.jpg";

            var album4 = new Album();
            album4.SortCode = "04";
            album4.Title = "钢琴";
            album4.Singer = "理查.克莱德曼";
            album4.Src = "/music/01.mp3";
            album4.CoverImgUrl = "/images/cover4.jpg";

            var album5 = new Album();
            album5.SortCode = "05";
            album5.Title = "美丽的下午";
            album5.Singer = "Alin";
            album5.Src = "/music/01.mp3";
            album5.CoverImgUrl = "/images/cover5.jpg";

            context.Albums.Add(album);
            context.Albums.Add(album1);
            context.Albums.Add(album2);
            context.Albums.Add(album3);
            context.Albums.Add(album4);
            context.Albums.Add(album5);
            context.SaveChanges();

            var ad1 = new Advertisement();
            ad1.ImgUrl = "/images/banner.jpg";
            ad1.ActionUrl = "http://www.lzzy.net";
            var ad2 = new Advertisement();
            ad2.ImgUrl = "/images/banner1.jpg";
            ad2.ActionUrl = "http://www.lzzy.net";
            var ad3 = new Advertisement();
            ad3.ImgUrl = "/images/banner2.jpg";
            ad3.ActionUrl = "http://www.lzzy.net";
            var ad4 = new Advertisement();
            ad4.ImgUrl = "/images/banner3.jpg";
            ad4.ActionUrl = "http://www.lzzy.net";

            context.Advertisements.Add(ad1);
            context.Advertisements.Add(ad2);
            context.Advertisements.Add(ad3);
            context.Advertisements.Add(ad4);

            context.SaveChanges();
        }
    }
}
