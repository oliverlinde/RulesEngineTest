using System;
namespace FAQ.models
{
    public class User
    {
        public List<Tag> Tags { get; set; }
        public User(List<Tag> tags)
        {
            Tags = tags;
        }
    }
}

