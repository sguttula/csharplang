using System;
using System.Linq;

namespace Homework_2
{
    class Program
    {
        private static void ViewForum(Forum forum)
        {
            using (var db = new AppDbContext())
            {
                while (true)
                {
                    Console.WriteLine($"\nForum - {forum.Title}\n");

                    var topics = (from topic in db.Topics where topic.ForumId == forum.Id select topic).ToList();

                    for (int i = 0; i < topics.Count; i++)
                    {
                        Console.WriteLine($"  {i + 1}. Topic - {topics[i].Title} (Posted on {topics[i].PostedDateTime})");
                    }

                    Console.WriteLine("  n. Create New Topic");
                    Console.WriteLine("  b. Back to Main Menu");
                    Console.Write("\nPlease enter your choice: ");

                    string response = Console.ReadLine();

                    if (response[0] == 'n')
                    {
                        Console.Write("Enter topic title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter topic description: ");
                        string description = Console.ReadLine();

                        db.Topics.Add(new Topic(title, description, forum.Id));
                        db.SaveChanges();
                    }
                    else if (response[0] == 'b')
                    {
                        return;
                    }
                    else if (int.TryParse(response, out int selected))
                    {
                        if (1 <= selected && selected <= topics.Count)
                        {
                            ViewTopic(topics[selected - 1]);
                        }
                    }
                }
            }
        }

        private static void ViewTopic(Topic topic)
        {
            using (var db = new AppDbContext())
            {
                while (true)
                {
                    Console.WriteLine($"\nTopic - {topic.Title}\n");

                    var replies = (from reply in db.Replies where reply.TopicId == topic.Id select reply).ToList();

                    foreach (Reply reply in replies) 
                    {
                        Console.WriteLine($"  Reply (Posted on {reply.PostedDateTime}): {reply.Message}");
                    }

                    Console.WriteLine("  n. Create New Reply");
                    Console.WriteLine("  b. Back to Forum Menu");
                    Console.Write("\nPlease enter your choice: ");

                    string response = Console.ReadLine();

                    if (response[0] == 'n')
                    {
                        Console.Write("Write a reply: ");
                        db.Replies.Add(new Reply(Console.ReadLine(), topic.Id));
                        db.SaveChanges();
                    }
                    else if (response[0] == 'b')
                    {
                        return;
                    }
                }
            }
        }

        static void Main()
        {
            using (var db = new AppDbContext())
            {
                while (true)
                {
                    Console.WriteLine("\nMain Menu:\n");

                    var forums = (from forum in db.Forums select forum).ToList();

                    for (int i = 0; i < forums.Count; i++)
                    {
                        Console.WriteLine($"  {i + 1}. Forum - {forums[i].Title}");
                    }

                    Console.WriteLine("  n. Create New Forum");
                    Console.WriteLine("  x. Exit");
                    Console.Write("\nPlease enter your choice: ");

                    string response = Console.ReadLine();

                    if (response[0] == 'n')
                    {
                        Console.Write("Enter title for new forum: ");
                        db.Forums.Add(new Forum(Console.ReadLine()));
                        db.SaveChanges();
                    }
                    else if (response[0] == 'x')
                    {
                        return;
                    }
                    else if (int.TryParse(response, out int selected))
                    {
                        if (1 <= selected && selected <= forums.Count)
                        {
                            ViewForum(forums[selected - 1]);
                        }
                    }
                }
            }
        }
    }
}
