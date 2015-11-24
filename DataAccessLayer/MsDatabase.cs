using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.Interfaces;
using Model;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class MsDatabase : IDatabase
    {
        private string connstring;

        public MsDatabase(string connectionString)
        {
            connstring = connectionString;
        }

        public Video[] GetAllVideo()
        {
            List<Video> myVideos = new List<Video>();
            SqlConnection myConn = new SqlConnection(connstring);
            myConn.Open();

            SqlCommand mySqlCommand = new SqlCommand("select * from video", myConn);
            SqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Video myVideo = new Video();
                object id = reader["Id"];
                
                if(id != null)
                {
                    int videoId = -1;
                    if (!int.TryParse(id.ToString(), out videoId))
                    {
                        throw new Exception("Failed to parse Id of video.");
                    }

                    myVideo.Id = videoId;
                }

                myVideo.Name = reader["Name"].ToString();
                myVideo.Url = reader["Url"].ToString();
                myVideos.Add(myVideo);
            }

            myConn.Close();

            return myVideos.ToArray();
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
            List<Category> myCategories = new List<Category>();
            SqlConnection myConn = new SqlConnection(connstring);
            myConn.Open();
            
                SqlCommand mySqlCommand = new SqlCommand("select * from Category", myConn);
                SqlDataReader reader = mySqlCommand.ExecuteReader();
            
            while (reader.Read())
            {
                Category myCategory = new Category();
                object id = reader["Id"];

                if (id != null)
                {
                    int categoryId = -1;
                    if (!int.TryParse(id.ToString(), out categoryId))
                    {
                        throw new Exception("Failed to parse Id of video.");
                    }
                    myCategory.Id = categoryId;
                }

                myCategory.Name = reader["Name"].ToString();

                myCategories.Add(myCategory);
            }

            myConn.Close();

            return myCategories.ToArray();

           
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
