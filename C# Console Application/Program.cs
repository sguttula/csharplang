using System;
using System.Collections.Generic;

namespace Homework1
{
    class Program
    {
        public static List<string> Forums { get; set; } = new List<String>();
        public static String mainMenuInput;
        public static String forumInput;
        public static String topicInput;
        public static String replyInput;
        public static int number;
        public static int number2;
        public static int number3;
        public static string forumEntry;
        public static string topicEntry;
        public static string replyEntry;
        public static int forumPlaceholder;
        static void Main(string[] args)
        {          
            Console.WriteLine("Main Menu");        
            Console.WriteLine();
            MainMenu();
        }
        static void MainMenu()
        {
            DateTime current = DateTime.Now;
            string curr = current.ToString("g");
            string optionForum = "n) Create New Forum";
            string optionExit = "x) Exit";
            Console.WriteLine(optionForum);
            Console.WriteLine(optionExit);
            Console.WriteLine();
            Console.Write("Please enter your choice: ");
            mainMenuInput = (Console.ReadLine());
            number = 0;         
            if (int.TryParse(mainMenuInput, out number))
            {               
                if(number < 1 || number > Forums.Count)
                {
                    Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                    int placeholder = 0;
                    foreach (var forum in Forums)
                    {
                        placeholder = placeholder + 1;
                        Console.WriteLine("{0}) Forum - {1}", placeholder, forum);
                    }
                    MainMenu();
                }
                else
                {                   
                    int address = number - 1;
                    forumEntry = Forums[address]; 
                    if (number == 1)
                    {
                        int placeholder1 = 0;
                        if(TopicsForum1.Count == 0)
                        {
                            ForumMenu();
                        }
                        else
                        {
                            foreach (string topic1 in TopicsForum1)
                            {
                                placeholder1 = placeholder1 + 1;
                                Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder1, topic1, curr);
                            }
                            ForumMenu();
                        }                      
                    }
                    else if (number == 2)
                    {                     
                        int placeholder2 = 0;
                        if(TopicsForum2.Count == 0)
                        {
                            ForumMenu();
                        }
                        else
                        {
                            foreach (string topic2 in TopicsForum2)
                            {
                                placeholder2 = placeholder2 + 1;
                                Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder2, topic2, curr);
                            }
                            ForumMenu();
                        }                        
                    }
                    else if (number == 3)
                    {
                        int placeholder3 = 0;
                        if (TopicsForum3.Count == 0)
                        {
                            ForumMenu();
                        }
                        else
                        {
                            foreach (string topic3 in TopicsForum3)
                            {
                                placeholder3 = placeholder3 + 1;
                                Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder3, topic3, curr);
                            }
                            ForumMenu();
                        }                        
                    }
                    else if (number == 4)
                    {
                        int placeholder4 = 0;
                        foreach (string topic4 in TopicsForum4)
                        {
                            placeholder4 = placeholder4 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder4, topic4, curr);
                        }
                        ForumMenu();
                    }
                    else if (number == 5)
                    {
                        int placeholder5 = 0;
                        foreach (string topic5 in TopicsForum5)
                        {
                            placeholder5 = placeholder5 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder5, topic5, curr);
                        }
                        ForumMenu();
                    }
                    else if (number == 6)
                    {
                        int placeholder6 = 0;
                        foreach (string topic6 in TopicsForum6)
                        {
                            placeholder6 = placeholder6 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder6, topic6, curr);
                        }
                        ForumMenu();
                    }
                    else if (number == 7)
                    {
                        int placeholder7 = 0;
                        foreach (string topic7 in TopicsForum7)
                        {
                            placeholder7 = placeholder7 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder7, topic7, curr);
                        }
                        ForumMenu();
                    }
                    else if (number == 8)
                    {
                        int placeholder8 = 0;
                        foreach (string topic8 in TopicsForum8)
                        {
                            placeholder8 = placeholder8 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder8, topic8, curr);
                        }
                        ForumMenu();
                    }
                    else if (number == 9)
                    {
                        int placeholder9 = 0;
                        foreach (string topic9 in TopicsForum9)
                        {
                            placeholder9 = placeholder9 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder9, topic9, curr);
                        }
                        ForumMenu();
                    }
                    else if (number == 10)
                    {
                        int placeholder10 = 0;
                        foreach (string topic10 in TopicsForum10)
                        {
                            placeholder10 = placeholder10 + 1;
                            Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder10, topic10, curr);
                        }
                        ForumMenu();
                    }
                }
            }
            else if (mainMenuInput == "n")
            {
                CreateNewForum();
            }
            else if(mainMenuInput == "x")
            {
                return;
            }           
            else
            {
                Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                Console.WriteLine();
                int placeholder2 = 0;
                foreach (var forum in Forums)
                {
                    placeholder2 = placeholder2 + 1;
                    Console.WriteLine("{0}) Forum - {1}", placeholder2, forum);
                }
                MainMenu();
            }  
        }
        static void CreateNewForum()
        {
            Console.WriteLine();
            Console.Write("Please enter the name of the new forum: ");
            string newForum = Console.ReadLine();           
            Forums.Add(newForum);
            forumPlaceholder = 0;
            foreach (string forum in Forums)
            {
                forumPlaceholder += 1;
                Console.WriteLine("{0}) Forum - {1}", forumPlaceholder, forum);               
            }
            MainMenu();
        }
        static void ForumMenu()
        {
            DateTime current = DateTime.Now;
            string topicCreation = current.ToString("g");
            int specialCount = 0;
            Console.WriteLine();
            Console.WriteLine("Forum - {0}", forumEntry);
            Console.WriteLine();
            string optionTopic = "n) Create New Topic";
            string optionExit = "b) Back to Main Menu";
            Console.WriteLine(optionTopic);
            Console.WriteLine(optionExit);
            Console.WriteLine();
            Console.Write("Please enter your choice: ");
            forumInput = Console.ReadLine();
            if (int.TryParse(forumInput, out number2))
            {
                if(number == 1)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum1[address];
                    if (number2 < 1 || number2 > TopicsForum1.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum1)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum1Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum1Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum1Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum1Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum1Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 2)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum2[address];
                    if (number2 < 1 || number2 > TopicsForum2.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum2)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum2Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum2Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum2Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum2Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum2Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 3)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum3[address];
                    if (number2 < 1 || number2 > TopicsForum3.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum3)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum3Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum3Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum3Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum3Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum3Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 4)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum4[address];
                    if (number2 < 1 || number2 > TopicsForum4.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum4)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum4Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum4Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum4Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum4Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum4Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 5)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum5[address];
                    if (number2 < 1 || number2 > TopicsForum5.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum5)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum5Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum5Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum5Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum5Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum5Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 6)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum6[address];
                    if (number2 < 1 || number2 > TopicsForum6.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum6)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum6Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum6Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum6Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum6Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum6Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 7)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum7[address];
                    if (number2 < 1 || number2 > TopicsForum7.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum7)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum7Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum7Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum7Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum7Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum7Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 8)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum8[address];
                    if (number2 < 1 || number2 > TopicsForum8.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum8)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum8Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum8Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum8Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum8Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum8Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 9)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum9[address];
                    if (number2 < 1 || number2 > TopicsForum9.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum9)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum9Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum9Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum9Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum9Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum9Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else if (number == 10)
                {
                    int address = (number2 - 1);
                    topicEntry = TopicsForum10[address];
                    if (number2 < 1 || number2 > TopicsForum10.Count)
                    {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int placeholder = 0;
                        foreach (var top in TopicsForum10)
                        {
                            placeholder = placeholder + 1;
                            Console.WriteLine("{0}) Topic - {1}", placeholder, top);
                        }
                        ForumMenu();
                    }
                    else if (number2 == 1)
                    {
                        foreach (var reply in Forum10Topic1Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 2)
                    {
                        foreach (var reply in Forum10Topic2Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 3)
                    {
                        foreach (var reply in Forum10Topic3Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 4)
                    {
                        foreach (var reply in Forum10Topic4Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                    else if (number2 == 5)
                    {
                        foreach (var reply in Forum10Topic5Replies)
                        {
                            Console.WriteLine("Reply: {0} (Posted on {1})", reply, topicCreation);
                        }
                        TopicMenu();
                    }
                }
                else
                {
                    Console.WriteLine("PLEASE ENTER A VALID INPUT.");
                    ForumMenu();
                }               
            }
            else if (forumInput == "n")
            {                
                CreateNewTopic();
            }
            else if (forumInput == "b")
            {                
                foreach (var forum_b in Forums)
                {
                    specialCount = specialCount + 1;
                    Console.WriteLine("{0}) Forum - {1}", specialCount, forum_b);
                }
                MainMenu();
            }           
            else
            {
                if (number == 1)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder1 = 0;
                        foreach (var top in TopicsForum1)
                        {
                           elseplaceholder1 = elseplaceholder1 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder1, top);
                        }
                        ForumMenu();
                }
                else if (number == 2)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder2 = 0;
                        foreach (var top in TopicsForum2)
                        {
                            elseplaceholder2 = elseplaceholder2 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder2, top);
                        }
                        ForumMenu();
                }
                else if (number == 3)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder3 = 0;
                        foreach (var top in TopicsForum3)
                        {
                            elseplaceholder3 = elseplaceholder3 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder3, top);
                        }
                        ForumMenu();
                }
                else if (number == 4)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder4 = 0;
                        foreach (var top in TopicsForum4)
                        {
                            elseplaceholder4 = elseplaceholder4 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder4, top);
                        }
                        ForumMenu();
                }
                else if (number == 5)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder5 = 0;
                        foreach (var top in TopicsForum5)
                        {
                            elseplaceholder5 = elseplaceholder5 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder5, top);
                        }
                        ForumMenu();
                }
                else if (number == 6)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder6 = 0;
                        foreach (var top in TopicsForum6)
                        {
                            elseplaceholder6 = elseplaceholder6 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder6, top);
                        }
                        ForumMenu();
                }
                else if (number == 7)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder7 = 0;
                        foreach (var top in TopicsForum7)
                        {
                            elseplaceholder7 = elseplaceholder7 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder7, top);
                        }
                        ForumMenu();
                }
                else if (number == 8)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder8 = 0;
                        foreach (var top in TopicsForum8)
                        {
                            elseplaceholder8 = elseplaceholder8 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder8, top);
                        }
                        ForumMenu();
                }
                else if (number == 9)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder9 = 0;
                        foreach (var top in TopicsForum9)
                        {
                            elseplaceholder9 = elseplaceholder9 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder9, top);
                        }
                        ForumMenu();
                }
                else if (number == 10)
                {
                        Console.WriteLine("PLEASE ENTER A VALID OPTION.");
                        int elseplaceholder10 = 0;
                        foreach (var top in TopicsForum10)
                        {
                            elseplaceholder10 = elseplaceholder10 + 1;
                            Console.WriteLine("{0}) Topic - {1}", elseplaceholder10, top);
                        }
                        ForumMenu();                   
                }
            }
        }      
        static void CreateNewTopic()
        {
            DateTime current = DateTime.Now;
            string curr = current.ToString("g");
            Console.WriteLine();
            Console.Write("Please enter the name of the new topic: ");
            string newTopic = Console.ReadLine();
            if(number == 1)
            {
                TopicsForum1.Add(newTopic);
                int placeholder1 = 0;
                foreach (string topic1 in TopicsForum1)
                {
                    placeholder1 = placeholder1 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder1, topic1, curr);
                }
                ForumMenu();
            }
            else if(number == 2)
            {
                TopicsForum2.Add(newTopic);
                int placeholder2 = 0;
                foreach (string topic2 in TopicsForum2)
                {
                    placeholder2 = placeholder2 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder2, topic2, curr);
                }
                ForumMenu();
            }
            else if (number == 3)
            {
                TopicsForum3.Add(newTopic);
                int placeholder3 = 0;
                foreach (string topic3 in TopicsForum3)
                {
                    placeholder3 = placeholder3 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder3, topic3, curr);
                }
                ForumMenu();
            }
            else if (number == 4)
            {
                TopicsForum4.Add(newTopic);
                int placeholder4 = 0;
                foreach (string topic4 in TopicsForum4)
                {
                    placeholder4 = placeholder4 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder4, topic4, curr);
                }
                ForumMenu();
            }
            else if (number == 5)
            {
                TopicsForum5.Add(newTopic);
                int placeholder5 = 0;
                foreach (string topic5 in TopicsForum5)
                {
                    placeholder5 = placeholder5 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder5, topic5, curr);
                }
                ForumMenu();
            }
            else if (number == 6)
            {
                TopicsForum6.Add(newTopic);
                int placeholder6 = 0;
                foreach (string topic6 in TopicsForum6)
                {
                    placeholder6 = placeholder6 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder6, topic6, curr);
                }
                ForumMenu();
            }
            else if (number == 7)
            {
                TopicsForum7.Add(newTopic);
                int placeholder7 = 0;
                foreach (string topic7 in TopicsForum7)
                {
                    placeholder7 = placeholder7 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder7, topic7, curr);
                }
                ForumMenu();
            }
            else if (number == 8)
            {
                TopicsForum8.Add(newTopic);
                int placeholder8 = 0;
                foreach (string topic8 in TopicsForum8)
                {
                    placeholder8 = placeholder8 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder8, topic8, curr);
                }
                ForumMenu();
            }
            else if (number == 9)
            {
                TopicsForum9.Add(newTopic);
                int placeholder9 = 0;
                foreach (string topic9 in TopicsForum9)
                {
                    placeholder9 = placeholder9 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder9, topic9, curr);
                }
                ForumMenu();
            }
            else if (number == 10)
            {
                TopicsForum10.Add(newTopic);
                int placeholder10 = 0;
                foreach (string topic10 in TopicsForum10)
                {
                    placeholder10 = placeholder10 + 1;
                    Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder10, topic10, curr);
                }
                ForumMenu();
            }        
        }
        static void TopicMenu()
        {
            DateTime current = DateTime.Now;
            string curr = current.ToString("g");
            Console.WriteLine();
            Console.WriteLine("Topic - {0} (Posted on {1})", topicEntry, curr);
            Console.WriteLine();
            string optionReply = "n) Create New Reply";
            string optionExit = "b) Back to Forum Menu";
            Console.WriteLine(optionReply);
            Console.WriteLine(optionExit);
            Console.WriteLine();
            Console.Write("Please enter your choice: ");
            topicInput = Console.ReadLine();
            if (topicInput == "n")
            {
                CreateNewReply();
            }
            else if (topicInput == "b")
            {
                if (number == 1)
                {
                    int placeholder1 = 0;
                    foreach (string topic1 in TopicsForum1)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder1, topic1, curr);
                    }
                    ForumMenu();
                }
                else if (number == 2)
                {
                    int placeholder2 = 0;
                    foreach (string topic2 in TopicsForum2)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder2, topic2, curr);
                    }
                    ForumMenu();
                }
                else if (number == 3)
                {
                    int placeholder3 = 0;
                    foreach (string topic3 in TopicsForum3)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder3, topic3, curr);
                    }
                    ForumMenu();
                }
                else if (number == 4)
                {
                    int placeholder4 = 0;
                    foreach (string topic4 in TopicsForum4)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder4, topic4, curr);
                    }
                    ForumMenu();
                }
                else if (number == 5)
                {
                    int placeholder5 = 0;
                    foreach (string topic5 in TopicsForum5)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder5, topic5, curr);
                    }
                    ForumMenu();
                }
                else if (number == 6)
                {
                    int placeholder6 = 0;
                    foreach (string topic6 in TopicsForum6)
                    {
                        placeholder6 = placeholder6 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder6, topic6, curr);
                    }
                    ForumMenu();
                }
                else if (number == 7)
                {
                    int placeholder7 = 0;
                    foreach (string topic7 in TopicsForum7)
                    {
                        placeholder7 = placeholder7 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder7, topic7, curr);
                    }
                    ForumMenu();
                }
                else if (number == 8)
                {
                    int placeholder8 = 0;
                    foreach (string topic8 in TopicsForum8)
                    {
                        placeholder8 = placeholder8 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder8, topic8, curr);
                    }
                    ForumMenu();
                }
                else if (number == 9)
                {
                    int placeholder9 = 0;
                    foreach (string topic9 in TopicsForum9)
                    {
                        placeholder9 = placeholder9 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder9, topic9, curr);
                    }
                    ForumMenu();
                }
                else if (number == 10)
                {
                    int placeholder10 = 0;
                    foreach (string topic10 in TopicsForum10)
                    {
                        placeholder10 = placeholder10 + 1;
                        Console.WriteLine("{0}) Topic - {1} (Posted on {2})", placeholder10, topic10, curr);
                    }
                    ForumMenu();
                }      
            }         
            else
            {
                Console.WriteLine("Please enter a valid option.");
                Console.WriteLine();
                TopicMenu();
            }
        }
        static void CreateNewReply()
        {
            DateTime current = DateTime.Now;
            string curr = current.ToString("g");
            Console.WriteLine();
            Console.Write("Please enter the name of the new reply: ");
            string newReply = Console.ReadLine();
            //Replies.Add(newReply);
            if(number == 1)
            {
                if (number2 == 1)
                {
                    Forum1Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum1Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum1Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum1Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum1Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum1Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum1Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum1Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum1Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum1Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 2)
            {
                if (number2 == 1)
                {
                    Forum2Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum2Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum2Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum2Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum2Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum2Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum2Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum2Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum2Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum2Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 3)
            {
                if (number2 == 1)
                {
                    Forum3Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum3Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum3Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum3Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum3Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum3Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum3Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum3Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum3Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum3Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 4)
            {
                if (number2 == 1)
                {
                    Forum4Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum4Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum4Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum4Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum4Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum4Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum4Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum4Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum4Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum4Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 5)
            {
                if (number2 == 1)
                {
                    Forum5Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum5Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum5Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum5Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum5Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum5Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum5Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum5Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum5Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum5Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 6)
            {
                if (number2 == 1)
                {
                    Forum6Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum6Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum6Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum6Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum6Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum6Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum6Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum6Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum6Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum6Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 7)
            {
                if (number2 == 1)
                {
                    Forum7Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum7Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum7Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum7Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum7Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum7Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum7Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum7Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum7Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum7Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 8)
            {
                if (number2 == 1)
                {
                    Forum8Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum8Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum8Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum8Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum8Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum8Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum8Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum8Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum8Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum8Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 9)
            {
                if (number2 == 1)
                {
                    Forum9Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum9Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 2)
                {
                    Forum9Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum9Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 3)
                {
                    Forum9Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum9Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum9Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum9Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum9Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum9Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
            else if (number == 10)
            {
                if (number2 == 1)
                {
                    Forum10Topic1Replies.Add(newReply);
                    int placeholder1 = 0;
                    foreach (string reply in Forum10Topic1Replies)
                    {
                        placeholder1 = placeholder1 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    ForumMenu();
                }
                else if (number2 == 2)
                {
                    Forum10Topic2Replies.Add(newReply);
                    int placeholder2 = 0;
                    foreach (string reply in Forum10Topic2Replies)
                    {
                        placeholder2 = placeholder2 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    ForumMenu();
                }
                else if (number2 == 3)
                {
                    Forum10Topic3Replies.Add(newReply);
                    int placeholder3 = 0;
                    foreach (string reply in Forum10Topic3Replies)
                    {
                        placeholder3 = placeholder3 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 4)
                {
                    Forum10Topic4Replies.Add(newReply);
                    int placeholder4 = 0;
                    foreach (string reply in Forum10Topic4Replies)
                    {
                        placeholder4 = placeholder4 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
                else if (number2 == 5)
                {
                    Forum10Topic5Replies.Add(newReply);
                    int placeholder5 = 0;
                    foreach (string reply in Forum10Topic5Replies)
                    {
                        placeholder5 = placeholder5 + 1;
                        Console.WriteLine("Reply: {0} (Posted on {1})", reply, curr);
                    }
                    TopicMenu();
                }
            }
        }
        public static List<string> TopicsForum1 = new List<String>();
        public static List<string> TopicsForum2 = new List<String>();
        public static List<string> TopicsForum3 = new List<String>();
        public static List<string> TopicsForum4 = new List<String>();
        public static List<string> TopicsForum5 = new List<String>();
        public static List<string> TopicsForum6 = new List<String>();
        public static List<string> TopicsForum7 = new List<String>();
        public static List<string> TopicsForum8 = new List<String>();
        public static List<string> TopicsForum9 = new List<String>();
        public static List<string> TopicsForum10 = new List<String>();

        public static List<string> Forum1Topic1Replies = new List<String>();
        public static List<string> Forum1Topic2Replies = new List<String>();
        public static List<string> Forum1Topic3Replies = new List<String>();
        public static List<string> Forum1Topic4Replies = new List<String>();
        public static List<string> Forum1Topic5Replies = new List<String>();

        public static List<string> Forum2Topic1Replies = new List<String>();
        public static List<string> Forum2Topic2Replies = new List<String>();
        public static List<string> Forum2Topic3Replies = new List<String>();
        public static List<string> Forum2Topic4Replies = new List<String>();
        public static List<string> Forum2Topic5Replies = new List<String>();

        public static List<string> Forum3Topic1Replies = new List<String>();
        public static List<string> Forum3Topic2Replies = new List<String>();
        public static List<string> Forum3Topic3Replies = new List<String>();
        public static List<string> Forum3Topic4Replies = new List<String>();
        public static List<string> Forum3Topic5Replies = new List<String>();

        public static List<string> Forum4Topic1Replies = new List<String>();
        public static List<string> Forum4Topic2Replies = new List<String>();
        public static List<string> Forum4Topic3Replies = new List<String>();
        public static List<string> Forum4Topic4Replies = new List<String>();
        public static List<string> Forum4Topic5Replies = new List<String>();

        public static List<string> Forum5Topic1Replies = new List<String>();
        public static List<string> Forum5Topic2Replies = new List<String>();
        public static List<string> Forum5Topic3Replies = new List<String>();
        public static List<string> Forum5Topic4Replies = new List<String>();
        public static List<string> Forum5Topic5Replies = new List<String>();

        public static List<string> Forum6Topic1Replies = new List<String>();
        public static List<string> Forum6Topic2Replies = new List<String>();
        public static List<string> Forum6Topic3Replies = new List<String>();
        public static List<string> Forum6Topic4Replies = new List<String>();
        public static List<string> Forum6Topic5Replies = new List<String>();

        public static List<string> Forum7Topic1Replies = new List<String>();
        public static List<string> Forum7Topic2Replies = new List<String>();
        public static List<string> Forum7Topic3Replies = new List<String>();
        public static List<string> Forum7Topic4Replies = new List<String>();
        public static List<string> Forum7Topic5Replies = new List<String>();

        public static List<string> Forum8Topic1Replies = new List<String>();
        public static List<string> Forum8Topic2Replies = new List<String>();
        public static List<string> Forum8Topic3Replies = new List<String>();
        public static List<string> Forum8Topic4Replies = new List<String>();
        public static List<string> Forum8Topic5Replies = new List<String>();

        public static List<string> Forum9Topic1Replies = new List<String>();
        public static List<string> Forum9Topic2Replies = new List<String>();
        public static List<string> Forum9Topic3Replies = new List<String>();
        public static List<string> Forum9Topic4Replies = new List<String>();
        public static List<string> Forum9Topic5Replies = new List<String>();

        public static List<string> Forum10Topic1Replies = new List<String>();
        public static List<string> Forum10Topic2Replies = new List<String>();
        public static List<string> Forum10Topic3Replies = new List<String>();
        public static List<string> Forum10Topic4Replies = new List<String>();
        public static List<string> Forum10Topic5Replies = new List<String>();
    }
}
