using coderoot.DataLayer.Interfaces;
using coderoot.Entities;

namespace coderoot.DataLayer
{
    public class SeedManager : ISeedManager
    {
        private readonly DataContext _context;
        public SeedManager(DataContext context)
        {
            _context = context;
        }

        public void InitializeAsync()
        {
             SeedTopics();
        }

        public void SeedTopics()
        {

            var topic = new List<Topic>
            {
                new Topic
                {
                    TopicId = 1,
                    Name = "Loop"
                },
                new Topic
                {
                    TopicId = 2,
                    Name = "Array"
                },
                new Topic
                {
                    TopicId = 3,
                    Name = "String"
                },
                new Topic
                {
                    TopicId = 4,
                    Name = "Recursion"
                },
                new Topic
                {
                    TopicId = 5,
                    Name = "Math"
                },

            };

            var existingTopics = _context.Topic.Select(x => x.TopicId);

            var topicsToAdd = topic.Where(x => !existingTopics.Contains(x.TopicId));

            if (topicsToAdd.Any())
            {
                _context.Topic.AddRange(topicsToAdd);
                _context.SaveChanges();
            }
        }
    }
}
