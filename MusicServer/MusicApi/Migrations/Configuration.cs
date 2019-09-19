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
            album.Title = "∫Û¿¥";
            album.Singer = "¡ı»Ù”¢";
            album.Src = "/music/01.mp3";
            album.CoverImgUrl = "/images/cover.jpg";
            context.Albums.Add(album);
            context.SaveChanges();

            var ad = new Advertisement();
            ad.ImgUrl = "/images/banner.jpg";
            ad.ActionUrl = "http://www.lzzy.net";
            context.Advertisements.Add(ad);
            context.SaveChanges();
        }
    }
}
