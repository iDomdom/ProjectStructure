using ProjectStructure.MainDmnsns;
using ProjectStructure.Walls;
using System.Reflection.Metadata;

namespace ProjectStructure
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public User User { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public TechnicalTask.TechnicalTask TechnicalTask { get; set; }
        public MainDimensions MainDimensions { get; set; }
        public List<Wall> Walls { get; set; }
    }
}