﻿using Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Admin.Models
{
    public class Category : BaseClass
    {
        //public Category()
        //{
        //    Subcategories = new HashSet<Subcategory>();
        //}
        public string Name { get; set; }
        public string Name_AR { get; set; }
        public string Description { get; set; }
        public string Description_AR { get; set; }
        public string Picture { get; set; }

        public int? parentId { get; set; }
        [JsonIgnore]
        public virtual Category parentCategory { get; set; }
        public virtual ICollection<Category> subCategories { get; set; }
        public virtual ICollection<Filters_Categories> Filter_categories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
