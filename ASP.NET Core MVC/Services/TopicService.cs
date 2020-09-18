using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW3.Models;
using Microsoft.EntityFrameworkCore;

namespace HW3.Services
{
    public class TopicService
    {
        public interface ITopicService
        {
            List<Topics> GetTopics();
            Topics GetTopic(int id);
            Topics GetTopic(string topicname);
            void AddTopic(Topics topic);
            void UpdateTopic(Topics update);
        }

        public class TopicsService : ITopicService
        {
            private readonly AppDbContext db;

            public TopicsService(AppDbContext db)
            {
                this.db = db;
            }

            public void AddTopic(Topics topic)
            {
                //throw new NotImplementedException();
                db.HW3Topics.Add(topic);
                db.SaveChanges();
            }

            public Topics GetTopic(int id)
            {
                throw new NotImplementedException();
            }

            public Topics GetTopic(string username)
            {
                throw new NotImplementedException();
            }
            /*
            public List<Forums> GetForums()
            {
                throw new NotImplementedException();
            }
            */
            public List<Topics> GetTopics()
            {
                return db.HW3Topics.ToList();
            }

            public void UpdateTopic(Topics update)
            {
                throw new NotImplementedException();
            }
        }

    }
}
