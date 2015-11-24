using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.Interfaces;
using Model;
using System.Collections.ObjectModel;

namespace Logic
{
    public class VideoManagement : ILogic
    {
        private IDatabase _database;
        private ObservableCollection<Video> _videos;
        public ObservableCollection<Video> Videos
        {
            get
            {
                return _videos;
            }
            set
            {
                _videos = value;
            }
        }

        private ObservableCollection<Category> _categories;
        public ObservableCollection<Category> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
            }
        }

        public VideoManagement(IDatabase database)
        {
            _database = database;
            _videos = new ObservableCollection<Video>(database.GetAllVideo());
            _categories = new ObservableCollection<Category>(database.GetAllCategories());

        }

        public void MoveVideoToCategory(int categoryId, int videoId)
        {
            throw new NotImplementedException();
        }
    }
}
