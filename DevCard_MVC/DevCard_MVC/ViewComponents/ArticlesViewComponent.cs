using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1, "آموزش طراحی وب", "blog-post-thumb-card-1.jpg",
                    "این دوره یکی از بهترین دوره های آموزش طراحی وب است "),
                new Article(2, "آموزش فتوشاپ", "blog-post-thumb-card-2.jpg",
                    "این دوره یکی از بهترین دوره های آموزش طراحی وب است "),
                new Article(3, "آموزش فلاتر", "blog-post-thumb-card-3.jpg",
                    "این دوره یکی از بهترین دوره های آموزش طراحی وب است "),
                new Article(4, "آموزش اکسس", "blog-post-thumb-card-4.jpg",
                    "نکته بعدی در مورد متن ساختگی لورم ایپسوم این است که بعضی از طراحان وبسایت و گرافیست کاران بعد از آنکه قالب و محتوای مورد نظرشون را ایجاد کردند از یاد می‌برند که متن لورم را از قسمتهای مختلف سایت حذف کنند و یا با متن دیگری جایگزین کنند. به همین دلیل اغلب اوقات ما با وبسایتهایی مواجه می‌شویم که در گوشه و کنار صفحات آنها متن لورم ایپسوم هنوز وجود دارد و حذف نشده است که این نشان دهنده بی توجهی طراحان است. "),
            };

            return View("_Articles", articles);
        }
    }
}