using System;

namespace Homework_2
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Forum(string title)
        {
            Title = title;
        }
    }

    public class Reply
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime PostedDateTime { get; set; }
        public int TopicId { get; set; }

        public Reply(string message, int topicId)
        {
            Message = message;
            PostedDateTime = DateTime.Now;
            TopicId = topicId;
        }
    }

    public class Topic
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime PostedDateTime { get; set; }
        public string Title { get; set; }
        public int ForumId { get; set; }

        public Topic(string title, string description, int forumId)
        {
            Description = description;
            ForumId = forumId;
            PostedDateTime = DateTime.Now;
            Title = title;
        }
    }
}
