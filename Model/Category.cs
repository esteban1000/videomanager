﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ObservableCollection<Video> Videos { get; set; }
    }
}
