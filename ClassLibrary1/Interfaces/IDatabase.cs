using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Logic.Interfaces
{
    public interface IDatabase
    {
        Video[] GetAllVideo();
        Video GetVideoById();
        void CreateVideo(Video video);
        Category[] GetAllCategories();
        Category GetCategoryById();
        void CreateCategory(Category category);
    }
}
