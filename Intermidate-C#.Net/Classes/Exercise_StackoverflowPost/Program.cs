using System;

namespace Exercise_StackoverflowPost
{
    public class Post
    {
        private string _title;
        private string _description;
        private int _vote;
        private DateTime _createdAt;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _createdAt = DateTime.Now;
        }

        public int UpVote()
        {
            return ++_vote;
        }

        public int DownVote()
        {
            return --_vote;
        }

        public int GetVote()
        {
            return _vote;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Life of a cat", "He is very fat and lazy cat...");
            for (var i = 0; i < 10; i++)
            {
                post.UpVote();
            }

            Console.WriteLine("UpVote 10 times: " + post.GetVote());

            post.DownVote();
            Console.WriteLine("DownVote 1 times: " + post.GetVote());
        }
    }
}
