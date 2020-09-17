INSERT INTO [Forums] (Title) VALUES (N'CS 101');

GO

INSERT INTO [Topics] (Title, Description, ForumId) VALUES (N'Homework 1', N'Ask all your questions about homework 1 here.', 1);

GO

INSERT INTO [Replies] (Message, TopicId) VALUES (N'Has anyone finished yet?', 1);
INSERT INTO [Replies] (Message, TopicId) VALUES (N'Nope.', 1);

GO
