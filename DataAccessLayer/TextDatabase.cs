using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic;
using Logic.Interfaces;
using Model;

namespace DataAccessLayer
{
    public class TextDatabase : IDatabase
    {
        public TextDatabase(string pathToFile)
        {

        }

        public Video[] GetAllVideo()
        {
            throw new NotImplementedException();
        }

        public Video GetVideoById()
        {
            throw new NotImplementedException();
        }

        public void CreateVideo(Video video)
        {
            throw new NotImplementedException();
        }

        public Category[] GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById()
        {
            throw new NotImplementedException();
        }

        public void CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
