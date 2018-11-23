using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#" },
                new Category() { KategoriAdi="ASP.NET MVC" },
                new Category() { KategoriAdi="ASP.NET Web Form" },
                new Category() { KategoriAdi="Windows Form" }
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="1.jpg",CategoryId=1},
                new Blog() { Baslik="C# Fonksiyonlar ", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="1.jpg",CategoryId=1},
                new Blog() { Baslik="C# Generic List Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=false, Onay=false, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="1.jpg",CategoryId=1},
                new Blog() { Baslik="MVC HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-8), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="2.jpg",CategoryId=2},
                new Blog() { Baslik="Model View Controller Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=true, Onay=false, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="2.jpg",CategoryId=2},
                new Blog() { Baslik="Model Binding Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=false, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="2.jpg",CategoryId=2},
                new Blog() { Baslik="Textbox HakkındaTextbox HakkındaTextbox HakkındaTextbox HakkındaTextbox HakkındaTextbox HakkındaTextbox HakkındaTextbox HakkındaTextbox HakkındaTextbox Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="3.jpg",CategoryId=3},
                new Blog() { Baslik="Click Events Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-15), Anasayfa=false, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="3.jpg",CategoryId=3},
                new Blog() { Baslik="Sql Database Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="3.jpg",CategoryId=3},
                new Blog() { Baslik="Windows Form Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-17), Anasayfa=true, Onay=false, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="4.jpg",CategoryId=4},
                new Blog() { Baslik="Panel Kullanımı Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="4.jpg",CategoryId=4},
                new Blog() { Baslik="Sql Database Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-2), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="4.jpg",CategoryId=4},
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama C# Delegates AçıklamaC# Delegates AçıklamaC# Delegates Açıklama",Resim="4.jpg",CategoryId=4},
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}