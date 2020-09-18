using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW3.Models;
using Microsoft.EntityFrameworkCore;

namespace HW3.Services
{
    public class ReplyService
    {
        public interface IReplyService
        {
            List<Replies> GetReplies();
            Replies GetReply(int id);
            Replies GetReply(string replyname);
            void AddReply(Replies reply);
            void UpdateReply(Replies update);
        }

        public class RepliesService : IReplyService
        {
            private readonly AppDbContext db;

            public RepliesService(AppDbContext db)
            {
                this.db = db;
            }

            public void AddReply(Replies reply)
            {
                //throw new NotImplementedException();
                db.HW3Replies.Add(reply);
                db.SaveChanges();
            }

            public Replies GetReply(int id)
            {
                throw new NotImplementedException();
            }

            public Replies GetReply(string username)
            {
                throw new NotImplementedException();
            }
            /*
            public List<Forums> GetForums()
            {
                throw new NotImplementedException();
            }
            */
            public List<Replies> GetReplies()
            {
                return db.HW3Replies.ToList();
            }

            public void UpdateReply(Replies update)
            {
                throw new NotImplementedException();
            }
        }

    }
}
