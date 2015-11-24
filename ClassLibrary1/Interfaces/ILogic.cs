using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Model;

namespace Logic.Interfaces
{
    public interface ILogic
    {
        ObservableCollection<Video> Videos { get; set; }
        ObservableCollection<Category> Categories { get; set; }
        void MoveVideoToCategory(int categoryId, int videoId);
    }
}
