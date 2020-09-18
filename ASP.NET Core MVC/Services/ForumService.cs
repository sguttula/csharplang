using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW3.Models;
using Microsoft.EntityFrameworkCore;

namespace HW3.Services
{
    public class ForumService
    {
        public interface IForumService
        {
            List<Forums> GetForums();
            Forums GetForum(int id);
            Forums GetForum(string forumname);
            Topics GetTopic(int id);
            Replies GetReply(int id);
            List<Topics> GetTopics(int id);
            List<Replies> GetReplies(int id);
            void AddTopicToForum(Topics topic);
            void AddForum(Forums forum);
            void AddTopic(Topics topic);
            void AddReply(Replies reply);
            void UpdateForum(Forums update);
        }

        public class ForumsService : IForumService
        {
            private readonly AppDbContext db;

            public ForumsService(AppDbContext db)
            {
                this.db = db;
            }

            public void AddForum(Forums forum)
            {
                db.HW3Forums.Add(forum);
                db.SaveChanges();
            }

            public void AddTopicToForum(Topics topic)
            {
                db.HW3Topics.Add(topic);
                db.SaveChanges();
            }
            public void AddTopic(Topics topic)
            {
               db.HW3Topics.Add(topic);
               db.SaveChanges();
            }

            public Forums GetForum(int id)
            {
                return db.HW3Forums.Where(e => e.Id == id).Include(e => e.Topics).SingleOrDefault();
            }

            public Forums GetForum(string forumnamespecific)
            {
                return db.HW3Forums.Where(e => e.ForumName == forumnamespecific).SingleOrDefault();
            }
            public List<Forums> GetForums()
            {
                return db.HW3Forums.ToList();
            }

            public List<Topics> GetTopics(int id)
            {
                return db.HW3Topics.Where(f => f.ForumId == id).Include(f => f.Forum).ToList();
            }

            public void UpdateForum(Forums update)
            {
                throw new NotImplementedException();
            }

            public Topics GetTopic(int id)
            {
                return db.HW3Topics.Where(e => e.Id == id).Include(e => e.Replies).SingleOrDefault();
            }

            public Replies GetReply(int id)
            {
                throw new NotImplementedException();
            }

            public List<Replies> GetReplies(int id)
            {
                return db.HW3Replies.Where(f => f.TopicId == id).Include(f => f.Topic).ToList();
            }

            public void AddReply(Replies reply)
            {
                db.HW3Replies.Add(reply);
                db.SaveChanges();
            }
        }
    }
}
