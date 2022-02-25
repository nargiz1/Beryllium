using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class HomeViewModels
    {
        public List<Banner> Banners { get; set; }
        public List<Project> Projects { get; set; }
        public List<News> News { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Offer> Offers { get; set; }
    }
}
