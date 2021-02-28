using System;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public Project(int id, string name, string image, string description, string client)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Client = client;
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }
        public String Description { get; set; }
        public String Client { get; set; }
    }
}