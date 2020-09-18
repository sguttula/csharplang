using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW3.Models
{
    public class Forums
    {
        public int Id { get; set; }
        public String ForumName { get; set; }
        public DateTime ForumTimeStamp { get; set; }
        public List<Topics> Topics { get; set; }

        public Forums()
        {
            Topics = new List<Topics>();
        }

        public Forums(int id, String name, DateTime datetime) : this()
        {
            Id = id;
            ForumName = name;
            ForumTimeStamp = datetime;

        }
        /*
        public override string ToString()
        {
            return $"Forum - {ForumName}\tCreated on: {ForumTimeStamp}";
        }

        public void ListTheTopics()
        {
            foreach (var topics in Topics)
            {
                Console.Write($"{topics.Id}) Topic - {topics.TopicName} (Posted on {topics.TopicTimeStamp})\n");
            }
        }
        */
    }
    public class Topics
    {
        public String TopicName { get; set; }
        public DateTime TopicTimeStamp { get; set; }
        public int ForumId { get; set; }
        public Forums Forum { get; set; }
        public int Id { get; set; }
        public List<Replies> Replies { get; set; }
       
        public Topics()
        {
            Replies = new List<Replies>();
        }
        
        public Topics(String topicName, DateTime datetime, int forumid) : this()
        {
            TopicName = topicName;
            TopicTimeStamp = datetime;
            ForumId = forumid;
        }
        /*
        public override string ToString()
        {
            return $"Topic - {TopicName} (Posted on: {TopicTimeStamp})\n";
        }

        public void ListTheEntries()
        {
            foreach (var entry in Replies)
            {
                Console.Write(entry + "\n");
            }
        }
        */
    }

    public class Replies
    {
        public String Reply { get; set; }
        public DateTime ReplyTimeStamp { get; }
        public int Id { get; set; }
        public int TopicId { get; set; }
        public Topics Topic { get; set; }
        public Replies() { }
        public Replies(String reply, DateTime datetime, int topicid)
        {
            Reply = reply;
            ReplyTimeStamp = datetime;
            TopicId = topicid;
        }
        /*
        public override string ToString()
        {
            return $"Reply (Posted on {ReplyTimeStamp}) : {Reply}";
        }
        */
    }
}
