using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Url { get; set; }
    }
}
