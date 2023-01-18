using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitylayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set;}
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        //ilişki
        public int CategoryID { get; set; }
        public Category Category { get; set; }  //---sonsuz


        //ilişkı
        public List<Comment> Comments { get; set; }  //1---

        // ilişki 37
        public int WriterID { get; set; }
        public Writer Writer { get; set; }



    }
}
