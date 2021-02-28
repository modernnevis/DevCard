using System;

namespace DevCard_MVC.Models
{
    public class Article
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public string Image { get; set; }
        public String Description { get; set; }

        public Article(int id, string title, string image, string description)
        {
            Id = id;
            Title = title;
            Image = image;
            Description = description;
        }
    }
}